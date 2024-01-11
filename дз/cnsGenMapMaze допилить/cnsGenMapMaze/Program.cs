using System;

public class MazeGenerator
{
    private const char CorridorSymbol = ' ';
    private const char WallSymbol = '▓';
    private const char StartSymbol = '~';
    private const char ExitSymbol = '$';

    private readonly int height;
    private readonly int width;
    private readonly Random random;

    public MazeGenerator(int height, int width)
    {
        // Проверка входных параметров
        if (height <= 0)
        {
            throw new ArgumentException("Высота лабиринта должна быть положительным числом.");
        }

        if (width <= 0)
        {
            throw new ArgumentException("Ширина лабиринта должна быть положительным числом.");
        }

        this.height = height;
        this.width = width;
        this.random = new Random();
    }

    public char[,] GenerateMaze((int x, int y)? start = null, (int x, int y)? exit = null)
    {
        // Если начальная точка не задана, выбираем случайную на левой стенке
        start ??= (0, random.Next(height));

        // Если конечная точка не задана, выбираем случайную на правой стенке
        exit ??= (width - 1, random.Next(height));

        // Создаем карту лабиринта
        char[,] maze = new char[height, width];

        // Заполняем карту стенами
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                maze[row, col] = WallSymbol;
            }
        }

        // Делаем проходы для коридоров
        Random rand = new Random();

        for (int row = 1; row < height - 1; row += 2)
        {
            for (int col = 1; col < width - 1; col += 2)
            {
                maze[row, col] = ' ';

                

                if (row == 1)
                {
                    maze[row - 1, col] = ' ';
                }

                if (row == height - 2)
                {
                    maze[row + 1, col] = ' ';
                }

                if (col == 1)
                {
                    maze[row, col - 1] = ' ';
                }

                if (col == width - 2)
                {
                    maze[row, col + 1] = ' ';
                }

                if (rand.Next(2) == 0)
                {
                    maze[row, col + 1] = ' ';
                }
                else
                {
                    maze[row + 1, col] = ' ';
                }
            }
        }
   

        // Устанавливаем начальную и конечную точки
        maze[start.Value.x, start.Value.y] = StartSymbol;
        maze[exit.Value.x, exit.Value.y] = ExitSymbol;

        return maze;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите высоту игрового поля:");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите ширину игрового поля:");
        int width = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты начальной точки (x, y) или оставьте пустым:");
        string[] startCoordinates = Console.ReadLine().Split(' ');
        (int x, int y)? start = null;
        if (startCoordinates.Length == 2)
        {
            start = (int.Parse(startCoordinates[0]), int.Parse(startCoordinates[1]));
        }

        Console.WriteLine("Введите координаты конечной точки (x, y) или оставьте пустым:");
        string[] exitCoordinates = Console.ReadLine().Split(' ');
        (int x, int y)? exit = null;
        if (exitCoordinates.Length == 2)
        {
            exit = (int.Parse(exitCoordinates[0]), int.Parse(exitCoordinates[1]));
        }

        try
        {
            MazeGenerator mazeGenerator = new MazeGenerator(height, width);
            char[,] maze = mazeGenerator.GenerateMaze(start, exit);

            // Выводим карту лабиринта в консоль
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(maze[row, col]);
                }
                Console.WriteLine();
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}