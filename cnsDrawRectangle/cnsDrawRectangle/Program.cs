using System;
using System.Collections.Generic;

class SnakeGame
{
    static int width = 20; // Ширина игрового поля
    static int height = 10; // Высота игрового поля
    static int snakeX = 10; // Начальная позиция змейки по X
    static int snakeY = 5; // Начальная позиция змейки по Y
    static ConsoleColor snakeColor = ConsoleColor.Green; // Цвет змейки
    static List<int> snakeTailX = new List<int>(); // Координаты хвоста змейки по X
    static List<int> snakeTailY = new List<int>(); // Координаты хвоста змейки по Y
    static int fruitX; // Позиция фрукта по X
    static int fruitY; // Позиция фрукта по Y
    static ConsoleColor fruitColor = ConsoleColor.Red; // Цвет фрукта
    static int score = 0; // Счет игры
    static bool gameOver = false; // Флаг окончания игры

    static void Main()
    {
        Console.Title = "Змейка";
        Console.CursorVisible = false;
        Console.SetWindowSize(width + 2, height + 4);
        Console.SetBufferSize(width + 2, height + 4);

        // Инициализация змейки
        snakeTailX.Add(snakeX);
        snakeTailY.Add(snakeY);

        // Генерация фрукта
        GenerateFruit();

        // Главный игровой цикл
        while (!gameOver)
        {
            // Обработка нажатий клавиш
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        MoveSnake(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        MoveSnake(1, 0);
                        break;
                    case ConsoleKey.UpArrow:
                        MoveSnake(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        MoveSnake(0, 1);
                        break;
                }
            }

            // Движение змейки
            MoveSnake(0, 0);

            // Отрисовка игрового поля
            DrawField();

            // Задержка для обновления экрана
            System.Threading.Thread.Sleep(100);
        }

        // Вывод сообщения о конце игры
        Console.Clear();
        Console.SetCursorPosition(width / 2 - 4, height / 2);
        Console.WriteLine("Game Over");
        Console.SetCursorPosition(width / 2 - 6, height / 2 + 1);
        Console.WriteLine("Score: " + score);
        Console.ReadLine();
    }

    static void DrawField()
    {
        Console.Clear();

        // Отрисовка верхней границы
        for (int i = 0; i < width + 2; i++)
        {
            Console.SetCursorPosition(i, 0);
            Console.Write("■");
        }

        // Отрисовка боковых границ
        for (int i = 0; i < height; i++)
        {
            Console.SetCursorPosition(0, i + 1);
            Console.Write("■")