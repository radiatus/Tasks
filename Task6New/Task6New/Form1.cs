using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task6New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount++;
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            dataGridView1.RowCount--;
        }

        private void deleteColumnButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ColumnCount > 1)
            dataGridView1.ColumnCount--;
        }

        private void addColumnButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount++;
        }
    }
}
