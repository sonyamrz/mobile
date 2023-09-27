bool isContinue;

do
{
    Console.WriteLine("Длина?");
    //(1)
    //int width;
    //int.TryParse(Console.ReadLine(), out width);

    //(2) начиная с С# 7.0
    int.TryParse(Console.ReadLine(), out int width);

    //(1)
    //for (int i = 0; i < width; i++)
    //{
    //    Console.Write("*");
    //}
    //Console.WriteLine();

    //(2)
    Console.WriteLine(new String('*', width));

    Console.WriteLine(" Повторить? [Y/N] -> ");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";

} while (isContinue);