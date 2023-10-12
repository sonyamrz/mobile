namespace wfaGameTrainerAccount
{
    public partial class Form1 : Form
    {
        private readonly Game g;
        public Form1()
        {
            InitializeComponent();
            g = new Game();
            g.DoReset();
            g.Change += G_Change;

            buYes.Click += (s, e) => g.DoAnswer(true);
            buNo.Click += (s, e) => g.DoAnswer(false);
        }

        private void G_Change(object? sender, EventArgs e)
        {
            laCorrect.Text = $"Верно = {g.CountCorrect}";
            laWrong.Text = $"Неверно = {g.CountWrong}";
            laCode.Text = g.CodeText;
        }

    }

}