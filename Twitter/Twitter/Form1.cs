using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTweet_Click(object sender, EventArgs e)
        {
            string message;
            const int MAX = 140;

            message = txtBoxTweet.Text;

            if(message.Length > MAX)
            {
                lblMessage.Text = message.Length + " OVER LIMIT";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblMessage.Text = message.Length + " Under Limit ";
                lblMessage.ForeColor = System.Drawing.Color.Black;
            }
        }
    }
}
