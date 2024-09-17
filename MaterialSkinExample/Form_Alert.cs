using System;
using System.Diagnostics;
using System.Drawing;

using System.Windows.Forms;
using MaterialSkinExample.Properties;

namespace MaterialSkinExample
{
    public partial class Form_Alert : Form
    {
        public Form_Alert()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }
        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        public void ShowAlert(string msg, enmType type)
        {
            this.lblMsg.Text = msg;

            switch (type)
            {
                case enmType.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                    // Add cases for Warning and Info if needed
            }

            // Position the form
            this.Location = new Point(
                Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                Screen.PrimaryScreen.WorkingArea.Height - this.Height
            );

            this.Show();

            // Set a timer to auto-close the form after 300 seconds
            Timer autoCloseTimer = new Timer();
            autoCloseTimer.Interval = 300000; // 300 seconds
            autoCloseTimer.Tick += (sender, e) => {
                autoCloseTimer.Stop();
                this.Close();
            };
            autoCloseTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Interval = 3;
            //action = enmAction.close;
            this.Close();
        }

    }
}
