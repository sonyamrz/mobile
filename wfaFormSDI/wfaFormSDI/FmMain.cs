namespace wfaFormSDI
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();

            button1.Click += (s, e) => new FmAbout().Show();
            button2.Click += (s, e) => new FmAbout().ShowDialog();

            button3.Click+=(s,e) => 
        }
    }
}