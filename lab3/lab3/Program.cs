using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //16. Перевірити істинність вислову: "Цифри даного тризначного числа утворюють геометричну прогресію".
            int n;

            Console.Write("Enter your number -> ");
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n <= 99)
                {
                    Console.Write("Wrong value! Try again -> ");
                }
            } while (n <= 99);

            int[] arr = new int [3];

            arr[0] = n / 100;
            arr[1] = n / 10 - arr[0] * 10;
            arr[2] = n - arr[0] * 100 - arr[1] * 10;

            if (arr[2] / arr[1] == arr[1] / arr[0])
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();
        }
    }
}
