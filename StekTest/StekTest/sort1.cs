using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace StekTest
{
    class Sort1
    {

        public string[] changeDotsToCommas(String[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains('.'))
                {
                    StringBuilder sb = new StringBuilder(arr[i]);
                    arr[i] = sb.Replace('.', ',').ToString();
                }
            }
            return arr;
        }

        public float[] makeFloatGreatAgain(String[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains('.'))
                {
                    StringBuilder sb = new StringBuilder(arr[i]);
                    arr[i] = sb.Replace('.', ',').ToString();
                }
            }

            float[] farr = new float[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                farr[i] = float.Parse(arr[i]);
            }
            return farr;
        }

        public ListBox LB = new ListBox();

        public ListBox Str(ListBox LB)
        {

            string[] sarr = LB.Items.OfType<string>().ToArray();
            float[] arr = makeFloatGreatAgain(sarr);

            Array.Sort(arr);

            LB.Items.Clear();

            foreach (float i in arr)
                LB.Items.Add(i.ToString());

            return LB;
        }

    }
}
