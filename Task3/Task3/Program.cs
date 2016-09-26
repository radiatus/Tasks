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
            int a, b, c,temp=0;

            int[,] massive = new int[20,2];
            int[,] massive2 = new int[20, 2];

            for (a = 1;a<20;a++)
            {
                for (b = 1;b<20;b++)
                {
                    for (c = 1;c<20;c++)
                    {
                        if ((a*a + b*b == c*c))
                        {
                            //Console.WriteLine("{0} {1} {2}",a,b,c);
                            temp++;
                            massive[temp - 1, 0] = a;
                            massive[temp - 1, 1] = b;

                        }
                    }
                }
            }
            int w=0, e=0, r=0, t=0;
            while (w<20)
            {

                massive[ w, 0] == ;
                massive[ w, 1] == ;

                w++;
            }

            Console.ReadKey();
        }
    }

    //6.	Составить программу для нахождения и печати всех пифагоровых чисел, не превышающих 20.
}
