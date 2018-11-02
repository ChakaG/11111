using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StekTest
{
    class stekPopPush
    {
        public Button PushButton;
        public Button Popbutton;
        public Button Peekbutton;
        public ListBox LB;
        public TextBox txt;
        public TextBox lisboxRange;

        public bool checkForDigit(TextBox txt,TextBox listboxrange)
        {
            bool check = false;
            Regex nonNumericRegex = new Regex(@"\D");
            if (nonNumericRegex.IsMatch(txt.Text) && nonNumericRegex.IsMatch(lisboxRange.Text))
            {
                check = true;
            }

            return check;
        }

        public Button pushInListBox(Button PushButton, TextBox txt, TextBox listRange, ListBox lb)
        {
            if(txt.Text.ToString().Contains(','))
            {
                StringBuilder sb = new StringBuilder(txt.Text.ToString());
                txt.Text = sb.Replace(',', '.').ToString();
            }

            if (Regex.IsMatch(txt.Text, @"^[0-9]*(?:\.[0-9]+)?$", RegexOptions.Compiled))//@"^[0-9]*(?:\.[0-9]*)?$"
            {
                if (Regex.IsMatch(lisboxRange.Text, "^[0-9]+$", RegexOptions.Compiled))
                {
                    if (lb.Items.Count < int.Parse(listRange.Text))
                    {
                        lb.Items.Insert(0, txt.Text);
                        txt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Стек переполнен");
                    }
                }
                else
                {
                    lb.Items.Insert(0, txt.Text);
                    txt.Clear();
                }
            }
            else
            {
                MessageBox.Show("Нормально введити пж");
            }


            return PushButton;
        }

        public Button popFromListBox(Button PopButton,TextBox txt,ListBox lb)
        {
            txt.Text = lb.Items[0].ToString();
            lb.Items.Remove(lb.Items[0]);
            return PopButton;

        }

        public Button peekFromListBox(Button peekButton, TextBox txt, ListBox lb)
        {
            txt.Text = lb.Items[0].ToString();
            return peekButton;
        }

        

    }
}
