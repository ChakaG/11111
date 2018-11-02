using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StekTest
{
    class sort2 : Sort1
    {
        // public ListBox LB = new ListBox();

        public ListBox Str2(ListBox LB)
        {

            string[] clist = LB.Items.OfType<string>().ToArray();
            float[] arr = makeFloatGreatAgain(clist);

            //arr[] = arr.Reverse<float>;

            Array.Reverse(arr);

            LB.Items.Clear();

            foreach (float i in arr)
            {
                LB.Items.Add(i.ToString());
            }
                


            return LB;


        }
    }
}
