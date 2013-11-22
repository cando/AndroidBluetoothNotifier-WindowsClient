using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidBluetoothNotifier
{
    public partial class Notification : Form
    {
        Timer timer;
        private bool already_on_notification = false;

        public Notification()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 10000;
            timer.Tick += timer_Tick;
        }

        internal async void newNotification(String title, String body, Image icon)
        {
            await Task.Run(() =>
            {
                while (already_on_notification)
                    System.Threading.Thread.Sleep(1000);
            });
            this.labelTitleNotification.Text = title;
            this.labelBodyNotification.Text = body;
            if (icon != null)
                this.iconBox.Image = icon;
            timer.Start();
            already_on_notification = true;
            RepositionNotification();
            this.Show();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            RepositionNotification();
        }

        private void RepositionNotification()
        {
            Rectangle workingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            int left = workingArea.Width - this.Width;
            int top = workingArea.Height - this.Height;

            this.Location = new Point(left, top);
            this.TopMost = true;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            already_on_notification = false;
            this.Hide();
        }

    }
}
