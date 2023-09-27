Console.WriteLine("number?");

int value1 = int.Parse(Console.ReadLine());
Console.WriteLine(value1);

int value2;
int.TryParse(Console.ReadLine(), out value2);
Console.WriteLine(value2); //для проверки ошибок

int value3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(value3); // наиболее предпочтительный

