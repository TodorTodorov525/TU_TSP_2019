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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Generator g = new Generator();

        private void button1_Click(object sender, EventArgs e)
        {
            
            g.a_side = Int32.Parse(textBox2.Text);
            g.b_side = Int32.Parse(textBox3.Text);
            int result = g.a_side + g.b_side;
            textBox4.Text = result.ToString();
            int numberOfLabels = Int32.Parse(textBox1.Text);
          
            g.l_list = g.generateLabel(numberOfLabels);
            foreach (Label element in g.l_list)
            {
                this.Controls.Add(element);
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
          // List<Label> labelsList = g.l_list;
            foreach (Label element in g.l_list)
            {
                this.Controls.Remove(element);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear(); 
            textBox4.Clear();
        }
    }
}
