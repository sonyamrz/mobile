using System;

class Program
{
    static void Main(string[] args)
    {
        int width = 10; // Ширина улитки
        int height = 10; // Высота улитки
        string direction = "clockwise"; // Направление рисования (по часовой или против часовой)

        DrawSpiral(width, height, direction);
    }

    static void DrawSpiral(int width, int height, string direction)
    {
        int[,] spiral = new int[height, width];
        int number = 1;
        int row = 0;
        int col = 0;
        int dx = 0;
        int dy = 0;

        switch (direction)
        {
            case "clockwise":
                dx = 1;
                break;
            case "counterclockwise":
                dy = 1;
                break;
        }

        for (int i = 0; i < width * height; i++)
        {
            spiral[row, col] = number;
            number++;

            row += dy;
            col += dx;

            if (row >= height || col >= width || row < 0 || col < 0 || spiral[row, col] != 0)
            {
                switch (direction)
                {
                    case "clockwise":
                        col -= dx;
                        row += dy;
                        dx = -dy;
                        dy = dx;
                        break;
                    case "counterclockwise":
                        row -= dy;
                        col += dx;
                        dx = dy;
                        dy = -dx;
                        break;
                }
            }
        }

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(spiral[i, j].ToString().PadLeft(3));
            }

            Console.WriteLine();
        }
    }
}