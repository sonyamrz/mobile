namespace wfaGameTrainerAccount
{
    public partial class Fm : Form
    {
        private readonly Game g;

        public Fm()
        {
            InitializeComponent();
            
            g = new Game();
            g.Change += G_Change;
            g.DoReset();

            buYes.Click += (s, e) => g.DoAnswer(true);
            buNo.Click += (s, e) => g.DoAnswer(false);
            buReset.Click += (s, e) => g.DoReset();
            buSkip.Click += (s, e) => g.SkipAnswer();
            
           
            //добавить таймер - сколько длится игра
            
        }

        private void G_Change(object? sender, EventArgs e)
        {
            laCorrect.Text = $"Верно = {g.CountCorrect}";
            laWrong.Text = $"Неверно = {g.CountWrong}";
            laCode.Text = g.CodeText;
            skipCount.Text = $"Кол-во пропусков = {g.skipCounter-1}";
            lvl.Text = $"Уровень: {g.level}";
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}