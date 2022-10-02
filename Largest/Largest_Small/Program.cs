using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Small
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter user three numbers");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int c=Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"{a}a is the largest number");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"{b} is the largest number");
            }
            else
            {
                Console.WriteLine($"{c} is the largest number");
            }
            Console.ReadLine();
                            

        }
    }
}
