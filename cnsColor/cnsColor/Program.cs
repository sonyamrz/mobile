Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine( "зеленый текст на красном фоне");
Console.ResetColor();
Console.WriteLine("ляляля");

foreach (var color in Enum.GetValues<ConsoleColor>())
{ 
    Console.WriteLine(color);
}
