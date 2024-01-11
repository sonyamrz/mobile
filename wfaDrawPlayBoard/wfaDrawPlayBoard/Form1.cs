
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaDrawPlayBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // Базовый класс, реализующий рисование игровой доски
        public abstract class Board
        {
            protected int BoardSize { get; set; } // Размер изображения или размер ячейки

            public Board(int boardSize)
            {
                BoardSize = boardSize;
            }

            // Метод, реализующий рисование доски
            public abstract void DrawBoard(Graphics g);
        }

        // Производный класс, реализующий рисование шахматной доски
        public class ChessBoard : Board
        {
            private int NumCells { get; set; } // Количество ячеек

            public ChessBoard(int boardSize, int numCells) : base(boardSize)
            {
                NumCells = numCells;
            }

            public override void DrawBoard(Graphics g)
            {
                Brush[] cellColors = { Brushes.White, Brushes.Gray }; // Цвета ячеек

                int cellSize = BoardSize / NumCells; // Размер ячейки

                // Отрисовка ячеек шахматной доски
                for (int i = 0; i < NumCells; i++)
                {
                    for (int j = 0; j < NumCells; j++)
                    {
                        int colorIndex = (i + j) % 2; // Выбор цвета ячейки

                        Brush brush = cellColors[colorIndex];

                        g.FillRectangle(brush, i * cellSize, j * cellSize, cellSize, cellSize);
                    }
                }
            }
        }

        // Пример использования классов
        class Program
        {
            static void Main()
            {
                int boardSize = 400;
                int numCells = 8;

                Bitmap bitmap = new Bitmap(boardSize, boardSize);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    Board chessBoard = new ChessBoard(boardSize, numCells);
                    chessBoard.DrawBoard(g);
                }

                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox.Image = bitmap;

                Form form = new Form();
                form.Controls.Add(pictureBox);

                Application.Run(form);
            }
        }
    }
}
