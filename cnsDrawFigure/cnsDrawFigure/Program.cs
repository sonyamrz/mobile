using System.Diagnostics.SymbolStore;


bool isContinue;

        do
        {
  
                int size; // Размер ромба
                Console.Write("Введите размер фигуры:-");
                size = Convert.ToInt32(Console.ReadLine());

                char diamondSymbol; // Символ для отрисовки ромба
              //  Console.Write("Введите символ для отрисовки ромба:-");
              //  diamondSymbol = Convert.ToChar(Console.ReadLine());

                char borderSymbol; // Символ для заполнения пространства вокруг ромба
                                   // Console.Write("Введите символ для заполнения пространства вокруг ромба:-");
                                   // borderSymbol = Convert.ToChar(Console.ReadLine());

                char symbol;

            

            static void DrawDiamondWithBorder(int size, char diamondSymbol, char borderSymbol)
            {

                int rowCount = size * 2 - 1;
                int middleRow = rowCount / 2 + 1;

                for (int i = 1; i <= rowCount; i++)
                {
                    int spaces = Math.Abs(middleRow - i);
                    int diamonds = rowCount - spaces * 2;

                    for (int j = 0; j < spaces; j++)
                    {
                        Console.Write(borderSymbol);
                    }

                    for (int j = 0; j < diamonds; j++)
                    {
                        if (j == 0 || j == diamonds - 1 || i == 1 || i == rowCount)
                        {
                            Console.Write(diamondSymbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    for (int j = 0; j < spaces; j++)
                    {
                        Console.Write(borderSymbol);
                    }

                    Console.WriteLine();
                }
            }


    static void DrawDiamond(int size, char symbol)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size - i - 1; j++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j < 2 * i + 1; j++)
        {
            Console.Write(symbol);
        }

        Console.WriteLine();
    }

    for (int i = size - 2; i >= 0; i--)
    {
        for (int j = 0; j < size - i - 1; j++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j < 2 * i + 1; j++)
        {
            Console.Write(symbol);
        }

        Console.WriteLine();
    }
}

    static void DrawSandglass(int size, char symbol)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * (size - i) - 1; k++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        for (int i = size - 2; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * (size - i) - 1; k++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }

    static void DrawCross(int size, char symbol)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == j || i + j == size - 1) // Условие для рисования крестика
                {
                    Console.Write(symbol);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    string answer;
    Console.Write("Выберите фигуру:ромб, песочные часы или крест ? [1/2/3] - >");
    answer = Console.ReadLine().ToUpper();
    switch (answer)
    {
        case "1":
            string answer_romb;
            Console.Write("Пустой ромб или заполненный ? [1/2] - >");
            answer_romb = Console.ReadLine().ToUpper();
            switch (answer_romb)
            {
                case "1":
                    Console.Write("Введите символ для отрисовки ромба:-");
                    diamondSymbol = Convert.ToChar(Console.ReadLine());

                    Console.Write("Введите символ для заполнения пространства вокруг ромба:-");
                    borderSymbol = Convert.ToChar(Console.ReadLine());
                    DrawDiamondWithBorder(size, diamondSymbol, borderSymbol);
                    break;
                case "2":
                    Console.Write("Введите символ для отрисовки ромба:-");
                    symbol = Convert.ToChar(Console.ReadLine());
                    DrawDiamond(size, symbol);
                    break;
            }
            break;

        case "2":
            Console.Write("Введите символ для отрисовки песочных часов:-");
            symbol = Convert.ToChar(Console.ReadLine());
            DrawSandglass(size, symbol);
            break;
  
            case "3":
            Console.Write("Введите символ для отрисовки крестика:-");
            symbol = Convert.ToChar(Console.ReadLine());
            DrawCross(size, symbol);
            break;


    }
 

    Console.WriteLine(" Повторить? [Y/N] -> ");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";
} while (isContinue);
