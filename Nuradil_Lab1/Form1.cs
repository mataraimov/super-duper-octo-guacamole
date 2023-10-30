using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(textBox1.Text);
            int second = Convert.ToInt32(textBox2.Text);
            string operator1 = textBox3.Text;
            if (operator1 == "-")
            {
                textBox4.Text = (first - second).ToString();
            }
            else if (operator1 == "+") {
                textBox4.Text = (first + second).ToString();
            }
            else if (operator1 == "/")
            {
                textBox4.Text = (first / second).ToString();
            }
            else if (operator1 == "*")
            {
                textBox4.Text = (first * second).ToString();
            }
        }

       
    }
}
