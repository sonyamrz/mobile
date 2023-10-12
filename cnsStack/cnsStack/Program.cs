// Стек (Stack)

// (А) Обычный стек

using System.Collections;

Stack x = new();
x.Push("Рязань");
x.Push(100500);

Console.WriteLine($"Смотрим -> {x.Peek()}");
Console.WriteLine(x.Pop());
Console.WriteLine(x.Pop());
// (Б)Обобщенный стек
Stack<string> cities = new();
// HW