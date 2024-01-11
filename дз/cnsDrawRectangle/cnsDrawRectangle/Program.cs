using System.Diagnostics.SymbolStore;

bool isContinue;

do
{
    int height, width;
    char symbol;
    string answer;
    Console.Write("Введите высоту прямоугольника:-");
    height = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите ширину прямоугольника:-");
    width = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите один символ:-");
    symbol = Convert.ToChar(Console.ReadLine());

    Console.Write("Заполнить? [Y/N] - >");
    answer = Console.ReadLine().ToUpper();
    switch (answer)
    {
        case "Y":
            for (int i = 0; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            break;
        case "N":
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if ((i == 1 || i == height || j == 1 || j == width))
                        Console.Write(symbol);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            break;
    }

    Console.WriteLine(" Повторить? [Y/N] -> ");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";


} while (isContinue);