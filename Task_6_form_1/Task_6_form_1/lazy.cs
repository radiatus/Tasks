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
        public static bool M(DataGridView data, int i, int j)
        {
            int countT = 0;
            
            if (i != 0 && Convert.ToInt32(data[i - 1, j].Value) == Convert.ToInt32(data[i, j].Value))
                countT++;
            if (i != 0 && j != 0 && Convert.ToInt32(data[i - 1, j - 1].Value) == Convert.ToInt32(data[i, j].Value))
                countT++;
            if (j != 0 && Convert.ToInt32(data[i, j - 1].Value) == Convert.ToInt32(data[i, j].Value))
                countT++;
            if (i != Convert.ToInt32(data.RowCount-1) && Convert.ToInt32(data[i + 1, j].Value) == Convert.ToInt32(data[i, j].Value))
                countT++;
            if (j != Convert.ToInt32(data.ColumnCount - 1) && Convert.ToInt32(data[i, j + 1].Value) == Convert.ToInt32(data[i, j].Value))
                countT++;
            if (i != Convert.ToInt32(data.RowCount - 1) && j != Convert.ToInt32(data.ColumnCount - 1) && Convert.ToInt32(data[i + 1, j + 1].Value) == Convert.ToInt32(data[i, j].Value))
                countT++;

            if (countT > 2)
                return true;
            else
                return false;
        }
    }
}
