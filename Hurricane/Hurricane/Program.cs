using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            int windspeed;

            WriteLine("Please enter the wind speed of supposed hurricane");
            windspeed = Convert.ToInt32(ReadLine());

            if(windspeed < 74)
            {
                WriteLine("The storm you are experincing is not a hurricane. ");
            }
            else if(windspeed >= 74 && windspeed < 96)
            {
                WriteLine("This is a catagory 1 hurricane. ");
            }
            else if(windspeed >= 96 && windspeed < 111)
            {
                WriteLine("This is a catagory 2 hurricane. ");
            }
            else if(windspeed >= 111 && windspeed < 130)
            {
                WriteLine("This is a catagory 3 hurricane. ");
            }
            else if(windspeed >= 130 && windspeed < 157)
            {
                WriteLine("This is a catagory 4 hurricane. ");
            }
            else if(windspeed >= 157)
            {
                WriteLine("This is a catagory 5 hurricane. ");
            }
            ReadKey();13
        }
    }
}
