using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StekTest
{
    public partial class SortWindow : Form
    {
        public SortWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || Regex.IsMatch(this.textBox1.Text, "[a-zA-z' ']"))//@"^[a-zA-z]+$"
            {
                MessageBox.Show("введи число");
            }
            else
            {
                int ind = 0;
                listBox1.Items.Insert(ind, textBox1.Text);
                textBox1.Clear();
                ind++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)

            {
                Sort1 LB1 = new Sort1();
                LB1.LB = listBox1;
                listBox1 = LB1.Str(LB1.LB);
            }
            if (radioButton2.Checked)
            {
                sort2 lb2 = new sort2();
                lb2.LB = listBox1;
                listBox1 = lb2.Str(lb2.LB);
            }
            if (radioButton3.Checked)
            {
                sort3 lb3 = new sort3();
                lb3.LB = listBox1;
                listBox1 = lb3.Str(lb3.LB);
            }
            if (radioButton4.Checked)
            {
                sort4 lb4 = new sort4();
                lb4.LB = listBox1;
                listBox1 = lb4.Str(lb4.LB);
            }
            if (radioButton5.Checked)
            {
                sort5 lb5 = new sort5();
                lb5.LB = listBox1;
                listBox1 = lb5.Str(lb5.LB);
            }
            if (radioButton6.Checked)
            {
                sort6 lb6 = new sort6();
                lb6.LB = listBox1;
                listBox1 = lb6.Str(lb6.LB);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchNumberInListbox search = new SearchNumberInListbox();
            search.LB = listBox1;
            search.str = textBox1.Text.ToString();
            listBox1 = search.findInListbox(search.LB, search.str);
        }
    }
}
