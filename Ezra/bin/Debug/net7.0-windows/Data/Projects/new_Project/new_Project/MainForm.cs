
namespace Ghost
{
    public partial class MainForm : Form
    {
        int timerCount;
        int gameScore;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Music.Stop();
            timerCount = 25;
            gameScore = 0;
            btnStart.Visible = false;
            Music.Play(@"Data/Songs/HaPijamot_song.mp3");
            pbGhost.Image = Properties.Resources.start;
            pbGhost.Visible = true;
            lblGameScore.Visible = true;
            lblTimerCount.Visible = true;
            lblTimerCount.Text = "Timer: " + timerCount.ToString();
            lblGameScore.Text = "Score: " + gameScore.ToString();
            tGame.Enabled = true;
        }

        private void pbGhost_Click(object sender, EventArgs e)
        {
            pbGhost.Visible = false;
            gameScore += 1;
            lblGameScore.Text = "Score: " + gameScore.ToString();
            //pbGhost.Image = ((System.Drawing.Image)(Properties.Resources.ResourceManager.GetObject(gameScore.ToString())));
            pbGhost.Image = Properties.Resources.ResourceManager.GetObject($"{gameScore}") as Image;
            pbGhost.Visible = true;

        }

        private void tGame_Tick(object sender, EventArgs e)
        {
            if ((pbGhost.Width >= 40) && (pbGhost.Height >= 40))
            {
                pbGhost.Width -= 7;
                pbGhost.Height -= 7;
            }
            Random R = new Random();
            int x = R.Next(10, Width - pbGhost.Width - 10);
            int y = R.Next(90, Height - pbGhost.Height - 30);
            Point P = new Point(x, y);
            pbGhost.Location = P;
            timerCount -= 1;
            lblTimerCount.Text = "Timer: " + timerCount.ToString();
            if (gameScore == 10)
            {
                tGame.Stop();
                btnStart.Visible = true;
                pbGhost.Visible = false;
                pbGhost.Width = 120;
                pbGhost.Height = 120;
                Music.Stop();
                Music.Play(@"Data/Songs/HaPijamot_win.mp3");
                MessageBox.Show("you win!");
            }
            if (timerCount == 0)
            {
                tGame.Stop();
                btnStart.Visible = true;
                pbGhost.Visible = false;
                pbGhost.Width = 120;
                pbGhost.Height = 120;
                Music.Stop();
                Music.Play(@"Data/Songs/HaPijamot_lose.mp3");
                MessageBox.Show("you lose");
            }
        }
    }
}