using System;

class cnsGenMapBomberman
{
    private const char FREE_CELL = ' '; // свободная клетка
    private const char UNBREAKABLE_WALL = '▓'; // неразрушаемая стена
    private const char BREAKABLE_WALL = '░'; // разрушаемая стена

    private char[,] map; // матрица игрового поля
    private int height; // высота игрового поля
    private int width; // ширина игрового поля

    public cnsGenMapBomberman(int height, int width)
    {
        this.height = height;
        this.width = width;
        map = new char[height, width];
    }


    public void GenerateWalls()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                {
                    map[i, j] = UNBREAKABLE_WALL; 
                }
                else
                {
                    map[i, j] = FREE_CELL; // оставляем пустое пространство
                }
            }
        }
    }

    public void GenerateBreakableWalls()
    {
        Random random = new Random();

        // Заполняем разрушаемыми стенами все клетки, кроме угловых
        for (int i = 1; i < height - 1; i++)
        {
            for (int j = 1; j < width - 1; j++)
            {
                if (random.Next(10) < 5) // 50% вероятность размещения разрушаемой стены
                {
                    map[i, j] = BREAKABLE_WALL;
                }
            }
        }
    }
    public void GenerateUnbreakableWalls()
    {
        Random random = new Random();

        // Заполняем разрушаемыми стенами все клетки, кроме угловых
        for (int i = 1; i < height - 1; i++)
        {
            for (int j = 1; j < width - 1; j++)
            {
                if (random.Next(10) < 2) // 20% вероятность размещения разрушаемой стены
                {
                    map[i, j] = UNBREAKABLE_WALL;
                }
            }
        }
    }
    public void PrintMap()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(map[i, j]);
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ввод высоты и ширины игрового поля
        Console.Write("Введите высоту игрового поля: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Введите ширину игрового поля: ");
        int width = int.Parse(Console.ReadLine());

        cnsGenMapBomberman generator = new cnsGenMapBomberman(height, width);

        generator.GenerateWalls();
        generator.GenerateBreakableWalls();
        generator.GenerateUnbreakableWalls();   
        generator.PrintMap();
    }
}