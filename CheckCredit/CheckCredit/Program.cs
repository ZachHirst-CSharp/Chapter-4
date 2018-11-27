using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            double purchaseprice;

            WriteLine("Please enter the amount you spent on that item you purchased. ");
            purchaseprice = Convert.ToDouble(ReadLine());

            if(purchaseprice > 5000)
            {
                WriteLine("ERROR 404");
                WriteLine("This ammount exceeds your credit limit ");
            }
            else
            {
                WriteLine("I hope you enjoy your item");
                ReadLine();
            }
        }
    }
}
