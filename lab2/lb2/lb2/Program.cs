using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn, nk;

            Console.Write("Enter start element -> ");

            do
            {
                nn = int.Parse(Console.ReadLine());
                if (nn <= 0)
                {
                    Console.Write("Wrong value! Try again -> ");
                }
            } while (nn <= 0);

            Console.Write("Enter finish element -> ");

            do
            {
                nk = int.Parse(Console.ReadLine());
                if (nk <= nn)
                {
                    Console.Write("Wrong value! Try again -> ");
                }
            } while (nk <= nn);

            double sum = 0;

            for (int i = nn; i <= nk; i++)
            {
                sum += (i * i - 3) / (Math.Pow(-1, i) * i * i + 5);
            }

            Console.WriteLine("Result: {0}", sum);

            Console.ReadKey();
        }
    }
}
