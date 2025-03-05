using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace MT_Sliding_Puzzle
{
    public partial class MT_Sliding_Puzzle : Form
    {
        Stopwatch stopwatch;
        int kx = 4, ky = 4;
        Button[] MT_buttons;
        int dx, dy;

        public MT_Sliding_Puzzle()
        {
            InitializeComponent();
            MT_buttons = new Button[kx * ky];
            dx = MT_panel.Width / kx;
            dy = MT_panel.Height / ky;
            MT_makeButtons();
            stopwatch = new Stopwatch();
        }

        public void MT_makeButtons()
        {
            int k = kx * ky;
            for (int i = 0; i < k; i++)
            {
                MT_buttons[i] = new Button();
                MT_panel.Controls.Add(MT_buttons[i]);
                MT_buttons[i].Width = dx;
                MT_buttons[i].Height = dy;
                int rida = i / kx;
                int veerg = i % kx;
                MT_buttons[i].Left = veerg * dx;
                MT_buttons[i].Top = rida * dy;
                MT_buttons[i].Click += new EventHandler(MT_btn_Click);
                MT_buttons[i].Enabled = false;
            }
        }

        private void MT_StartGame_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int k = kx * ky;
            int kuhu;
            for (int i = 0; i < k; i++)
            {
                MT_buttons[i].Text = "";
                MT_buttons[i].Enabled = true;
            }

            for (int n = 1; n < k; n++)
            {
                do
                {

                    kuhu = rn.Next(0, k);

                } while (MT_buttons[kuhu].Text != "");

                MT_buttons[kuhu].Text = n.ToString();

            }
            stopwatch.Restart();
            stopwatch.Start();
        }

        private void MT_GiveUp_Click(object sender, EventArgs e)
        {
            string message = $"Congratulations for giving up!";
            string caption = "Loser";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void MT_btn_Click(object sender, EventArgs args)
        {
                int n = Array.IndexOf(MT_buttons, (Button)sender);

    if (n % 4 != 3 && MT_buttons[n + 1].Text == "")
    {
        (MT_buttons[n].Text, MT_buttons[n + 1].Text) = (MT_buttons[n + 1].Text, MT_buttons[n].Text);
    }
    else if (n % 4 != 0 && MT_buttons[n - 1].Text == "")
    {
        (MT_buttons[n].Text, MT_buttons[n - 1].Text) = (MT_buttons[n - 1].Text, MT_buttons[n].Text);
    }
    else if (n + 4 < 16 && MT_buttons[n + 4].Text == "")
    {
        (MT_buttons[n].Text, MT_buttons[n + 4].Text) = (MT_buttons[n + 4].Text, MT_buttons[n].Text);
    }
    else if (n - 4 >= 0 && MT_buttons[n - 4].Text == "")
    {
        (MT_buttons[n].Text, MT_buttons[n - 4].Text) = (MT_buttons[n - 4].Text, MT_buttons[n].Text);
    }

    checkForWin();
}

        public void checkForWin()
        {
            int checkedButtons = 0;
            for (int i = 0; i < MT_buttons.Length - 1; i++)
            {
                if (MT_buttons[i].Text != "" && i + 1 == int.Parse(MT_buttons[i].Text))
                {
                    checkedButtons++;
                }
                else
                {
                    break;
                }
            }
            if (checkedButtons == 15)
            {
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                string formattedTime = $"{ts.Minutes} minute(s) " +
                                   $"{ts.Seconds} second(s)";
                string message = $"Congratulations. You have solved this puzzle in {formattedTime}!";
                string caption = "Winner";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, buttons);

            }
        }
    }
}