using System.Windows.Forms;

namespace wfaControlTLP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //1
            //pictureBox1.MouseEnter += PictureBoxAll_MouseEnter;
            //pictureBox2.MouseEnter += PictureBoxAll_MouseEnter;
            //pictureBox3.MouseEnter += PictureBoxAll_MouseEnter;
            //pictureBox4.MouseEnter += PictureBoxAll_MouseEnter;

            //pictureBox1.MouseEnter += PictureBoxAll_MouseLeave;
            //pictureBox2.MouseEnter += PictureBoxAll_MouseLeave;
            //pictureBox3.MouseEnter += PictureBoxAll_MouseLeave;
            //pictureBox4.MouseEnter += PictureBoxAll_MouseLeave;

            //pictureBox1.Tag = 1;
            //pictureBox2.Tag = 2;
            //pictureBox3.Tag = 3;
            //pictureBox4.Tag = 4;

            List<PictureBox> list = new()
            {
            pictureBox1,
            pictureBox2,
            pictureBox3,
            pictureBox4
            };

            int n = 1;

            foreach (var item in list)
            {
                item.MouseEnter += PictureBoxAll_MouseEnter;
                item.MouseLeave += PictureBoxAll_MouseLeave;
                item.MouseClick += PictureBoxAll_MouseClick;
                item.Tag = n++;
                item.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void PictureBoxAll_MouseClick(object? sender, MouseEventArgs e)
        {
            if(sender is PictureBox px)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        px.BorderStyle = px.BorderStyle == BorderStyle.None ? BorderStyle.FixedSingle : BorderStyle.None;
                        break;
                    case MouseButtons.Right:
                        px.BackColor = px.BackColor == SystemColors.Control ? Color.LightBlue : SystemColors.Control;
                        break;
                }

            }
        }


        private void PictureBoxAll_MouseLeave(object? sender, EventArgs e)
        {

            if (sender is PictureBox pictureBox)
            {
                pictureBox.Image = imageList1.Images[0];

            }
        }

        private void PictureBoxAll_MouseEnter(object? sender, EventArgs e)
        {

            if (sender is PictureBox pictureBox)
            {
                pictureBox.Image = imageList1.Images[Convert.ToInt32(pictureBox.Tag)];
                

            }
        }
    }
}