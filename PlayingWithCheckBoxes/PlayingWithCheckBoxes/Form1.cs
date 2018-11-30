using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayingWithCheckBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                label1.Text = " Check box one is checked";
            }
            else if (checkBox2.Checked)
            {
                label1.Text = " Check box two is chekced ";
            }
            else if (checkBox3.Checked)
            {
                label1.Text = " check box three is checked ";
            }
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                label1.Text = " check box two and three are checked ";
            }
        }
    }
}
