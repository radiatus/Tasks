using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static double ReadDouble()
        {
            string sDouble = Console.ReadLine();
            double nDouble;

            while (!Double.TryParse(sDouble, out nDouble))
            {
                Console.Write("Введите правильно: ");
                sDouble = Console.ReadLine();
            }

            return nDouble;
        }
        static int ReadInt()
        {
            string sDouble = Console.ReadLine();
            int nDouble;

            while (!Int32.TryParse(sDouble, out nDouble))
            {
                Console.Write("Введите правильно: ");
                sDouble = Console.ReadLine();
            }

            return nDouble;
        }

        static int factorial(int numb)
        {
            int res = 1;
            for (int i = numb; i > 1; i--)
                res *= i;
            return res;
        }

        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = ReadDouble();
            Console.Write("N = ");
            int N = ReadInt();
            Console.Write("E = ");
            double E = ReadDouble();

            double summa = 0;
            for (int i = 1;i<N;i++)
            {
                double an = Math.Pow(x,2*(N-1))/factorial(2*N-1); // проблема со знаком
                summa = summa - an;
                Console.WriteLine(summa);
            }
            Console.ReadKey();
        }
    }
}
