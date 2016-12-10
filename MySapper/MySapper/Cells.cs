using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MySapper
{
    class Cells
    {
        private int cellSize;//Размер нашей клетки, в конечном итоге можно будет сменить или даже убрать
        public int CellSize
        {
            get { return cellSize; }
            set { cellSize = value; }
        }

        private bool mineInCell;//Есть ли мина в клетке
        public bool MineInCell
        {
            get { return mineInCell; }
            set { mineInCell = value; }
        }

        private bool flagInCell;//Есть ли флаг в клетке
        public bool FlagInCell
        {
            get { return flagInCell; }
            set { flagInCell = value; }
        }

        private bool openCell;//Открыта ли клетка или нет
        public bool OpenCell
        {
            get { return openCell; }
            set { openCell = value; }
        }

        private int mineAround;//Число мин вокруг клетки
        public int MineAround
        {
            get { return mineAround; }
            set { mineAround = value; }
        }

        private Brush sellBackColor; //Цвет фона клетки
        public Brush SellBackColor
        {
            get { return sellBackColor; }
            set { sellBackColor = value; }
        }

        public Cells(int cellSize)
        {
            CellSize = cellSize;
            MineInCell = false;
            OpenCell = false;
            FlagInCell = false;
            SellBackColor = Brushes.IndianRed;
        }

        //Тут заканчивается объявление полей и их свойств и начинаются методы для работы с клеткой(в итоге один метод, лол)

        public void OpenTheCage()
        {
            OpenCell = true;
            SellBackColor = Brushes.AliceBlue;
        }
    }
}
