﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceylon_TimeTableManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SubMenu f = new SubMenu();
            f.TopLevel = false;
            f.MdiParent = null;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            f.Show();
            label2.Text = DateTime.Now.ToString();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            SubMenu f = new SubMenu();
            f.TopLevel = false;
            f.MdiParent = null;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            f.Show();
            label2.Text = DateTime.Now.ToString();
        }

    }
}
