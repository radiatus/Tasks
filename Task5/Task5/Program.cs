using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//9.	Дан массив размера N. Найти максимальный из его локальных минимумов

namespace Task5
{
    class Program
    {
        private static uint N;
        private static uint[] mas = new uint[N];

        static void ReadTxt(string way)
        {
            StreamReader reader = new StreamReader(way, Encoding.Default);
            N = Convert.ToUInt32(reader.ReadLine());
            string[] split = reader.ReadLine().Split(new Char[] { ' ', ',' });
            
            uint j = 0;
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    mas[j] = UInt32.Parse(s);
                    j++;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Путь к *.txt файлу: ");
            string way = Console.ReadLine();
            
            ReadTxt(way);
            
            uint count = 0;
            uint[] masMin = new uint[N];
            for (uint i = 1; i < N; i++)
            {
                if (i == mas.LongLength - 1)
                    break;
               
                if ((mas[i] < mas[i + 1]) && (mas[i] < mas[i - 1]))
                {
                    masMin[count] = mas[i];
                    count++;
                }
            }

            Array.Sort(masMin);
            Console.Write("Максимальный из локальных минимумов: {0}", masMin[masMin.Length - 1]);
            Console.ReadKey();
        }
    }
}
