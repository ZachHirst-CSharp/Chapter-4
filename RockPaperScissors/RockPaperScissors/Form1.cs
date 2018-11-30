using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Playground : Form
    {
        int win = 0;
        int lose = 0;
        

        public Playground()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            int rock = 1;
            CalculateResults(rock);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            int paper = 2;
            CalculateResults(paper);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            int scissors = 3;
            CalculateResults(scissors);
        }

        private void CalculateResults(int decision)
        {
           
            
            Random randomGenerator = new Random();
            int min = 1;
            int max = 4;
            int randomNumber;
            randomNumber = randomGenerator.Next(min, max);

            ComputerDisplay(randomNumber, decision);

            if (decision == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox5.Visible = false;

                if(randomNumber == decision)
                { 
                    winvlose.Text = " Tie ";
                }
                else if(randomNumber == 2)
                {
                    lose = lose + 1;
                    loses_lbl.Text = " Loses: " + lose;
                    winvlose.Text = "LOSE";
                }
                else if(randomNumber == 3)
                {
                    win = win + 1;
                    wins_lbl.Text = " Wins " + win;
                    winvlose.Text = "WIN";
                }
            }

            if (decision == 2)
            {
                pictureBox2.Visible = true;
                pictureBox5.Visible = false;
                pictureBox1.Visible = false;
                if (randomNumber == decision)
                {
                    winvlose.Text = " Tie ";
                }
                else if (randomNumber == 3)
                {
                    lose = lose + 1;
                    loses_lbl.Text = " Loses: " + lose;
                    winvlose.Text = "LOSE";
                }
                else if (randomNumber == 1)
                {
                    win = win + 1;
                    wins_lbl.Text = " Wins " + win;
                    winvlose.Text = "WIN";
                }
            }

            if (decision == 3)
            {
                pictureBox5.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                if (randomNumber == decision)
                {
                    winvlose.Text = " Tie ";
                }
                else if (randomNumber == 1)
                {
                    lose = lose + 1;
                    loses_lbl.Text = " Loses: " + lose;
                    winvlose.Text = "LOSE";
                }
                else if (randomNumber == 2)
                {
                    win = win + 1;
                    wins_lbl.Text = " Wins " + win;
                    winvlose.Text = "WIN";
                }
            }
        }

        private void ComputerDisplay(int computerDecision, int userChoice)
        {
            //displays computer choice
           if(computerDecision == 1)
            {
                result_lbl.Text = " The Computer chose Rock ";
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
            }
           else if(computerDecision == 2)
            {
                result_lbl.Text = " The Computer chose Paper ";
                pictureBox4.Visible = true;
                pictureBox3.Visible = false;
                pictureBox6.Visible = false;
            }
           else if(computerDecision == 3)
            {
                result_lbl.Text = " The Computer chose Scissors ";
                pictureBox6.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
        }

    }
}
