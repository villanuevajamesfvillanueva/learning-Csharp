using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace TrexQuizRunner
{
    public partial class welcomeScreen : Form
    {
        SoundPlayer sound = new SoundPlayer(@".\Resources\Jurassic Park theme compressed.wav");
        public welcomeScreen()
        {
            InitializeComponent();
            welcomeScreenInit();
        }

        private void welcomeScreenInit()
        {
            soundMuted.Visible = true;
            soundEnabled.Visible = false;
            sound.Play();
        }

        private void startGame(object sender, EventArgs e)
        {
            sound.Stop();
            gameScreen ingamescreen = new gameScreen();
            ingamescreen.FormClosed += ingamescreen_FormClosed;
            ingamescreen.Show();
        }

        private void ingamescreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            welcomeScreenInit();
        }


        private void showHelp(object sender, EventArgs e)
        {
            helpScreen inhelpscreen = new helpScreen();
            inhelpscreen.Show();
        }

        private void enableSound(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@".\Resources\Jurassic Park theme compressed.wav");
            sound.Play();
            soundMuted.Visible = true;
            soundEnabled.Visible = false;
        }

        private void disableSound(object sender, EventArgs e)
        {
            sound.Stop();
            soundMuted.Visible = false;
            soundEnabled.Visible = true;
        }
    }
}
