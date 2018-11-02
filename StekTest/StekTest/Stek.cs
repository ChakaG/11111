using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StekTest
{
    public partial class Stek : Form
    {
        public Stek()
        {
            InitializeComponent();
            
        }
        stekPopPush spp = new stekPopPush();

        private void button1_Click(object sender, EventArgs e)
        {   
            spp.PushButton = button1;
            spp.txt = textBox2;
            spp.LB = listBox1;
            spp.lisboxRange = textBox1;
            button1 = spp.pushInListBox(spp.PushButton,spp.txt,spp.lisboxRange, spp.LB);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spp.Popbutton = button2;
            spp.txt = textBox2;
            spp.LB = listBox1;
            button2 = spp.popFromListBox(spp.Popbutton, spp.txt, spp.LB);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            spp.Peekbutton = button3;
            spp.txt = textBox2;
            spp.LB = listBox1;
            button3 = spp.peekFromListBox(spp.Peekbutton, spp.txt, spp.LB);
        }
    }
}
