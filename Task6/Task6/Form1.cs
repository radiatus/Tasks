using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        private int matrixSize;
        private int indexVer;
        private int indexHor;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            matrixSize = Convert.ToInt32(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            indexVer = Convert.ToInt32(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            indexHor = Convert.ToInt32(textBox6.Text);
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            int[,] matrix = new int[matrixSize, matrixSize]; 

            for(int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = 1;
                    richTextBox1.Text += matrix[i, j].ToString() + "\r\n";
                }
            }
        }
    }
}
