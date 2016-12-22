using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClickmaniaFinal
{
    class Game
    {
        private int rowCounts;
        private int columnCounts;
        private int colorsCounts;
        private int rowIndex;
        private int colIndex;
        private int[,] field; //создаем массив кубиков - игровое поле
        private Random rnd = new Random();
        private int index = 0;
        private double scoreColor = 1.2;
        private int score;


        public int this[int rowIndex, int colIndex] { get { return field[rowIndex, colIndex]; } }// индексатор, возращает цвет 
        public int ColorsCount { get { return colorsCounts; } } //гетеры
        public int ColumnsCount { get { return columnCounts; } }
        public int RowsCount { get { return rowCounts; } }
        public int Score { get { return score; } }

        public Game(int rowCounts, int columnCounts, int colorsCounts) // just конструктор
        {
            this.rowCounts = rowCounts;
            this.columnCounts = columnCounts;
            this.colorsCounts = colorsCounts;

            CreateField();
        }

        public bool Click(int colIndex, int rowIndex) // получает индексы нажатия и выясняет строку и колонку 
        {
            this.rowIndex = rowIndex / 25;
            this.colIndex = colIndex / 25;
            if (this.rowIndex < rowCounts && this.colIndex < columnCounts)
            {
                Nieghbor(this.rowIndex, this.colIndex, field[this.rowIndex, this.colIndex]);// костыль
                SorticMatrix();
                FallColumn();
            }
            if (index == 0)
                return false;
            index = 0; // костыль
            return true;
        }
        private void CreateField() // забиваем матрицу рандомными числами 
        {
            field = new int[rowCounts, columnCounts];

            for(int rows = 0; rows < rowCounts; rows++)
                for (int columns = 0; columns < columnCounts; columns++)
                {
                    field[rows, columns] = rnd.Next(1, colorsCounts);
                }
        }

        private void Nieghbor(int rowIndex, int colIndex, int colorClick)// говнокод // | исправить
        {
            int[,] f = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };
            for (int i = 0; i < 4; i++)
            {
                if (rowIndex + f[i, 0] < field.GetLength(0) && rowIndex + f[i, 0] >= 0 && colIndex + f[i, 1] < field.GetLength(1) && colIndex + f[i, 1] >= 0)// | исправить
                    if (field[rowIndex + f[i, 0], colIndex + f[i, 1]] == colorClick && field[rowIndex + f[i, 0], colIndex + f[i, 1]] != 0)// | исправить
                    {
                        field[rowIndex, colIndex] = 0;
                        index++;
                        Nieghbor(rowIndex + f[i, 0], colIndex + f[i, 1], colorClick);
                    }
            }
            if (index == 0)
                return;
            field[rowIndex, colIndex] = 0;
            score += (int)Math.Pow(scoreColor, index); // очки начисляем 
        }

        private bool CheckEnd(int rows, int column)
        {
            int a =  0;
            for (int i = rows; i > 0; i--)
            {
                if (field[i, column] != 0)
                    a++;
            }
            if (a > 0)
                return true;
            else  return false;    
        }
        private void FallColumn()
        {
            for (int cols = 0; cols < columnCounts; cols++)
            {
                int count = 0;
                for (int rows = rowCounts - 1; rows > 0; rows--)
                {
                    if (field[rows, cols] == 0)
                        count++;
                }

                if (count == rowCounts - 1)
                {
                    SorticMatrixColumns(cols);
                }
            }
        }
        private bool CheckEndColumn(int column)
        {
            int a = 0;
            for (int i = column; i < columnCounts; i++)
            {
                if (field[rowCounts-1, i] != 0)
                    a++;
            }
            if (a > 0)
                return true;
            else return false;
        }
        private void SorticMatrixColumns(int cols)
        {
            int count;
            do
            {
                count = 0;
                for (int col = cols; col < columnCounts - 1; col++)
                {
                    for (int rows = rowCounts - 1; rows > -1; rows--)
                    {
                        field[rows, col] = field[rows, col + 1];
                        field[rows, col + 1] = 0;
                    }
                    if (field[rowCounts - 1, col] == 0 && CheckEndColumn(col))
                        count++;
                }
            } while (count > 0);
        }

        private void SorticMatrix()
        {
            for (int cols = 0; cols < columnCounts; cols++)
            {
                int index1;
                do
                {
                    index1 = 0;
                    for (int rows = rowCounts - 1; rows > 0; rows--)
                    {
                        if (field[rows, cols] == 0 && CheckEnd(rows, cols))
                        {
                            index1++;
                        }
                        if (field[rows, cols] == 0)
                        {
                            field[rows, cols] = field[rows - 1, cols];
                            field[rows - 1, cols] = 0;
                        }
                    }
                } while (index1 > 0);
            }
        }
    }
}
