using System.Configuration;

namespace AppTimer
{
    public partial class Form1 : Form
    {
        private bool timerRunning = false;
        private int seconds = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerRunning)
            {
                TimeSpan time = TimeSpan.FromSeconds(seconds);    
                seconds++;
                lblTimer.Text = time.ToString(@"hh\:mm\:ss");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        { 
            if (!timerRunning)
            {
                    timerRunning = true;
                    timer1.Start();
                    startButton.Enabled = false;
                    stopButton.Enabled = true;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (timerRunning)
            {
                timerRunning = false;
                timer1.Stop();
                stopButton.Enabled = false;
                startButton.Enabled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timerRunning = false;
            lblTimer.Text = "00:00:00";
            timer1.Stop();
            seconds = 0;
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }
    }
}