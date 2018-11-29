using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine(" Please enter a number between 1-3. ");

            number = Convert.ToInt32(Console.ReadLine());

            if(number <= 1 && number > 2 && number > 2 && number <= 3)
            {
                Console.WriteLine(" Ha Loser ");
            }
            else if (number == 3)
            {
                Console.WriteLine("Congrats, you win! ");
            }
            else  
            {
                Console.WriteLine(" ERROR 404 ");
            }
            Console.ReadLine();
        }
    }
}
