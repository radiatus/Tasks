using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Form
{
    class lazy
    {


        static int[] GetMas(string WayToFale) //чтение файла
        {
            StreamReader reader = new StreamReader(WayToFale, Encoding.Default);
            int N = Convert.ToInt32(reader.ReadLine());
            string[] split = reader.ReadLine().Split(new Char[] { ' ', ',' });
            int[] mas = new int[N];

            int j = 0;
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    mas[j] = Convert.ToInt32(s);
                    j++;
                }
            }
            return mas;
        }


        static int GetMaxLocalMinIndex(int[] mas) //Отбор Лок. мин
        {
            int maxLocalMin = 0;
            int maxLocalMinIndex = -1;
            for (int i = 1; i < mas.Length - 1; i++)
            {
                if (mas[i] < mas[i + 1] && mas[i] < mas[i - 1] &&
                    (maxLocalMinIndex == -1 || mas[i] > maxLocalMin))
                {
                    Console.WriteLine(mas[i]);

                    maxLocalMin = mas[i];
                    maxLocalMinIndex = i;
                }
            }
            return maxLocalMinIndex;
        }


        static void Main(string[] args)
        {
            try
            {
                int[] mas = GetMas(Console.ReadLine());
                int MaxLocalMinIndex = GetMaxLocalMinIndex(mas);

                Console.Write("Максимальный из локальных минимумов: {0}", MaxLocalMinIndex);
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
