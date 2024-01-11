using System;

class Program
{
    static void Main(string[] args)
    {
        int width = 10; // Ширина узора
        int height = 10; // Высота узора
        string[] colors = { "Red", "Green", "Blue", "Yellow" }; // Список цветов
        string[] blockPatterns = { "██", "▓▓", "▒▒", "░░" }; // Шаблоны блоков

        DrawPattern(width, height, colors, blockPatterns);
    }

    static void DrawPattern(int width, int height, string[] colors, string[] blockPatterns)
    {
        int colorIndex = 0;
        int patternIndex = 0;

        for (int i = 0; i < height; i++)
        {
            Console.ForegroundColor = GetColor(colors[colorIndex++]);
            colorIndex %= colors.Length;

            for (int j = 0; j < width; j++)
            {
                Console.Write(blockPatterns[patternIndex++]);
                patternIndex %= blockPatterns.Length;
            }

            Console.WriteLine();
        }

        Console.ResetColor();
    }

    static ConsoleColor GetColor(string colorName)
    {
        ConsoleColor color = ConsoleColor.White;

        switch (colorName)
        {
            case "Black":
                color = ConsoleColor.Black;
                break;
            case "Blue":
                color = ConsoleColor.Blue;
                break;
            case "Cyan":
                color = ConsoleColor.Cyan;
                break;
            case "DarkBlue":
                color = ConsoleColor.DarkBlue;
                break;
            case "DarkCyan":
                color = ConsoleColor.DarkCyan;
                break;
            case "DarkGray":
                color = ConsoleColor.DarkGray;
                break;
            case "DarkGreen":
                color = ConsoleColor.DarkGreen;
                break;
            case "DarkMagenta":
                color = ConsoleColor.DarkMagenta;
                break;
            case "DarkRed":
                color = ConsoleColor.DarkRed;
                break;
            case "DarkYellow":
                color = ConsoleColor.DarkYellow;
                break;
            case "Gray":
                color = ConsoleColor.Gray;
                break;
            case "Green":
                color = ConsoleColor.Green;
                break;
            case "Magenta":
                color = ConsoleColor.Magenta;
                break;
            case "Red":
                color = ConsoleColor.Red;
                break;
            case "White":
                color = ConsoleColor.White;
                break;
            case "Yellow":
                color = ConsoleColor.Yellow;
                break;
        }

        return color;
    }
}