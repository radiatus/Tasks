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
            matrixOne.ColumnCount++;
        }

        private void ColumnMinus_Click(object sender, EventArgs e)
        {
            if(matrixOne.ColumnCount > 0)
                matrixOne.ColumnCount--;

        }

        private void RowMinus_Click(object sender, EventArgs e)
        {
            if (matrixOne.RowCount > 1)
                matrixOne.RowCount--;
        }

        private void RowPlus_Click(object sender, EventArgs e)
        {
            matrixOne.RowCount++;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            matrixOne.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex).ToString();
        }

        private void RandToMarix_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int countRow = 0; countRow < matrixOne.RowCount; countRow++)
                for (int countCol = 0; countCol < matrixOne.ColumnCount; countCol++)
                {
                    matrixOne[countCol, countRow].Value = rnd.Next(0, 2);
                }
        }

        private void TwoMatrix_Click(object sender, EventArgs e)
        {
            matrixTwo.RowCount = matrixOne.RowCount;
            matrixTwo.ColumnCount = matrixOne.ColumnCount;

            for (int countRow = 0; countRow < matrixOne.RowCount; countRow++)
                for (int countCol = 0; countCol < matrixOne.ColumnCount; countCol++)
                {
                    if (lazy.Neighbor(matrixOne, countRow, countCol))
                        matrixTwo[countCol, countRow].Value = 1;
                    else
                        matrixTwo[countCol, countRow].Value = 0;
                }
        }

        private void dataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            matrixTwo.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex).ToString();
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            matrixOne.Columns[e.Column.Index].HeaderCell.Value = (e.Column.Index).ToString();
        }

        private void dataGridView2_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            matrixTwo.Columns[e.Column.Index].HeaderCell.Value = (e.Column.Index).ToString();
        }
    }
}
