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

        static void ReadTXT()
        {
            try
            {
             Console.Write("Путь к *.txt файлу: ");

             StreamReader reader = new StreamReader(Console.ReadLine(), Encoding.Default);
             N = Convert.ToUInt32(reader.ReadLine());
             Array.Resize(ref mas, Convert.ToInt32(N));
             string[] split = reader.ReadLine().Split(new Char[] { ' ', ',' });

             uint j = 0;
             foreach (string s in split) // Цикл разбиения на числа
             {
              if (s.Trim() != "")
               {
                mas[j] = Convert.ToUInt32(s);
                j++;
               }
             }
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Неверный путь к файлу.");
                ReadTXT();
            }
            
        }
        static void Main(string[] args)
        {
            ReadTXT();
            
            uint count = 0;
            uint[] masMin = new uint[N]; 
            for (uint i = 1; i < N; i++) // Цикл на Локальные мин.
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
