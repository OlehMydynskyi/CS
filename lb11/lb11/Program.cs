using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11
{
    class Program
    {
        delegate void Operation();

        class Products
        {
            public bool getsize;
            public bool cut;
            public bool sharpen;
            public bool cutthethread;
            public bool drill;
            public bool paint;
            public bool test;
            public bool packup;

            public void Print ()
            {
                Console.WriteLine("Your result:");
                Console.WriteLine("Get size: " + getsize);
                Console.WriteLine("Cut: " + cut);
                Console.WriteLine("Sharpen: " + sharpen);
                Console.WriteLine("Cut the thread: " + cutthethread);
                Console.WriteLine("Drill: " + drill);
                Console.WriteLine("Paint: " + paint);
                Console.WriteLine("Test: " + test);
                Console.WriteLine("Pack up: " + packup);
            }
        }
        class Сonveyor : Products
        {
            public void GetSize()
            {
                getsize = true;
            }

            public void Cut()
            {
                cut = true;
            }
            public void Sharpen()
            {
                sharpen = true;
            }
            public void CutTheThread()
            {
                cutthethread = true;
            }
            public void Drill()
            {
                drill = true;
            }
            public void Paint()
            {
                paint = true;
            }
            public void Test()
            {
                test = true;
            }
            public void PackUp()
            {
                packup = true;
            }
        }

        static bool Check(string name)
        {
            Console.Write(name);
            while(true)
            {
                string r = Console.ReadLine();
                if (r == "1")
                {
                    return true;
                }
                else if (r == "0")
                {
                    return false;
                }

                Console.Write("Incorrect value (0 or 1). Try Again: ");
            }
            
        }
        static void Main(string[] args)
        {
            Сonveyor item1 = new Сonveyor();

            Operation work = null;
            Operation _getsize = item1.GetSize;
            Operation _cut = item1.Cut;
            Operation _sharpen = item1.Sharpen;
            Operation _cutthethred = item1.CutTheThread;
            Operation _drill = item1.Drill;
            Operation _paint = item1.Paint;
            Operation _test = item1.Test;
            Operation _packup = item1.PackUp;


            if (Check("Get size: "))
            {
                work += _getsize;
            }

            if (Check("Cut: "))
            {
                work += _cut;
            }

            if (Check("Sharpen: "))
            {
                work += _sharpen;
            }

            if (Check("Cut the thred: "))
            {
                work += _cutthethred;
            }

            if (Check("Drill: "))
            {
                work += _drill;
            }

            if (Check("Paint: "))
            {
                work += _paint;
            }

            if (Check("Test: "))
            {
                work += _test;
            }

            if (Check("Pack up: "))
            {
                work += _packup;
            }

            work();

            Console.WriteLine();

            item1.Print();

            Console.ReadKey();
        }

        

       
    }
}
