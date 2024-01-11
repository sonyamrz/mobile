using Timer = System.Windows.Forms.Timer;

namespace wfaTimer
{
    public partial class Fm : Form
    {
        private const int SEC_MAX = 10;
        private readonly Timer tmUp = new();
        private readonly Timer tmDown = new();
        private DateTime startTimerUp;
        private DateTime pauseTimerUp;
        private DateTime endTimerDown;
        private DateTime pauseTimerDown;

        public Fm()
        {
            InitializeComponent();

            tmUp.Interval = 100; // 1 сек = 1000
            tmUp.Tick += TmUp_Tick;
            buUp.Click += BuUp_Click;
            buUpPause.Click += BuUpPause_Click;
            pbUp.Maximum = SEC_MAX;
            pbUpMs.Maximum = SEC_MAX * 1000;

            tmDown.Interval = 100; // 1 сек = 1000
            tmDown.Tick += TmDown_Tick;
            buDown.Click += BuDown_Click;
            buDownPause.Click += BuDownPause_Click;
            pbDown.Value = pbDown.Maximum = SEC_MAX;
            pbDownMs.Value = pbDownMs.Maximum = SEC_MAX * 1000;
        }

        private void BuDownPause_Click(object? sender, EventArgs e)
        {
            if (tmDown.Enabled)
            {
                pauseTimerDown = DateTime.Now;
                tmDown.Stop();
            }
            else
            {
                endTimerDown = DateTime.Now + (endTimerDown - pauseTimerDown);
                tmDown.Start();
            }
            
            
        }

        private void BuDown_Click(object? sender, EventArgs e)
        {
            tmDown.Enabled = !tmDown.Enabled;
            endTimerDown = DateTime.Now.AddSeconds(SEC_MAX);
        }

        private void TmDown_Tick(object? sender, EventArgs e)
        {
            //(2)
            var x = endTimerDown - DateTime.Now;
            if (x.TotalSeconds < 0)
            {
                tmDown.Stop();
                x = TimeSpan.Zero;
            }
            buDown.Text = x.ToString(@"mm\:ss\.fff");
            pbDown.Value = (int)x.TotalSeconds;
            pbDownMs.Value = (int)x.TotalMilliseconds;
        }

        private void BuUpPause_Click(object? sender, EventArgs e)
        {
            if (tmUp.Enabled)
            {
                pauseTimerUp = DateTime.Now;
                tmUp.Stop();
            }
            else
            {
                startTimerUp = startTimerUp + (DateTime.Now - pauseTimerUp);
                tmUp.Start();
            }
        }

        private void BuUp_Click(object? sender, EventArgs e)
        {
            tmUp.Enabled = !tmUp.Enabled;
            startTimerUp = DateTime.Now;
        }

        private void TmUp_Tick(object? sender, EventArgs e)
        {
            //(1)
            //buUp.Text = (DateTime.Now - startTimerUp).ToString(@"mm\:ss\.fff");

            //(2)
            var x = DateTime.Now - startTimerUp;
            if (x.TotalSeconds > SEC_MAX)
            {
                tmUp.Stop();
                x = TimeSpan.FromSeconds(SEC_MAX);
            }
            buUp.Text = x.ToString(@"mm\:ss\.fff");
            pbUp.Value = (int)x.TotalSeconds;
            pbUpMs.Value = (int)x.TotalMilliseconds;
        }
    }
}
