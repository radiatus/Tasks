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
        static int[] GetMas(int n, int[] mas, StreamReader reader) //чтение файла
        {
                string[] split = reader.ReadLine().Split(new Char[] { ' ', ',' });

                uint j = 0;
                foreach (string s in split) // Цикл разбиения на числа
                {
                    if (s.Trim() != "")
                    {
                        mas[j] = Convert.ToInt32(s);
                        j++;
                    }
                }
                return mas;
            
        }

        static int GetMaxLocalMinIndex(int[] mas, int n) //Отбор Лок. мин
        {
            int count = 0;
            int MaxLocalMin = -1;
            for (uint i = 1; i < n; i++) // Цикл на Локальные мин.
            {
                if (i == mas.LongLength - 1)
                    break;

                if ((mas[i] < mas[i + 1]) && (mas[i] < mas[i - 1]))
                {
                    if (mas[i] > MaxLocalMin)
                    {
                        MaxLocalMin = mas[i];
                    }
                    count++;
                }
            }
            return MaxLocalMin;
        } //-1

        static void Main(string[] args)
        {
            try
            {

                Console.Write("Путь к *.txt файлу: ");

                StreamReader reader = new StreamReader(Console.ReadLine(), Encoding.Default);
                int N = Convert.ToInt32(reader.ReadLine());
                int[] mas = new int[N];
                int MaxLocalMin = 0;

                mas = GetMas(N, mas, reader);

                MaxLocalMin = GetMaxLocalMinIndex(mas, N);

                Console.Write("Максимальный из локальных минимумов: {0}", MaxLocalMin);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.Write("Не верный путь или битый файл");
                Console.ReadKey();
            }
            
        }
    }
}
