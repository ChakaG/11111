using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StekTest
{
    class SearchNumberInListbox
    {
        public string str;
        public ListBox LB;

        public ListBox findInListbox(ListBox LB, string str)
        {
            LB.ClearSelected();
            //string[] sarr = changeDotsToCommas(LB.Items.OfType<string>().ToArray());
            LB.SelectionMode = SelectionMode.MultiExtended;
            for (int i = 0; i < LB.Items.Count; i++)
            {
                if (LB.Items[i].ToString().Equals(str))
                {
                    LB.SetSelected(i, true);
                }
            }


            return LB;
        }
    }
}
