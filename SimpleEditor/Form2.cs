﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
             Application.Exit();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
