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
        private static uint[] masLocMin = new uint[N];

        static void ReadTXT() //чтение файла
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

        static void LocalMinSort() //Отбор Лок. мин
        {
            uint count = 0;
            uint[] masLocMin = new uint[N];
            for (uint i = 1; i < N; i++) // Цикл на Локальные мин.
            {
                if (i == mas.LongLength - 1)
                    break;

                if ((mas[i] < mas[i + 1]) && (mas[i] < mas[i - 1]))
                {
                    masLocMin[count] = mas[i];
                    count++;
                }
            }
        }

        static void Main(string[] args)
        {
            ReadTXT();
            LocalMinSort();
            
            Array.Sort(masLocMin);
            Console.Write("Максимальный из локальных минимумов: {0}", masLocMin[masLocMin.Length - 1]);
            Console.ReadKey();
        }
    }
}
