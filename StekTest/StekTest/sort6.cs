using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StekTest
{
    class sort6 : Sort1
    {
        static float[] MergeSort(float[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }

            Int32 middle = array.Length / 2;
            return Merge(MergeSort(array.Take(middle).ToArray()), MergeSort(array.Skip(middle).ToArray()));
        }

        static float[] Merge(float[] arr1, float[] arr2)
        {
            Int32 ptr1 = 0, ptr2 = 0;
            float[] merged = new float[arr1.Length + arr2.Length];

            for (Int32 i = 0; i < merged.Length; ++i)
            {
                if (ptr1 < arr1.Length && ptr2 < arr2.Length)
                {
                    merged[i] = arr1[ptr1] > arr2[ptr2] ? arr2[ptr2++] : arr1[ptr1++];
                }
                else
                {
                    merged[i] = ptr2 < arr2.Length ? arr2[ptr2++] : arr1[ptr1++];
                }
            }

            return merged;
        }

        public ListBox Str(ListBox LB)
        {

            string[] sarr = LB.Items.OfType<string>().ToArray();
            float[] arr = makeFloatGreatAgain(sarr);
            arr = MergeSort(arr);



            LB.Items.Clear();

            foreach (float i in arr)
                LB.Items.Add(i.ToString());

            return LB;
        }
    }
}
