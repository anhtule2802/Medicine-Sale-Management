﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUD_GUI
{
    public partial class SplashScreen : Form
    {
     
        public SplashScreen()
        {

            InitializeComponent();

        }


        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
                timerLoad.Stop();
        }
    }
}
