using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {
        static double WriteDouble() 
        { 
            double nDouble;
            string sDouble = Console.ReadLine();

            while (!Double.TryParse(sDouble, out nDouble))
            {
                sDouble = Console.ReadLine();
            }

            return nDouble;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("(X;Y) и R для первой окружности");
            Console.Write("X = ");
            double xOne = WriteDouble();

            Console.Write("Y = ");
            double yOne = WriteDouble();

            Console.Write("R = ");
            double rOne = WriteDouble();

            Console.WriteLine("(X;Y) и R для второй окружности");
            Console.Write("X = ");
            double xTwo = WriteDouble();

            Console.Write("Y = ");
            double yTwo = WriteDouble();

            Console.Write("R = ");
            double rTwo = WriteDouble();

            double distation = Math.Sqrt((xTwo - xOne) * (xTwo - xOne) + (yTwo - yOne) * (yTwo - yOne));

            if (rOne < rTwo) 
            {
                double rTrans = rTwo;
                rTwo = rOne;
                rOne = rTrans;
            }

            double rPlus = rOne + rTwo;
            double rMenus = rOne - rTwo;

            if (distation == rPlus) 
            {
                Console.WriteLine("Касаются с внешней стороны");
            }
            else if ((distation == rMenus)) 
            {
                Console.WriteLine("Касаются с внутренней стороной");
            }
            else if (distation > rPlus) 
            {
                Console.WriteLine("Не пересекаются, не вписаны");
            }
            else if ((distation < rPlus) && (distation > rMenus))
            {
                Console.WriteLine("пересекаются в 2-х точках");
            }
            else
            {
                Console.WriteLine("одна окружность вписана в другую");
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
