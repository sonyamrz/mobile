namespace wfaEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //(2) предпочтительнее
            button2.Click += Button2_Click;
            //(3) для маленького кол-ва строк
            button3.Click += delegate
            {
                MessageBox.Show("Способ 3");
            };
            //(4)  тоже хороший способ
            button4.Click += (sender, e) => MessageBox.Show("Способ 4");
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Способ 2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Способ 1");
        }   
        private void button0_Click(object? sender, EventArgs e) => MessageBox.Show("Способ 0");
    }
 
}