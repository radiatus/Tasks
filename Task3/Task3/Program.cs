using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            for (a = 1;a<100;a++)
            {
                for (b = 1;b<20;b++)
                {
                    for (c = 1;c<20;c++)
                    {
                        if ((a*a + b*b == c*c))
                        {
                            Console.WriteLine("{0} {1} {2}",a,b,c);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }

    //6.	Составить программу для нахождения и печати всех пифагоровых чисел, не превышающих 20.
}
