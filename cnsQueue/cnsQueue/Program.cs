// очередь Queue

// обычная очередь
using System.Collections;

Queue queue = new();
queue.Enqueue(100500);
queue.Enqueue("hello");
queue.Enqueue(3.14);
Console.WriteLine($"Смотрим -  {queue.Peek()}");

while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}

// обобщенная очередь
Queue<int> numbers = new();
numbers.Enqueue(1);
numbers.Enqueue(2);
numbers.Enqueue(3);
numbers.Enqueue(4);
Console.WriteLine($"Смотрим -  {numbers.Sum()}");

while (numbers.Count > 0)
{
    Console.WriteLine(numbers.Dequeue());
}
