using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task5form10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          /*  DataGridViewColumn column1 = new DataGridViewColumn();
            column1.HeaderText = "Значения"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.ReadOnly = false; //значение в этой колонке нельзя править
            column1.Name = "mas"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
           dataGridView1.Columns.Add(column1); */
        }

        void button1_Click(object sender, EventArgs e)
        {
            int[] mas = Lazy.GetMas(massive);
            int MaxLocalMinIndex = Lazy.GetMaxLocalMinIndex(mas);

            textBox1.Text = Convert.ToString(MaxLocalMinIndex);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            massive.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex).ToString();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
        }
    }
}
