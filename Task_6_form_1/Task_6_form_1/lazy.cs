using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6_form_1
{
    class lazy
    {
        public static bool M(DataGridView data, int row, int column) // Дописать для [i-1,j+1]
        {
            int countT = 0;
            
            if (column != 0 && row != 0 && Convert.ToInt32(data[column - 1, row - 1].Value) == Convert.ToInt32(data[column, row].Value))
                countT++;
            if (column != 0 && Convert.ToInt32(data[column - 1, row].Value) == Convert.ToInt32(data[column, row].Value))
                countT++;
            if (column != 0 && row != data.RowCount - 1 && row != 0 && Convert.ToInt32(data[column - 1, row + 1].Value) == Convert.ToInt32(data[column, row].Value))
                countT++;
            if (row != 0 && Convert.ToInt32(data[column, row - 1].Value) == Convert.ToInt32(data[column, row].Value))
                countT++;
            if (row != data.RowCount - 1 && Convert.ToInt32(data[column, row + 1].Value) == Convert.ToInt32(data[column, row].Value))
                countT++;
            if (column != data.ColumnCount - 1 && row != 0 && Convert.ToInt32(data[column + 1, row - 1].Value) == Convert.ToInt32(data[column, row].Value))
                countT++;
            if (column != data.ColumnCount - 1 && Convert.ToInt32(data[column + 1, row].Value) == Convert.ToInt32(data[column, row].Value))
                countT++;
            if (column != data.RowCount - 1 && row != data.ColumnCount - 1 && Convert.ToInt32(data[column + 1, row + 1].Value) == Convert.ToInt32(data[column, row].Value))
                countT++;

            if (countT > 2)
                return true;
            else
                return false;
        }
    }
}
