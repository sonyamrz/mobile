static void DrawCross(int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (i == j || i + j == size - 1) // Условие для рисования крестика
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

// Пример использования:
int size = 5; // Размер крестика
DrawCross(size);
