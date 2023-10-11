using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество кубиков: ");
        int numberOfCubes = int.Parse(Console.ReadLine());

        Console.Write("Введите количество граней у кубика (по умолчанию = 6): ");
        int numberOfSides = int.Parse(Console.ReadLine());

        Console.Write("Введите значения на гранях кубика (через запятую, по умолчанию = 1,2,3,4,5,6): ");
        string sidesValuesInput = Console.ReadLine();
        string[] sidesValues = sidesValuesInput.Split(',');

        // Создаем кортеж с результатами подбрасывания кубиков
        (int[], int) result = RollCubes(numberOfCubes, numberOfSides, sidesValues);

        Console.WriteLine("Результат подбрасывания:");
        for (int i = 0; i < numberOfCubes; i++)
        {
            Console.WriteLine($"Кубик {i + 1}: {result.Item1[i]}");
        }
        Console.WriteLine($"Сумма значений кубиков: {result.Item2}");
    }

    static (int[], int) RollCubes(int numberOfCubes, int numberOfSides = 6, string[] sidesValues = null)
    {
        // Проверка входящих параметров
        if (numberOfCubes < 1 || numberOfCubes > 10)
        {
            throw new ArgumentOutOfRangeException("Количество кубиков должно быть от 1 до 10.");
        }
        if (numberOfSides < 2)
        {
            throw new ArgumentOutOfRangeException("Количество граней у кубика должно быть не менее 2.");
        }
        if (sidesValues == null)
        {
            sidesValues = new string[numberOfSides];
            for (int i = 0; i < numberOfSides; i++)
            {
                sidesValues[i] = (i + 1).ToString();
            }
        }
        else if (sidesValues.Length != numberOfSides)
        {
            throw new ArgumentOutOfRangeException("Количество значений на гранях кубика должно соответствовать числу граней.");
        }

        Random random = new Random();
        int[] rolls = new int[numberOfCubes];
        int sum = 0;

        for (int i = 0; i < numberOfCubes; i++)
        {
            int roll = random.Next(0, numberOfSides);
            rolls[i] = int.Parse(sidesValues[roll]);
            sum += rolls[i];
        }

        return (rolls, sum);
    }
}
