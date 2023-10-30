using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
            for (int i = 13; i > 0; i--)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Remove("Первая строка");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show(comboBox2.SelectedIndex.ToString());
            }
            else
            {
                MessageBox.Show("You didn't select any value.", "Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show(comboBox2.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("You didn't select any value.", "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] arr = { "Excellent", "Good", "Satisfactory", "Unsatisfactory" };
            comboBox1.DataSource = arr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] arr = { "Excellent", "Good", "Satisfactory", "Unsatisfactory" };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                comboBox1.Items.Add(arr[i]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Remove(comboBox2.SelectedItem);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboBox2.Items.RemoveAt(0);
        }
    }
}
