using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.80665;
            const double pi = Math.PI;

            int l;
            Console.Write("Enter the length of the pendulum (in meters) -> ");
            do
            {
                l = int.Parse(Console.ReadLine());
                if (l <= 0)
                {
                    Console.Write("Wrong value! Try again -> ");
                }
            } while (l <= 0);
            

            double T = 2 * pi * Math.Sqrt(l / g);

            Console.WriteLine("Pendulum oscillation period: {0}s", T);

            Console.ReadKey();
        }
    }
}
