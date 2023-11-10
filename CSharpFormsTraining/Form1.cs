using System;
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
            BasicTraning add = new BasicTraning();            

            double b = double.Parse(textBox2.Text);            
            double c = add.forloop1(b);
            textBox1.Text = c.ToString();
        }
    }
}
