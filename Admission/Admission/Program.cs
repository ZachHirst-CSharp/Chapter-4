using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double highschoolGPA;
            double admissiontestscore;

            WriteLine("Please enter your High School GPA.");
            highschoolGPA = Convert.ToDouble(ReadLine());
            WriteLine("Now enter your Admissions Test Score for calculation. ");
            admissiontestscore = Convert.ToDouble(ReadLine());

            if(highschoolGPA >= 3.0)
            {
                if(admissiontestscore >= 60)
                {
                    WriteLine("Congratulations you're admitted!");
                }
                else
                {
                    WriteLine("I'm sorry your application has been rejected. ");
                }
            }
            else if(highschoolGPA < 3.0)
            {
                if(admissiontestscore >= 80)
                {
                    WriteLine("Congratulations you're admitted!");
                }
                else
                {
                    WriteLine("I'm sorry your application has been rejected. ");
                }
            }
            ReadKey();
        }
    }
}
