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

            double nDouble;
            while (!Double.TryParse(Console.ReadLine(), out nDouble))
            {
                Console.Write("Введите правильно: ");
            }
            return nDouble;
        }
        static int ReadInt()
        {
            int nInt;
            while (!Int32.TryParse(Console.ReadLine(), out nInt))
            {
                Console.Write("Введите правильно: ");
            }
            return nInt;
        }

        static double Fact(double numb)
        {
            double res = 1;
            for (int i = 1; i < numb; i++)
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

            int i = 1;
            double an = 1;
            double summa = an, summaE = an, summaE10 = an, summaN = an;
            int countE = 0, countE10 = 0;
            do
            {
                i++;

                if (i <= N)
                {
                    summa = summa + an;
                }
                if (Math.Abs(an) > Math.Abs(E))
                {
                    summaE = summaE + an;
                    countE++;
                }
                if (Math.Abs(an) > Math.Abs(E / 10))
                {
                    summaE10 = summaE10 + an;
                    countE10++;
                }
                an = an * Math.Pow(-1, i - 1) * (x * x) / ((2 * i - 2) * (2 * i - 1));
                //an = Math.Pow(-1, i + 1) * Math.Pow(x, 2 * (i - 1)) / Fact(2 * i - 1);
            } while (i <= N || Math.Abs(an) > Math.Abs(E / 10));

            summaN = Math.Sin(x) / x;
            Console.WriteLine("\nСумма N слагаемых = {0}", summa);
            Console.WriteLine("Точное значение суммы N слагаемых  = {0}", summaN);
            Console.WriteLine("Разница между точным значением и суммой N слагаемых = {0}", summaN - summa);

            Console.WriteLine("\nСумма N слагаемых > E = {0}", summaE);
            Console.WriteLine("N слагаемых для E = {0}", countE);
            Console.WriteLine("Разница между точным значением и суммой слагаемых для E = {0}", summaN - summaE);

            Console.WriteLine("\nСумма N слагаемых > E/10 = {0}", summaE10);
            Console.WriteLine("N слагаемых для E/10 = {0}", countE10);
            Console.WriteLine("Разница между точным значением и суммой слагаемых для E/10 = {0}", summaN - summaE10);
            Console.ReadKey();
        }
    }
}
