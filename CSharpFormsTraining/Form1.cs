﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFormsTraining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                   

            double b = double.Parse(textBox2.Text);            
            double c = BasicTraning.ForLoop1(b);
            textBox1.Text = c.ToString() + "\r\n" + textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double b = double.Parse(textBox2.Text);
            double c = BasicTraning.While1(b);
            textBox1.Text = c.ToString() + "\r\n" + textBox1.Text;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            double b = double.Parse(textBox2.Text);
            double c = BasicTraning.DoWhile1(b);
            textBox1.Text = c.ToString() + "\r\n" + textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Application.ExitThread();
            Application.Exit();
        }
    }
}
