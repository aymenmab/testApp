﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string a="salut";
            MessageBox.Show(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bonjour");
            string master = "master";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
