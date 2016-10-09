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
        static uint ReadUint()
        {
            uint nUint;
            while (!UInt32.TryParse(Console.ReadLine(), out nUint))
            {
                Console.Write("Введите правильно: ");
            }
            return nUint;
        }

          static int Rand(Random rng)
          {
              return rng.Next(100);
          }
        

        static void Main(string[] args)
        {
            Console.Write("Путь к *.txt файлу: ");
            string disk = Console.ReadLine();
            Console.Write("Длина массива: ");
            uint N = ReadUint();
            uint[] mas = new uint[N];
            uint[] masM = new uint[N];
            string[] masS = new string[N];
            string a = "";
            Random rng = new Random();

            for (uint i = 0; i < N; i++)
            {
                a = a + Convert.ToString(Rand(rng)) + " ";
            }

            File.WriteAllText(disk, a, Encoding.Default);

            StreamReader reader = new StreamReader(disk, Encoding.Default);

            string[] split = reader.ReadLine().Split(new Char[] { ' ', ',', '.', ':', '\t' });

            uint j = 0;
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    mas[j] = UInt32.Parse(s);
                    j++;
                }
            }
            
            uint count = 0;
            for (uint i = 0; i < N; i++)
            {
                if (i == mas.LongLength - 1)
                    break;
                else if (i == 0)
                    continue;
               
                if ((mas[i] < mas[i+1])&&(mas[i] < mas[i - 1]))
                {
                    masM[count] = mas[i];
                    count++;
                }
            }
            Array.Sort(masM);
            Console.Write("Максимальный из локальных минимумов: {0}", masM[masM.Length - 1]);
            Console.ReadKey();
        }
    }
}
