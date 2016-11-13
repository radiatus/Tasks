using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task5form10
{
    class Lazy
    {

        static public int[] GetMas(DataGridView data) //чтение файла
        {
            int N = data.RowCount - 1;
            int[] mas = new int[N];

            for (int j = 0; j < N; j++)
            {
                mas[j] = Convert.ToInt32(data[0, j].Value);
            }

            return mas;
        }

        static public int GetMaxLocalMinIndex(int[] mas) //Отбор Лок. мин
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
                    maxLocalMinIndex = i++;
                }
            }
            return maxLocalMinIndex;
        }

    }
}

