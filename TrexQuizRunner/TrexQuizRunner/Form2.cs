using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrexQuizRunner
{
    public partial class welcomeScreen : Form
    {
        
        public welcomeScreen()
        {
            InitializeComponent();
        }

        private void startGame(object sender, EventArgs e)
        {
            gameScreen ingamescreen = new gameScreen();
            ingamescreen.Show();
        }

        private void showHelp(object sender, EventArgs e)
        {
            helpScreen inhelpscreen = new helpScreen();
            inhelpscreen.Show();
        }
    }
}
