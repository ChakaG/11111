using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StekTest
{
    class sort4 : Sort1
    {

        public ListBox Str2(ListBox LB)
        {

            string[] clist = LB.Items.OfType<string>().ToArray();
            float[] arr = makeFloatGreatAgain(clist);

            for (int i = 1; i < arr.Length; i++)
            {
                float cur = arr[i];
                int j = i;
                while (j > 0 && cur < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = cur;
            }

            LB.Items.Clear();

            foreach (float i in arr)
                LB.Items.Add(i.ToString());

            return LB;
        }
    }
}