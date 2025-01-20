namespace AlarmClock
{
    public partial class MainForm : Form
    {
        Boolean on = false;
        Boolean musicOn = false;
        Music music = new Music();

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
            if ((lblClockHours.Text == txtHours.Text) && (lblClockMinutes.Text == txtMinutes.Text) && (on == true) && (!musicOn))
            {
                music.Play(@"Data\Songs\הכל יהיה.mp3");
                musicOn = true;
            }
            if (!on)
            {
                music.Stop();
                musicOn = false;
            }
        }
        void UpdateClock()
        {
            int hours = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            int seconds = DateTime.Now.Second;
            if (hours < 10)
            {
                lblClockHours.Text = "0" + hours.ToString();
            }
            else
            {
                lblClockHours.Text = hours.ToString();
            }
            if (minutes < 10)
            {
                lblClockMinutes.Text = "0" + minutes.ToString();
            }
            else
            {
                lblClockMinutes.Text = minutes.ToString();
            }
            if (seconds < 10)
            {
                lblClockSeconds.Text = "0" + seconds.ToString();
            }
            else
            {
                lblClockSeconds.Text = seconds.ToString();
            }
        }

        private void btOn_Click(object sender, EventArgs e)
        {
            if (btOn.BackColor == Color.Red)
            {
                btOn.BackColor = Color.Green;
                btOn.Text = "On";
                on = true;
            }
            else
            {
                btOn.BackColor = Color.Red;
                btOn.Text = "Off";
                on = false;
            }
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            if (StringHelper.IsNumeric(txtHours.Text))
            {
                int numHours = int.Parse(txtHours.Text);
                if ((numHours < 0) || (numHours > 23))
                {
                    MessageBox.Show("Enter number between 0 to 23");
                    txtHours.Text = "00";
                }
            }
            else
            {
                MessageBox.Show("Enter number between 0 to 23");
                txtHours.Text = "00";
            }
        }

        private void txtMinutes_TextChanged(object sender, EventArgs e)
        {
            if (StringHelper.IsNumeric(txtMinutes.Text))
            {
                int numMinutes = int.Parse(txtMinutes.Text);
                if ((numMinutes < 0) || (numMinutes > 59))
                {
                    MessageBox.Show("Enter number between 0 to 23");
                }
            }
            else
            {
                MessageBox.Show("Enter number between 0 to 23");
            }
        }
    }
}