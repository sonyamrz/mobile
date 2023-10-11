using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите высоту игрового поля: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Введите ширину игрового поля: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Введите количество мин на поле: ");
        int numberOfMines = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты мин через запятую (например, 1,1;2,3;1,4) или оставьте пустым для случайного размещения: ");
        string minesInput = Console.ReadLine();
        (int, int)[] mineCoordinates = ParseCoordinates(minesInput);

        Console.Write("Введите координаты первого хода (например, 0,0): ");
        string firstMoveInput = Console.ReadLine();
        (int, int) firstMove = ParseCoordinates(firstMoveInput)[0];

        // Создаем карту для игры Сапер
        char[,] map = GenerateMap(height, width, numberOfMines, mineCoordinates, firstMove);

        Console.WriteLine("Результат генерации карты:");
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(map[i, j]);
            }
            Console.WriteLine();
        }
    }

    static char[,] GenerateMap(int height, int width, int numberOfMines = 10, (int, int)[] mineCoordinates = null, (int, int) firstMove = default)
    {
        // Проверка входящих параметров
        if (height <= 0 || width <= 0)
        {
            throw new ArgumentOutOfRangeException("Высота и ширина игрового поля должны быть больше нуля.");
        }
        if (numberOfMines < 0 || numberOfMines >= height * width)
        {
            throw new ArgumentOutOfRangeException("Количество мин на поле должно быть неотрицательным и меньше общего количества клеток на поле.");
        }
        if (mineCoordinates != null)
        {
            foreach ((int, int) coord in mineCoordinates)
            {
                if (coord.Item1 < 0 || coord.Item1 >= height || coord.Item2 < 0 || coord.Item2 >= width)
                {
                    throw new ArgumentOutOfRangeException("Координаты мин выходят за пределы игрового поля.");
                }
            }
        }
        if (firstMove.Item1 < 0 || firstMove.Item1 >= height || firstMove.Item2 < 0 || firstMove.Item2 >= width)
        {
            throw new ArgumentOutOfRangeException("Координаты первого хода выходят за пределы игрового поля.");
        }

        Random random = new Random();
        char[,] map = new char[height, width];

        // Заполняем карту пустыми клетками и расставляем мины
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                map[i, j] = '0';
            }
        }

        if (mineCoordinates == null)
        {
            for (int i = 0; i < numberOfMines; i++)
            {
                int row = random.Next(0, height);
                int column = random.Next(0, width);

                // Проверяем, что в случайной клетке еще нет мины и что это не первый ход
                while (map[row, column] == '*' || (row == firstMove.Item1 && column == firstMove.Item2))
                {
                    row = random.Next(0, height);
                    column = random.Next(0, width);
                }

                map[row, column] = '*';
            }
        }
        else
        {
            foreach ((int, int) coord in mineCoordinates)
            {
                map[coord.Item1, coord.Item2] = '*';
            }
        }

        // Вычисляем числа на пустых клетках, которые соприкасаются с минами
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (map[i, j] == '*')
                {
                    continue;
                }

                int count = 0;

                for (int row = i - 1; row <= i + 1; row++)
                {
                    for (int column = j - 1; column <= j + 1; column++)
                    {
                        if (row < 0 || row >= height || column < 0 || column >= width)
                        {
                            continue;
                        }

                        if (map[row, column] == '*')
                        {
                            count++;
                        }
                    }
                }

                map[i, j] = count.ToString()[0];
            }
        }

        // Открываем первую ход и обозначаем его пустой клеткой
        map[firstMove.Item1, firstMove.Item2] = ' ';

        return map;
    }

    static (int, int)[] ParseCoordinates(string coordinatesInput)
    {
        if (string.IsNullOrWhiteSpace(coordinatesInput))
        {
            return null;
        }

        string[] coordinatesStrings = coordinatesInput.Split(';');
        (int, int)[] coordinates = new (int, int)[coordinatesStrings.Length];

        for (int i = 0; i < coordinatesStrings.Length; i++)
        {
            string[] parts = coordinatesStrings[i].Split(',');

            int row = int.Parse(parts[0]);
            int column = int.Parse(parts[1]);

            coordinates[i] = (row, column);
        }

        return coordinates;
    }
}