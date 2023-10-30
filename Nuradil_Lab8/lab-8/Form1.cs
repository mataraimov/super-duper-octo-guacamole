using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                MessageBox.Show("Value" + checkedListBox1.Items[i].ToString() + "State is" + checkedListBox1.GetItemCheckState(i).ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.CheckState.ToString());
            MessageBox.Show(checkBox2.CheckState.ToString());
            MessageBox.Show(checkBox3.CheckState.ToString());
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Checked;
            checkBox3.CheckState = CheckState.Indeterminate;
            if (checkBox2.CheckState == CheckState.Checked)
            {
                MessageBox.Show("The state of option 2 is equal to selected");
            }
            else
                MessageBox.Show("The state of choice item 2 is not selected or not defined");

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (int index in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.Items.RemoveAt(index);
            }
            
            if (CheckState.Unchecked == CheckState.Checked)
                MessageBox.Show("Value Selection Item 4 Selected");
            else
                MessageBox.Show("Value Selection Item 4 Not Selected");


        }
    }
}
