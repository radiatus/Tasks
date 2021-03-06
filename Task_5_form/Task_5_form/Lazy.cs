﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_form
{
   class Lazy
    {
        
        static public int[] GetMas() //чтение файла
        {
            int N = Form1.dataGridView1.RowCount - 1;
            int[] mas = new int[N];

            for (int j = 0; j < N; j++)
            {
                mas[j] = Convert.ToInt32(Form1.dataGridView1[0, j].Value);
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
                    maxLocalMinIndex = i;
                }
            }
            return maxLocalMinIndex;
        }

    }
}

      