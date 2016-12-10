﻿using System;
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
        private Cubs[,] field; //создаем массив кубиков - игровое поле

        public Game(int rowCounts, int columnCounts, int colorsCounts) // just конструктор
        {
            this.rowCounts = rowCounts;
            this.columnCounts = columnCounts;
            this.colorsCounts = colorsCounts;
        }

        public Cubs[,] FieldCubs
        {
            set { field = value; }
            get { return field; }
        }

        public int ColorsCount { get { return colorsCounts; } }


        // public int this[int rowIndex, int colIndex] { get; } // хз че это, но Димасик сказал делать


        public int Score { get; }


        public bool Finish { get; }

        public int rowClick;
        public int columnClick;
        public void Click(int colIndex, int rowIndex) // получает индексы нажатия и выясняет строку и колонку 
        {
             rowClick = rowIndex / 25;
             columnClick = colIndex / 25;

            field[rowClick,columnClick].Deleted = true;
        }
    }
}
