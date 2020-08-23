using System;
using System.Media;
using System.Windows.Forms;

namespace Alarm_Clock
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        delegate void UpdateLable(Label lbl1, string value);
        void UpdateDateLable(Label lbl1,string value) 
        {
            lbl1.Text = value;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
             if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
             {
                timer.Stop();
                try
                {
                    UpdateLable upd = UpdateDateLable;
                    if (lbl1Status.InvokeRequired)
                        Invoke(upd, lbl1Status, "Stop"); 
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\Users\denis\Desktop\As1\As1.wav";
                    player.PlayLooping();
                }
                catch (Exception ex)
                {       
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             }
        }

        private void b1Start_Click(object sender, EventArgs e)
        {
            timer.Start();
            lbl1Status.Text = "Running...";
        }

        private void b2Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lbl1Status.Text = "Stop";
        }
    }
}
