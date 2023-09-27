// массив (array)

string[] cities = { "Тула", "Уфа", "Ялта", "Сочи" };
Console.WriteLine(cities[0]);
Console.WriteLine(cities[^1]);
Console.WriteLine("-----");

//1
for  (int i = 0; i < cities.Length; i++)
{
    Console.WriteLine(cities[i]); 
}
Console.WriteLine();
Console.WriteLine("-----");

//2
foreach (var city in cities) {  Console.WriteLine(city); }

//Изменить размер массива
Array.Resize(ref cities, 3);
Console.WriteLine(String.Join(' ', cities));

//пустой массив
string[] m1 = { };
string[] m2 = Array.Empty<string>();

//Hw : почитать про индексы и диапазоны в C#8
