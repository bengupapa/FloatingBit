using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloatingBit
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private static WatchType _WatchType = WatchType.Time;
        private static DateTime? _TargetTime = null;
        private static bool _HasTobeDismissed = false;
        private static SoundPlayer _Player = new SoundPlayer()
        {
            SoundLocation = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Resources/alarm.wav"))
        };

        public Form1()
        {
            InitializeComponent();
            SetUp();
        }

        public void SetUp()
        {
            this.TopMost = true;
            SetWatch();
            ShowTimePicker(false);
            ShowAlarm(false);

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void ShowAlarm(bool value)
        {
            pictureBox1.Visible = value;
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_WatchType.Equals(WatchType.Time)) Time();
            if (_WatchType.Equals(WatchType.CountDown)) CountDown();
        }

        private void SetWatch(WatchType? watch = null)
        {
            if(watch == null || watch.Equals(WatchType.Time))
            {
                TimeLabel.ForeColor = Color.White;
                CountDownLabel.ForeColor = Color.Black;

                _WatchType = WatchType.Time;
            }
            else if(watch.Equals(WatchType.CountDown))
            {
                TimeLabel.ForeColor = Color.Black;
                CountDownLabel.ForeColor = Color.White;

                _WatchType = WatchType.CountDown;
            }
        }

        private void Time()
        {
            SetTime(DateTime.Now);
        }

        private void CountDown()
        {
            if(!(_HasTobeDismissed))
            {
                if(_TargetTime.HasValue)
                {
                    if (DateTime.Compare(_TargetTime.Value, DateTime.Now) >= 0)
                    {
                        var count = _TargetTime.Value.Subtract(DateTime.Now);
                        SetTime(count.Hours, count.Minutes, count.Seconds);
                    }
                    else
                    {
                        _TargetTime = null;
                        _HasTobeDismissed = true;
                        SetCountDownLabelText("Dismiss");
                        SetFormBackgroundColor(Color.OrangeRed);
                        PlayAlert(true);
                        ShowAlarm(true);
                    }
                }
            }
        }

        private void SetCountDownLabelText(string value, Color? color = null)
        {
            CountDownLabel.Text = value;
            CountDownLabel.ForeColor = color ?? Color.White;
        }

        private void PlayAlert(bool play)
        {
            if(play)
            {
                _Player.PlayLooping();
            }
            else
            {
                _Player.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _TargetTime = dateTimePicker1.Value;
            SetTime(dateTimePicker1.Value);
            ShowTimePicker(false);
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {
            SetWatch(WatchType.Time);
            ShowTimePicker(false);
            SetCountDownLabelText("Count down", Color.Black);
        }

        private void CountDownLabel_Click(object sender, EventArgs e)
        {
            if(_HasTobeDismissed)
            {
                _HasTobeDismissed = false;
                _TargetTime = null;
                PlayAlert(false);
                SetFormBackgroundColor(SystemColors.Highlight);
                SetCountDownLabelText("Count down", Color.Black);
                SetWatch(WatchType.Time);
                ShowAlarm(false);
            }
            else
            {
                SetTime();
                SetWatch(WatchType.CountDown);
                ShowTimePicker(true);
            }
        }

        private void ShowTimePicker(bool isVisible)
        {
            dateTimePicker1.Visible = isVisible;
            button1.Visible = isVisible;
        }

        private void SetTime(DateTime dateTime)
        {
            SetTime(dateTime.Hour, dateTime.Minute, dateTime.Second);
        }

        private void SetTime(int hour = 0, int minutes = 0, int seconds = 0)
        {
            var sHour = hour.ToString();
            var sMinutes = minutes.ToString();
            var sSeconds = seconds.ToString();

            hourLabel.Text = sHour.Length < 2 ? $"0{hour}" : sHour;
            minutesLabel.Text = sMinutes.Length < 2 ? $"0{minutes}" : sMinutes;
            secondsLabel.Text = sSeconds.Length < 2 ? $"0{seconds}" : sSeconds;
        }

        private void SetFormBackgroundColor(Color color)
        {
            this.BackColor = color;
        }
    }

    public enum WatchType
    {
        Time = 0, CountDown = 1
    }
}
