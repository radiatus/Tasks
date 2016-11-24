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
        public static bool Neighbor(DataGridView data, int row, int column)
        {
            int countT = 0;
            int rowCount = 5;
            int columnCount = 5;

            for (int ii = row - 1; ii <= row + 1; ii++)
                if (ii >= 0 && ii < rowCount)
                    for (int jj = column - 1; jj <= column + 1; jj++)
                        if (jj >= 0 && jj < columnCount && Convert.ToInt32(data[ii, jj].Value) == Convert.ToInt32(data[row, column].Value))
                            countT++;

            if (countT > 3)
                return true;
            else
                return false;
        }
    }
}
