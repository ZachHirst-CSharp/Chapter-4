using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AgeInsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string ageString;
            string yesString;
            int yes;

            WriteLine("Please enter your age. ");

            ageString = ReadLine();

            age = Convert.ToInt32(ageString);

            
             if(age < 18)
             {
                WriteLine(" HA You incompitent fool, grow up! ");
             }
             else if(age >= 18 && age < 25)
             {
                WriteLine(" OOOOOOO Someone thinks they're cool caue they can go to the bar... just go home. ");
             }
             else if(age >= 25 && age <32)
            {
                WriteLine("Do you have a job?  ");
                WriteLine("Type 1 for yes and 2 for no ");
                yesString = ReadLine();

                yes = Convert.ToInt32(yesString);

                if(yes == 1 )
                {
                    Write("You're probably a paper pusher. HA!");
                }
                else
                {
                    Write("HA Loser, you cant even get a job flipping burgers?? ");
                }
            }
             else if(age >=32 && age < 42)
            {
                Write("Hey have you hit your midlife crisis yet?");
            }
             else if(age >= 42 && age < 52)
            {
                Write("Soooo hows feeling like you've wasted half of your life like? ");
            }
             else if(age >= 52 && age < 62)
            {
                Write("Are you thinking about how you're gonna be dead soon? ");
            }
             else if(age >= 62)
            {
                Write("GO DIE ALREADY ");
            }
            ReadLine();
        }
    }
}
