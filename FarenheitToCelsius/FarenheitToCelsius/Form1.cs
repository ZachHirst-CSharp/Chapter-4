using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace FarenheitToCelsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string tempAM, tempNoon, tempPM;
            double tempam, tempnoon, temppm;
            double conversion1, conversion2, conversion3;
            double avg;

            tempAM = txtboxAM.Text;
            tempNoon = txtBoxNoon.Text;
            tempPM = txtBoxPM.Text;

            tempam = Convert.ToDouble(tempAM);
            tempnoon = Convert.ToDouble(tempNoon);
            temppm = Convert.ToDouble(tempPM);

            avg = (tempam + tempnoon + temppm) / 3;

            conversion1 = (tempam - 32) / 1.8;
            conversion2 = (tempnoon - 32) / 1.8;
            conversion3 = (temppm - 32) / 1.8;

            FAM.Text = tempam + " ° ";
            FNOON.Text = tempnoon + " ° ";
            FPM.Text = temppm + " ° ";

            CAM.Text = conversion1 + " ° ";
            CNOON.Text = conversion2 + " ° ";
            CPM.Text = conversion3 + " ° ";


            if(avg < 32)
            {
                lblSmart.Visible = true;
                lblSmart.Text = " BRRRRRRR... Must be pretty cold out ";
            }
            else if(avg > 100)
            {
                lblSmart.Visible = true;
                lblSmart.Text = " Wow its pretty hot out.. Kinda wanna find some AC";
            }
            else
            {
                lblSmart.Visible = true;
                lblSmart.Text = "Its a pretty normal day. ";
            }
        }
    }
}
