using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wfaGraphicSinCos
{
    public partial class Fm : Form
    {
        private const int DOT_WIDHT = 2;
        private const int DOT_HEIGTH = 2;
        private Point startPoint;
        public Bitmap b;

        public Fm()
        {
            InitializeComponent();

            this.BackgroundImageLayout = ImageLayout.None;
            DrawAll();
            this.Resize += (s, e) => DrawAll();
            this.Text += ": (Sin - красный, Cos - зеленый, Tan - синий)";
            
            
           
            pictureBox1.BackColor = Color.Transparent;
            ll.BringToFront();

            this.MouseMove += Fm_MouseMove;
            //pictureBox1.Paint += PictureBox1_Paint;
            //pictureBox1.MouseMove += Fm_MouseMove;
           
            
        }

        
        private void Fm_MouseMove(object? sender, MouseEventArgs e)
        {
            //var b = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            
            
            ll.Text = $"Sin = {Math.Sin (5 * Math.PI * e.X/ ClientSize.Width)}, Cos = {Math.Cos (5 * Math.PI * e.X/ ClientSize.Width)} , Tan = { Math.Tan(5 * Math.PI * e.X / ClientSize.Width)}";
            


            if (sender is Control c)
            {
                ll.Location = new Point(
                    e.X +5,//e.X - startPoint.X+5
                    e.Y +5
                    );
                
            }
            GC.Collect();
            
        }

        private void DrawAll()
        {
            
            var b = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Graphics g = Graphics.FromImage(b);
            
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            
            var grCountWave = 5; //кол-во волн
            var grShiftY = b.Height / 2; // смещение по Y
            var grHeight = grShiftY * 0.9; // Половина высоты графика
            var grWidthPI = Math.PI / (b.Width - 1); //Ширина отрезка ПИ в радианах

            //рисуем ось X
            g.DrawLine(new Pen(Color.Black), 0, grShiftY, b.Width, grShiftY);

            for (int i = 1; i < grCountWave; i++)
            {
                var xPoint = b.Width / grCountWave * i;
                g.DrawLine(Pens.Black, xPoint, grShiftY - 5, xPoint, grShiftY + 5);
                g.DrawString($"{i}π", new Font("", 10), new SolidBrush(Color.Black), xPoint - 10, grShiftY + 5);
            }
            
            //рисуем ось Y
            g.DrawLine(new Pen(Color.Black), 0, 0, 0, b.Height);
            GC.Collect();
            //рисование графиков
            float x;
            float y;
            for (int i = 0; i < b.Width; i++)
            {
                //рисуем график sin
                x = i;
                y = (float) (grHeight * (-Math.Sin(i * grCountWave * grWidthPI)) + grShiftY);
                g.FillEllipse(new SolidBrush(Color.Red), x - DOT_WIDHT / 2, y - DOT_HEIGTH / 2, DOT_WIDHT, DOT_HEIGTH);

                //рисуем график cos
                x = i;
                y = (float)(grHeight * (-Math.Cos(i * grCountWave * grWidthPI)) + grShiftY);
                g.FillEllipse(new SolidBrush(Color.Green), x - DOT_WIDHT / 2, y - DOT_HEIGTH / 2, DOT_WIDHT, DOT_HEIGTH);

                //рисуем график tan
                x = i;
                y = (float)(grHeight * (-Math.Tan(i * grCountWave * grWidthPI)) + grShiftY);
                if (y > 0 && y < b.Height)
                    g.FillEllipse(new SolidBrush(Color.Blue), x - DOT_WIDHT / 2, y - DOT_HEIGTH / 2, DOT_WIDHT, DOT_HEIGTH);
            }
            GC.Collect();



            this.BackgroundImage = (Bitmap)b.Clone();
            this.Invalidate();
            GC.Collect();
        }
    }
}