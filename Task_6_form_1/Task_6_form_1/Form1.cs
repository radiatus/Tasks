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
    }
}
