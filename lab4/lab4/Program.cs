using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //16. Даний масив розміру N. Визначити кількість його проміжків монотонності(інтервалів індексів, для яких його елементи монотонно зростають(спадають)).
            
            int n;

            Console.Write("Enter the size of the array  -> ");
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.Write("Wrong value! Try again -> ");
                }
            } while (n <= 0);

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter item #{0}  -> ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int k = Math.Abs(arr[0] - arr[1]) , result = 0;
            bool f = true;

            for (int i = 1; i < n - 1; i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) == k && f)
                {
                    result++;
                    f = false;
                }
                else
                {
                    k = Math.Abs(arr[i] - arr[i + 1]);
                    f = true;
                }
            }

            Console.WriteLine("Result: {0}", result);
            Console.ReadKey();  
        }
    }
}
