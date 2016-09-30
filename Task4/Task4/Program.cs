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
            double summaN = 0;
            int countE = 0;
            int countE10 = 0;
            for (int i = 1; i <= N; i++)
            {
                double an = Math.Pow(-1, i + 1) * Math.Pow(x, 2 * (i - 1)) / fact(2 * i - 1);

                summa = summa + an;

                if (Math.Abs(an) > E)
                {
                    summaE = summaE + an;
                    countE++;
                }

                if (an > E / 10)
                {
                    summaE10 = summaE10 + an;
                    countE10++;
                }

                summaN = Math.Sin(x) / x;

            }
            Console.WriteLine("\nСумма N слагаемых = {0:0.0000}", summa);
            Console.WriteLine("Точное значение суммы N слагаемых  = {0:0.0000}", summaN);
            Console.WriteLine("Разница между точным значением и суммой N слагаемых = {0:0.0000}", summaN - summa);

            Console.WriteLine("\nСумма N слагаемых > E = {0:0.0000}", summaE);
            Console.WriteLine("N слагаемых для E = {0:0.0000}", countE);
            Console.WriteLine("Разница между точным значением и суммой слагаемых для E = {0:0.0000}", summaN - summaE);

            Console.WriteLine("\nСумма N слагаемых > E/10 = {0:0.0000}", summaE10);
            Console.WriteLine("N слагаемых для E/10 = {0:0.0000}", countE10);
            Console.WriteLine("Разница между точным значением и суммой слагаемых для E/10 = {0:0.0000}", summaN - summaE10);
            Console.ReadKey();
        }
    }
}
