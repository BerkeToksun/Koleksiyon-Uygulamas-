﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sehirler = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            sehirler.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sehirler.Count; i++)
            {
                listBox1.Items.Add(sehirler[i]);
            }
        }
    }
}
