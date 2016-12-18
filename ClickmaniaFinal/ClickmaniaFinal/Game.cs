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
        private int index = 0, index1 = 0;
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
              //  FallColumn();
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

        private void Nieghbor(int rowIndex, int colIndex, int colorClick)// говнокод
        {
            if (rowIndex > 0)
            if (field[rowIndex - 1, colIndex] == colorClick && field[rowIndex - 1, colIndex] != 0)
            {
                field[rowIndex, colIndex] = 0;
                index++;
                Nieghbor(rowIndex - 1, colIndex, colorClick);
            }
                if(rowIndex < field.GetLength(0) - 1)
                if (field[rowIndex + 1, colIndex] == colorClick && field[rowIndex + 1, colIndex] != 0)
            {
                field[rowIndex, colIndex] = 0;
                index++;
                Nieghbor(rowIndex + 1, colIndex, colorClick);
            }
                if(colIndex > 0)
                if (field[rowIndex, colIndex - 1] == colorClick && field[rowIndex, colIndex - 1] != 0)
            {
                field[rowIndex, colIndex] = 0;
                index++;
                Nieghbor(rowIndex, colIndex - 1, colorClick);
            }
                if(colIndex < field.GetLength(1) - 1)
                if (field[rowIndex, colIndex + 1] == colorClick && field[rowIndex, colIndex + 1] != 0)
            {
                field[rowIndex, colIndex] = 0;
                index++;
                Nieghbor(rowIndex, colIndex + 1, colorClick);
            }
            if (index == 0)
                return;
            field[rowIndex, colIndex] = 0;
            score += (int)Math.Pow(scoreColor, index + 1); // очки начисляем 
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
        private void SorticMatrix()
        {
            for (int cols = 0; cols < columnCounts; cols++)
            {
                do
                {
                    index1 = 0;
                    for (int rows = rowCounts - 1; rows > 0; rows--)
                    {
                        if (field[rows, cols] == 0 && field[rows - 1, cols] == 0 && CheckEnd(rows, cols))
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
