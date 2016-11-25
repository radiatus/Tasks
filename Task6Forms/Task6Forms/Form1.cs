using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ColumnPlus_Click(object sender, EventArgs e)
        {
            FirstMatrix.ColumnCount++;
        }

        private void ColumnMinus_Click(object sender, EventArgs e)
        {
            if(FirstMatrix.ColumnCount > 0)
                FirstMatrix.ColumnCount--;
        }

        private void RowPlus_Click(object sender, EventArgs e)
        {
            FirstMatrix.RowCount++;
        }

        private void RowMinus_Click(object sender, EventArgs e)
        {
            if(FirstMatrix.RowCount > 1)
                FirstMatrix.RowCount--;
        }

        private void RandomMatrix_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int countRow = 0; countRow < FirstMatrix.RowCount; countRow++)
                for (int countColumn = 0; countColumn < FirstMatrix.ColumnCount; countColumn++)
                {
                    FirstMatrix[countColumn, countRow].Value = rnd.Next(0, 9);
                }
        }

        private void LoadMatrix_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int[,] matrixCopy = Functions.GetMatrix(openFileDialog.FileName);
                FirstMatrix.ColumnCount = matrixCopy.GetLength(1);
                FirstMatrix.RowCount = matrixCopy.GetLength(0);

                for (int countColumn = 0; countColumn < FirstMatrix.ColumnCount; countColumn++)
                    for(int countRow = 0; countRow < FirstMatrix.RowCount; countRow++)
                        FirstMatrix[countColumn, countRow].Value = matrixCopy[countRow, countColumn];
            }

        }

        private void FillingSecondMatrix_Click(object sender, EventArgs e)
        {
            SecondMatrix.RowCount = FirstMatrix.RowCount;
            SecondMatrix.ColumnCount = FirstMatrix.ColumnCount;
            try
            {
                for (int countRow = 0; countRow < FirstMatrix.RowCount; countRow++)
                    for (int countCol = 0; countCol < FirstMatrix.ColumnCount; countCol++)
                    {
                        SecondMatrix[countCol, countRow].Value = Functions.Neighbor(FirstMatrix, countRow, countCol) ? 1 : 0;
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
