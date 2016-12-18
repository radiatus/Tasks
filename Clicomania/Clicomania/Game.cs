using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace clickmania
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

        public Game(int rowCounts, int columnCounts, int colorsCounts) // just конструктор
        {
            this.rowCounts = rowCounts;
            this.columnCounts = columnCounts;
            this.colorsCounts = colorsCounts;

            CreateField();
        }

        private void CreateField() 
        {
            field = new int[rowCounts, columnCounts];

            for(int rows = 0; rows < rowCounts; rows++)
                for (int columns = 0; columns < columnCounts; columns++)
                {
                    field[rows, columns] = rnd.Next(1, colorsCounts);
                }
        }

        public int this[int rowIndex, int colIndex]
        {
            get {
                return field[rowIndex, colIndex];
            }
        }

        //public Cubs[,] FieldCubs
        //{
        //    set { field = value; }
        //    get { return field; }
        //}

        public int ColorsCount { get { return colorsCounts; } }
        public int ColumnsCount { get { return columnCounts; } }
        public int RowsCount { get { return rowCounts; } }

       //  public int this[int rowIndex, int colIndex] 
       //  {
       //      get { return ;}
       //  } 


        //public int Score { get; }


       // public bool Finish { get; }
        
        //private void Nieghbor(int rowClick, int columnClick)
        //{
        //    if(field[rowClick-1, columnClick].Colour == field[rowClick, columnClick].Colour)
        //    {
        //        Nieghbor(rowClick - 1, columnClick);
        //    }
        //    if (field[rowClick + 1 , columnClick].Colour == field[rowClick, columnClick].Colour)
        //    {
        //        Nieghbor(rowClick + 1, columnClick);
        //    }
        //    if (field[rowClick, columnClick - 1].Colour == field[rowClick, columnClick].Colour)
        //    {
        //        Nieghbor(rowClick, columnClick - 1);
        //    }
        //    if (field[rowClick, columnClick + 1].Colour == field[rowClick, columnClick].Colour)
        //    {
        //        Nieghbor(rowClick, columnClick + 1);
        //    }
        //}

        public void Click(int _colIndex, int _rowIndex) // получает индексы нажатия и выясняет строку и колонку 
        {
             rowIndex = _rowIndex / 25;
             colIndex = _colIndex / 25;

           // field[rowIndex, colIndex].Deleted = true;
             //return true;
        }
    }
}
