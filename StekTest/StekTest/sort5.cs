using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StekTest
{
    class sort5 : Sort1
    {
        public ListBox Str(ListBox LB)
        {

            string[] sarr = LB.Items.OfType<string>().ToArray();
            float[] arr = makeFloatGreatAgain(sarr);


            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                float temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }


            LB.Items.Clear();

            foreach (float i in arr)
                LB.Items.Add(i.ToString());

            return LB;
        }
    }
}
