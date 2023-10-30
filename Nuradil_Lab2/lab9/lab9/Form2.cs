using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // write only this part
        public string FirstName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string LastName
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public int Age
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        //////
    }
}

