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
    class Functions
    {
        public static int[,] GetMatrix(string wayToFile)
        {
            string[] rows = File.ReadAllLines(wayToFile).ToArray(); // число строк
            string[] colums = rows[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray(); // число колонок

            int rowCount = rows.Length;
            int columnCount = colums.Length;

            int[,] matrix = new int[rowCount, columnCount];
            try
            {
                for (int countRow = 0; countRow < rowCount; countRow++)
                {
                    int[] row = rows[countRow].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                    for (int countColumn = 0; countColumn < columnCount; countColumn++)
                    {
                        matrix[countRow, countColumn] = row[countColumn];
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Битый файл");
            }
            return matrix;
        }


        public static bool Neighbor(DataGridView matrix, int i, int j)
        {
            int countT = 0;
            int rowCount = matrix.RowCount;
            int columnCount = matrix.ColumnCount;

            for (int ii = i - 1; ii <= i + 1; ii++)
                if (ii >= 0 && ii < rowCount)
                    for (int jj = j - 1; jj <= j + 1; jj++)
                        if (jj >= 0 && jj < columnCount && Convert.ToInt32(matrix[jj, ii].Value) == Convert.ToInt32(matrix[j, i].Value))
                            countT++;
            return countT > 3;
        }
    }
}
