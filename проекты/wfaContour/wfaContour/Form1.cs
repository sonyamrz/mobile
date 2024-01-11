using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics.Eventing.Reader;

namespace wfaContour
{
    public partial class Form1 : Form
    {
        private static Image<Bgr, byte> inputImage = null;
        private Point imageOffset = new Point(0, 0);
        private List<Rectangle> selectedContours = new List<Rectangle>();
        private int zoomFactor = 1;
        private Image<Gray, byte> zoomedImage;
        private Point startPoint;
       
        public Form1()
        {
            InitializeComponent();
            pictureBox2.MouseClick += PictureBox2_MouseClick;
            pictureBox2.MouseWheel += PictureBox2_MouseWheel;
            pictureBox2.Paint += PictureBox2_Paint;
            pictureBox2.AllowDrop = true;
            pictureBox2.MouseDown += PictureBox2_MouseDown;
            pictureBox2.MouseMove += PictureBox2_MouseMove;

        }

        private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - startPoint.X;
                int dy = e.Y - startPoint.Y;
                imageOffset.X += dx;
                imageOffset.Y += dy;
                startPoint = e.Location;
                pictureBox2.Invalidate();
            }
        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
             startPoint = e.Location;
        }

        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {
            
    // Отрисовка масштабированного изображения с учетом смещения
    if (zoomedImage != null)
       
        e.Graphics.DrawImage(inputImage.ToBitmap(), imageOffset.X, imageOffset.Y, inputImage.Width * zoomFactor, inputImage.Height * zoomFactor);
         Pen pen = new Pen(Color.Red, 5); // Создание объекта Pen с красным цветом и толщиной 2
            // Отрисовка рамок выбранных контуров
            foreach (var contour in selectedContours)
    {
        Rectangle contourRect = new Rectangle(
            contour.X * zoomFactor + imageOffset.X,
            contour.Y * zoomFactor + imageOffset.Y,
            contour.Width * zoomFactor,
            contour.Height * zoomFactor);
        e.Graphics.DrawRectangle(pen, contourRect);
    }
        }

        private void PictureBox2_MouseWheel(object sender, MouseEventArgs e)
        {

            // Определяем изменение зума в зависимости от направления прокрутки колесика мыши
            if (e.Delta > 0)
                zoomFactor++ ; // Увеличение зума в 2 раза
            else
            { if (zoomFactor > 1)
                    zoomFactor--;
            }        
              

            // Масштабируем изображение с учетом зума
            zoomedImage = inputImage.Convert<Gray, byte>().Resize(zoomFactor, Emgu.CV.CvEnum.Inter.Area);

            // Пересчитываем смещение изображения, чтобы оно оставалось в центре относительно pictureBox2
            imageOffset.X = (pictureBox2.Width - zoomedImage.Width) / 2;
            imageOffset.Y = (pictureBox2.Height - zoomedImage.Height) / 2;

            // Обновляем pictureBox2, отображая масштабированное изображение с учетом смещения
            pictureBox2.Invalidate();
        }

        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
           
            Image<Gray, byte> outputImage = inputImage.Convert<Gray, byte>().ThresholdBinary(new Gray(127), new Gray(255));

            VectorOfVectorOfPoint conturs = new VectorOfVectorOfPoint();
            Mat hierarchy = new Mat();


            CvInvoke.FindContours(outputImage, conturs, hierarchy, Emgu.CV.CvEnum.RetrType.List, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            List<Rectangle> boundingRectangles = new List<Rectangle>();
            for (int i = 0; i < conturs.Size; i++)
            {
                Rectangle rect = CvInvoke.BoundingRectangle(conturs[i]);
                boundingRectangles.Add(rect);

            }

            var largestContours = boundingRectangles.OrderByDescending(r => r.Width * r.Height).Take(5);

            int x = (e.X - imageOffset.X) / zoomFactor;
            int y = (e.Y - imageOffset.Y) / zoomFactor;
            Point mouseLocation = new Point(x, y);

            // Проверяем, попадает ли щелчок мыши внутрь контура
            foreach (var contour in largestContours)
            {
                Rectangle contourRect = new Rectangle(
                    contour.X * zoomFactor + imageOffset.X,
                    contour.Y * zoomFactor + imageOffset.Y,
                    contour.Width * zoomFactor,
                    contour.Height * zoomFactor);

                if (contourRect.Contains(e.Location))
                {
                    // Если контур уже был выбран, то убираем его из списка выбранных, иначе добавляем его
                    if (selectedContours.Contains(contour))
                        selectedContours.Remove(contour);
                    else
                        selectedContours.Add(contour);

                    pictureBox2.Invalidate();
                    break;
                }
                 

                
            } 
        }
    

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialog1.ShowDialog();

                if(res == DialogResult.OK)
                {
                    inputImage = new Image<Bgr, byte>(openFileDialog1.FileName);

                    pictureBox1.Image = inputImage.Bitmap;
                }
                else
                {
                    MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void найтиКонтурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Image<Gray, byte> outputImage = inputImage.Convert<Gray, byte>().ThresholdBinary(new Gray(127), new Gray(255));

       

                VectorOfVectorOfPoint conturs = new VectorOfVectorOfPoint();
                Mat hierarchy = new Mat();
        

                CvInvoke.FindContours(outputImage, conturs, hierarchy, Emgu.CV.CvEnum.RetrType.List, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                List<Rectangle> boundingRectangles = new List<Rectangle>();
                for (int i = 0; i < conturs.Size; i++)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(conturs[i]);
                    boundingRectangles.Add(rect);

                }

                var largestContours = boundingRectangles.OrderByDescending(r => r.Width * r.Height).Take(5);
                int contourNumber = 1;
                foreach (var contour in largestContours)
                {
                    CvInvoke.Rectangle(inputImage, contour, new MCvScalar(255, 0, 0), 3);
                    CvInvoke.PutText(inputImage, contourNumber.ToString(), new Point(contour.Left, contour.Bottom), Emgu.CV.CvEnum.FontFace.HersheySimplex, 2,new MCvScalar(0, 0, 255), 3);
                    contourNumber++;
                }

             
                pictureBox2.Image = inputImage.Bitmap;
                
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void сохранитьВыделенныеОбластиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Image<Gray, byte> outputImage = inputImage.Convert<Gray, byte>().ThresholdBinary(new Gray(127), new Gray(255));

                VectorOfVectorOfPoint conturs = new VectorOfVectorOfPoint();
                Mat hierarchy = new Mat();

                CvInvoke.FindContours(outputImage, conturs, hierarchy, Emgu.CV.CvEnum.RetrType.List, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                List<Rectangle> boundingRectangles = new List<Rectangle>();

                for (int i = 0; i < conturs.Size; i++)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(conturs[i]);
                    boundingRectangles.Add(rect);
                }

                var largestContours = boundingRectangles.OrderByDescending(r => r.Width * r.Height).Take(5);
                foreach (var contour in largestContours)
                {
                    CvInvoke.Rectangle(outputImage, contour, new MCvScalar(255, 0, 0), 3);
                
                }
                pictureBox2.Image = inputImage.Bitmap;
                if (selectedContours.Count > 0)
                {
                    FolderBrowserDialog folderDialog = new FolderBrowserDialog();

                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        int contourNumber = 1;
                        foreach (var contour in selectedContours)
                        {
                            Image<Bgr, byte> croppedImage = inputImage.Copy(contour);

                            string filePath = Path.Combine(folderDialog.SelectedPath, $"contour_{contourNumber}.jpg");

                            croppedImage.Save(filePath);

                            contourNumber++;
                        }

                        MessageBox.Show("Выбранные контуры сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Нет выбранных контуров для сохранения", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void сохранитьВсеКонтурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Image<Gray, byte> outputImage = inputImage.Convert<Gray, byte>().ThresholdBinary(new Gray(127), new Gray(255));



                VectorOfVectorOfPoint conturs = new VectorOfVectorOfPoint();
                Mat hierarchy = new Mat();


                CvInvoke.FindContours(outputImage, conturs, hierarchy, Emgu.CV.CvEnum.RetrType.List, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                List<Rectangle> boundingRectangles = new List<Rectangle>();

                for (int i = 0; i < conturs.Size; i++)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(conturs[i]);
                    boundingRectangles.Add(rect);
                }

                var largestContours = boundingRectangles.OrderByDescending(r => r.Width * r.Height).Take(5);
                foreach (var contour in largestContours)
                {
                    CvInvoke.Rectangle(inputImage, contour, new MCvScalar(255, 0, 0), 3);

                }
                FolderBrowserDialog folderDialog = new FolderBrowserDialog();

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    int contourNumber = 1;

                    foreach (var contour in largestContours)
                    {
                        // Создаем изображение, соответствующее размерам контура
                        Image<Bgr, byte> croppedImage = inputImage.Copy(contour);

                        string filePath = Path.Combine(folderDialog.SelectedPath, $"contour_{contourNumber}.jpg");

                        // Сохраняем изображение
                        croppedImage.Save(filePath);

                        contourNumber++;
                    }

                    MessageBox.Show("Контуры сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
    

