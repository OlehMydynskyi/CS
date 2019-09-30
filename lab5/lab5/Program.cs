using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;

            Console.Write("Введiть розмiр масиву -> ");

            do
            {
                m = int.Parse(Console.ReadLine());
                if (m <= 0)
                {
                    Console.Write("Невiрні даннi! Спробуйте ще -> ");
                }
            } while (m <= 0);

            int[,] arr = new int[m,m];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = 1;
                }
            }

            int a;
            Console.WriteLine();
            Console.WriteLine("Список функцiй:\n1.Замiна нулями елементiв, що лежать вижче головноi дiагоналi.\n2.Замiна нулями елементiв, що лежать нижче головноi дiагоналi.\n3.Замiна нулями елементiв, що лежать вижче побiчноi дiагоналi.\n4.Замiна нулями елементiв, що лежать нижче побiчноi дiагоналi.\n");
            Console.Write("Введiть цифру щоб виконати дiю -> ");

            do
            {
                a = int.Parse(Console.ReadLine());
                if (a <= 0 && a >= 5)
                {
                    Console.Write("Невiрні даннi! Спробуйте ще -> ");
                }
            } while (a <= 0 && a >= 5);

            switch (a)
            {
                case (1):
                    {
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = i + 1; j < m; j++)
                            {
                                arr[i, j] = 0;
                            }
                        }
                        break;
                    }
                case (2):
                    {
                        for (int i = 1; i < m; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                arr[i, j] = 0;
                            }
                        }
                        break;
                    }
                case (3):
                    {
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < m - (i + 1); j++)
                            {
                                arr[i, j] = 0;
                            }
                        }
                        break;
                    }
                case (4):
                    {
                        for (int i = 1; i < m; i++)
                        {
                            for (int j = m - 1; j > m - (i + 1); j--)
                            {
                                arr[i, j] = 0;
                            }
                        }
                        break;
                    }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        
    }
}
