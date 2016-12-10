using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace clickmania
{
    public class Cubs
    {
        public int x;//коорд левого верхнего угла
        public int y;
        public int Colour;//индекс цвета
        public bool Deleted;//удален кубик в ходе игры или нет, потом пригодится

        public Cubs(int x, int y, int col, bool del)// в конструктор пихаем все основные данные о кубике
        {
            this.x = x;
            this.y = y;
            Colour = col;
            Deleted = del;
        }

        public void drawCub(Graphics g, Brush br,int x,int y)//а тут мы его рисуем, все логично, кисть генерируется на 
                                                             //форме, тут мы просто ее передаем в качестве параметра
        {
            if (Deleted == false)
            {
                g.FillRectangle(br, x, y, 25, 25);
                g.DrawRectangle(Pens.Black, x, y, 25, 25);
            }
            else
            {
                g.FillRectangle(Brushes.Pink, x, y, 25, 25);
                g.DrawRectangle(Pens.Black, x, y, 25, 25);
            }
        }
    

    }
}
