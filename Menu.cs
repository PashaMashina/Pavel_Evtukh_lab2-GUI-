﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GUI
{
    public partial class Menu : Form
    {
        Thread th;
        public Menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            
        }

        public void open(object obj)
        {
            Application.Run(new Task1());
        }

        private void exp2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open2(object obj)
        {
            Application.Run(new Task2());
        }
    }
}
