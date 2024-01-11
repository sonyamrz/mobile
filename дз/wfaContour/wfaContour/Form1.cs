using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace wfaContour
{
    public partial class Form1 : Form
    {
        private int increaseByN = 10;
        private List<Rectangle> objectRectangles;
        public Form1()
        {
            InitializeComponent();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            btnDetectedContours.Text = "Найти контуры";
            btnDetectedContours.Click += BtnDetectedContours_Click;

            objectRectangles = new List<Rectangle>();
        }

        private void BtnDetectedContours_Click(object? sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox.Image);
            objectRectangles.Clear();

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    if (IsDark(pixelColor)) // Проверка является ли цвет пикселя темным
                    {
                        Rectangle objectRect = new Rectangle(x, y, increaseByN, increaseByN);
                        objectRectangles.Add(objectRect);
                    }
                }
            }
            UpdateImage();
        }
        private void UpdateImage()
        {
            Bitmap bmp = new Bitmap(pictureBox.Image);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                foreach (Rectangle rect in objectRectangles)
                {
                    g.DrawRectangle(new Pen(Color.Red, 2), rect);
                }
            }

            pictureBox.Image = bmp;
        }
        private bool IsDark(Color color)
        {
            // Проверка, является ли цвет темным (можно задать свои критерии для определения темного цвета)
            return (color.R + color.G + color.B) < 100;
        }

        private void LoadImage(string filePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(filePath))
                {
                    Bitmap original = new Bitmap(Image.FromFile(filePath));
                    Bitmap bwImage = GrayscaleFilter(original);
                    pictureBox.Image = bwImage;
                    original.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
        private Bitmap GrayscaleFilter(Bitmap bmp)
        {
            Bitmap newBitmap = new Bitmap(bmp.Width, bmp.Height);
            Graphics g = Graphics.FromImage(newBitmap);
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]{
                  new float[] {.3f, .3f, .3f, 0, 0},
                  new float[] {.59f, .59f, .59f, 0, 0},
                  new float[] {.11f, .11f, .11f, 0, 0},
                  new float[] {0, 0, 0, 1, 0},
                  new float[] {0, 0, 0, 0, 1}
               });
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height),
               0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attributes);

            g.Dispose();

            return newBitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                Title = "Select an Image File"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadImage(openFileDialog1.FileName);
            }
        }
    }

}