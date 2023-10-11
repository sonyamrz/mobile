// словарь dictionary
// ключ (уникальный) - значение
Dictionary<int, string> x = new();
x.Add(10, "Калуга");
x.Add(75, "Самара");
x.Add(40, "Тула");
x.Add(15, "Псков");

Console.WriteLine(x[75]);
x[40] = "Курск";
x[99] = "Воронеж";

foreach (var item  in x)
{
    Console.WriteLine($"key= {item.Key}, value = {item.Value}");
}