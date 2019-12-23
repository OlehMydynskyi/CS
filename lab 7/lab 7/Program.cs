using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Reverse (int a)
        {
            Console.Write(a % 10);
            while ((a /= 10) != 0)
                Console.Write(a % 10);
        }

        static void Reverse (string a)
        {
            if (a.IndexOf(",") == -1)
            {
                char[] r = a.ToCharArray();
                Array.Reverse(r);
                Console.WriteLine(r);
            }

            else
            {
                int n = a.IndexOf(",");
                char[] bef = new char[n];


                for (int i = 0; i < n; i++)
                {
                    bef[i] = a[i];
                }

                Array.Reverse(bef);
                Console.Write(bef);
                Console.Write(",");

                int p = a.Length - (n + 1);

                char[] aft = new char[p];
                int k = 0;

                for (int i = n + 1; i < a.Length; i++)
                {
                    aft[k] = a[i];
                    k++;
                }

                Array.Reverse(aft);
                Console.Write(aft);
            }
        }

        static void Reverse (double a)
        {
            int n = (int)a;
            int k = 0;
            int p = n;

            Console.Write(n % 10);
            while ((n /= 10) != 0)
            {
                k++;
                Console.Write(n % 10);
            }

            p = (int)((a - p) * Math.Pow(10, k + 1));


            Console.Write("." + p % 10);
            while ((p /= 10) != 0)
                Console.Write(p % 10);
        }

        static void RecReverse(int a)
        {
            int newNum = a % 10;
            Console.Write(newNum);
            a /= 10;

            if (a > 0)
                Reverse(a);
        }

        static void RecReverse(string a)
        {
            if (a.IndexOf(",") == -1)
            {
                RecStr(a);
            }
            else
            {
                int n = a.IndexOf(",");
                char[] bef = new char[n];


                for (int i = 0; i < n; i++)
                {
                    bef[i] = a[i];
                }

                string str = new string(bef);
                RecStr(str);

                Console.Write(",");

                int p = a.Length - (n + 1);

                char[] aft = new char[p];
                int k = 0;

                for (int i = n + 1; i < a.Length; i++)
                {
                    aft[k] = a[i];
                    k++;
                }

                string str1 = new string(aft);
                RecStr(str1);
            }
        }

        static void RecStr (string a)
        {
            if (a.Length > 0)
                RecStr(a.Substring(1, a.Length - 1));
            else
                return;

            Console.Write(a[0]);
        }
        static void RecReverse(double a)
        {
            int n = (int)a;
            int k = 0;
            int p = n;

            RecReverse(n);

            while ((n /= 10) != 0)
                k++;

            Console.Write(".");
            p = (int)((a - p) * Math.Pow(10, k + 1));
            RecReverse(p);
        }

        static int[] ArrReverse(int[] a)
        {
            int n = a.Length;
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = a[n - (i + 1)];
            }

            return array;
        }
        static void ArrRefReverse(ref int[] a)
        {
            int j = a.Length - 1;

            for (int i = 0; i < j; i++)
            {
                int c = a[j];
                a[j] = a[i];
                a[i] = c;
                j--;
            }
        }


        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.Write(number % 10);
            while ((number /= 10) != 0)
                Console.Write(number % 10);
            Reverse(number);
            RecReverse(number);


            string str = Console.ReadLine();
            char[] r = str.ToCharArray();
            Array.Reverse(r);
            Console.WriteLine(r);
            Reverse(str);
            RecReverse(str);


            double number1 = double.Parse(Console.ReadLine());
            int n = (int)number1;
            int k = 0;
            int p = n;

            Console.Write(n % 10);
            while ((n /= 10) != 0)
            {
                k++;
                Console.Write(n % 10);
            }

            p = (int)((number1 - p) * Math.Pow(10, k + 1));
            Console.Write("." + p % 10);
            while ((p /= 10) != 0)
                Console.Write(p % 10);
            Reverse(number1);
            RecReverse(number1);


            string str1 = Console.ReadLine();
            int num1 = str1.IndexOf(",");
            char[] bef = new char[num1];

            for (int i = 0; i < num1; i++)
            {
                bef[i] = str1[i];
            }

            Array.Reverse(bef);
            Console.Write(bef);
            Console.Write(",");

            int p1 = str1.Length - (num1 + 1);

            char[] aft = new char[p1];
            int k1 = 0;

            for (int i = n + 1; i < str1.Length; i++)
            {
                aft[k1] = str1[i];
                k1++;
            }

            Array.Reverse(aft);
            Console.Write(aft);
            Reverse(str1);

            int num = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < num; i++)
            {
                Console.Write("Aray[{0}] ->" , i);
                array[i] = int.Parse(Console.ReadLine());
            }

            array = ArrReverse(array);
            ArrRefReverse(ref array);
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadKey();
        }
    }
}