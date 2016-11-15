using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6_form_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ColumnPlus_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount++;
        }

        private void ColumnMinus_Click(object sender, EventArgs e)
        {
            if(dataGridView1.ColumnCount > 0)
                dataGridView1.ColumnCount--;

        }

        private void RowMinus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
                dataGridView1.RowCount--;
        }

        private void RowPlus_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount++;
        }

        private void RandToMarix_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int countRow = 0; countRow < dataGridView1.RowCount; countRow++)
                for (int countCol = 0; countCol < dataGridView1.ColumnCount; countCol++)
                {
                    dataGridView1[countCol, countRow].Value = rnd.Next(0, 50);
                }
        }

        private void TwoMatrix_Click(object sender, EventArgs e)
        {
            dataGridView2.RowCount = dataGridView1.RowCount;
            dataGridView2.ColumnCount = dataGridView1.ColumnCount;

            int Row = Convert.ToInt32(GetRow.Text);
            int Column = Convert.ToInt32(GetColumn.Text);
            for (int countRow = 0; countRow < dataGridView1.RowCount; countRow++)
                for (int countCol = 0; countCol < dataGridView1.ColumnCount; countCol++)
                {
                    if (countRow == Row && countCol == Column && lazy.M(dataGridView1, Row, Column))
                        dataGridView2[countCol, countRow].Value = 1;
                    else
                        dataGridView2[countCol, countRow].Value = 0;
                }
        }
    }
}
