﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romero___Rymirox_Resume_Creator
{
    public partial class AboutScreenForm : Form
    {
        public AboutScreenForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutScreenForm2 aboutScreenForm2 = new AboutScreenForm2();
            aboutScreenForm2.ShowDialog();
        }
    }
}
