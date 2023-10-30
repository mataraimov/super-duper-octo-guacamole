using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = richTextBox2.Text + "\n" + richTextBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.AppendText(richTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Lines = new string[] { "Line 1", "Line 2" };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }
    }
}
