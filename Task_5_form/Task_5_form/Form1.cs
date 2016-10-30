using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Значения"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.ReadOnly = false; //значение в этой колонке нельзя править
            column1.Name = "mas"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            dataGridView1.Columns.Add(column1);
        }

        public int[] GetMas() //чтение файла
        {
            int N = dataGridView1.RowCount - 1;
            int[] mas = new int[N];

            for (int j = 0; j < N; j++)
            {
                mas[j] = Convert.ToInt32(dataGridView1[0, j].Value);
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

        void button1_Click(object sender, EventArgs e)
        {
             int[] mas = GetMas();
             int MaxLocalMinIndex = GetMaxLocalMinIndex(mas);

            textBox1.Text = Convert.ToString(MaxLocalMinIndex);
        }


    }
}
