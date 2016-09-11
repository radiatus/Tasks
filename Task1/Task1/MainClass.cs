using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class MainClass
    {
        static double a, b, c, d, e, f, delta;

        static double WriteDouble(String sDouble)
        {
            double nDouble;

            while (!Double.TryParse(sDouble, out nDouble))
            {
                Console.Write("Вы ввели не правильное число, попробуйте снова: ");
                sDouble = Console.ReadLine();
            }

            return nDouble;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nРешение системы линейных уравнений ax + by = c и dx + ey = f");
            Console.WriteLine("Введите значения a, b, c для уравнения ax + by = c");

            Console.Write("a = ");
            a = WriteDouble(Console.ReadLine());

            Console.Write("b = ");
            b = WriteDouble(Console.ReadLine());

            Console.Write("c = ");
            c = WriteDouble(Console.ReadLine());

            Console.WriteLine("Введите значения d, e, f для уравнения dx + ey = f");

            Console.Write("d = ");
            d = WriteDouble(Console.ReadLine());

            Console.Write("e = ");
            e = WriteDouble(Console.ReadLine());

            Console.Write("f = ");
            f = WriteDouble(Console.ReadLine());

            delta = a * e - b * d;
            if (delta == 0)
            {
                Console.WriteLine("Система не имеет решения");
               // Main(null);
            }

            Console.WriteLine("Решением системы уравнений являются x = {0} и y = {1}", (c * e - b * f) / delta, (a * f - c * d) / delta);

            Console.ReadKey();
        }
    }
}
