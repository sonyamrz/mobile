using System.Windows.Forms;

namespace wfaControlInTableLoyalPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // pictureBox1.MouseEnter += PictureBoxAll_MouseEnter;
           // pictureBox2.MouseEnter += PictureBoxAll_MouseEnter;
           // pictureBox3.MouseEnter += PictureBoxAll_MouseEnter;
            //pictureBox4.MouseEnter += PictureBoxAll_MouseEnter;
            //pictureBox5.MouseEnter += PictureBoxAll_MouseEnter;
           // pictureBox6.MouseEnter += PictureBoxAll_MouseEnter;
           // pictureBox7.MouseEnter += PictureBoxAll_MouseEnter;
            //PictureBox8.MouseEnter += PictureBoxAll_MouseEnter;
            //PictureBox9.MouseEnter += PictureBoxAll_MouseEnter;

        }
        List<PictureBox> list = new()
            {
            pictureBox1,
            pictureBox2,
            pictureBox3,
            pictureBox4,
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

private void PictureBoxAll_MouseClick(object? sender, EventArgs e)
{
    //
}


private void PictureBoxAll_MouseLeave(object? sender, EventArgs e)
{

    if (sender is PictureBox pictureBox)
    {
        pictureBox.Image = imageList1.Images[Convert.ToInt32(pictureBox.Tag)];
    }
}

private void PictureBoxAll_MouseEnter(object? sender, EventArgs e)
{

    if (sender is PictureBox pictureBox)
    {
        pictureBox.Image = imageList1.Images[Convert.ToInt32(pictureBox.Tag)];
    }
}
   
        private void PictureBoxAll_MouseEnter(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    
