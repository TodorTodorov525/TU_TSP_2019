using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    class Generator
    {

        public int a_side { get; set; }
        public int b_side { get; set; }
        public List<Label> l_list { get; set; }
        public List<Label> generateLabel(int n)
        {
            List<Label> obj = new List<Label>();
            for (int i = 0; i < n; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("Label {0}", i);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 25;

                obj.Add(label);
            }

            return obj;
        }
    }
}
