using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StekTest
{
    class sort3 : Sort1
    {

        public ListBox Str(ListBox LB)
        {

            string[] clist = LB.Items.OfType<string>().ToArray();
            float[] arr = makeFloatGreatAgain(clist);


            float repos = 0;
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        repos = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = repos;
                    }
                }
            }

            LB.Items.Clear();

            foreach (float i in arr)
                LB.Items.Add(i.ToString());

            return LB;
        }
    }
}
