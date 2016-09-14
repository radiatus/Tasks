using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {
        static double WriteDouble(string sDouble) 
        { 
            double nDouble;

            while(!Double.TryParse(sDouble, out nDouble))
            {
                sDouble = Console.ReadLine();
            }

            return nDouble;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("(X;Y) и R для первой окружности");
            Console.Write("X = ");
            double xOne = WriteDouble(Console.ReadLine());

            Console.Write("Y = ");
            double yOne = WriteDouble(Console.ReadLine());

            Console.Write("R = ");
            double rOne = WriteDouble(Console.ReadLine());

            Console.WriteLine("(X;Y) и R для второй окружности");
            Console.Write("X = ");
            double xTwo = WriteDouble(Console.ReadLine());

            Console.Write("Y = ");
            double yTwo = WriteDouble(Console.ReadLine());

            Console.Write("R = ");
            double rTwo = WriteDouble(Console.ReadLine());

            double distation = Math.Sqrt((xTwo - xOne) * (xTwo - xOne) + (yTwo - yOne) * (yTwo - yOne));

            if ((distation < rOne + rTwo) && (distation < rOne + rTwo))
            {

            }

            /* 
             * пересекаются в 2-х точках, касаются (1 общая точка) с внешней стороны,
             * касаются (1 общая точка) с внутренней стороны, не пересекаются не вписаны одна в другую,
             * не пересекаются одна окружность вписана в другую
             */


            Console.ReadKey();

        }
    }
}
