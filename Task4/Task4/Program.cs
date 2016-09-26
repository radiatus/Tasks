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

        static double fact(double numb)
        {
            double res = 1;
            for (double i = numb; i > 1; i--)
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
            double summaE = 0;
            double summaE10 = 0;
            for (double i = 1;i<=N;i++)
            {
                double an = Math.Pow(-1.00,i)*Math.Pow(x,2*(i-1))/fact(2*i-1);
                double an2 = 0;
                if (i % 2 == 0)
                {
                    an2 = -an;
                    summa = summa + an2;
                }
                else
                {
                    summa = summa + an;
                }

                if (an > E)
                    summaE = summaE + an;

                if (an > E/10)
                    summaE10 = summaE10 + an;
            }
            Console.WriteLine("Сумма N слагаемых = {0:0.0000}", summa);
            Console.WriteLine("Сумма N слагаемых > E = {0:0.0000}", summaE);
            Console.WriteLine("Сумма N слагаемых > E/10 = {0:0.0000}", summaE10);
            Console.ReadKey();
        }
    }
}
