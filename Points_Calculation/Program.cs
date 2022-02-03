using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points_Calculation
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount >= 50 && amount < 100)
            {
                 int points1= (amount - 50);
                Console.WriteLine("Total points " + points1);
            }
            else if (amount >= 100)
            {
                 int points2 = (2 * (amount - 100) +50);
                Console.WriteLine("Total points " + points2);
            }
            Console.ReadLine();

        }
    }
}
