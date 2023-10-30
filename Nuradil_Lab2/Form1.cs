using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a line");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with line", "Line Title");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a string and different buttons", "Title string", MessageBoxButtons.OKCancel);
            MessageBox.Show("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.AbortRetryIgnore);
            MessageBox.Show("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a line and different buttons", "Title bar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MessageBox.Show("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save data", "Attention!", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.OK)
                MessageBox.Show("Data saved");
            if (result == DialogResult.No)
                MessageBox.Show("Data not saved");
            if (result == DialogResult.Cancel)
                MessageBox.Show("Saving data canceled by the user");
        }
    }
}

