using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MySapper
{
    class SapperDrawing
    {
        //Графику честно стырил, сам я рисовать почти не умею в формах
        // рисует мину
        private void DrawMine(Graphics g, int x, int y)
        {
            //// корпус
            g.FillRectangle(Brushes.Green, x + 16, y + 26, 8, 4);
            g.FillRectangle(Brushes.Green, x + 8, y + 30, 24, 4);
            g.DrawPie(Pens.Black, x + 6, y + 28, 28, 16, 0, -180);
            g.FillPie(Brushes.Green, x + 6, y + 28, 28, 16, 0, -180);

            // полоса на корпусе
            g.DrawLine(Pens.Black, x + 12, y + 32, x + 28, y + 32);

            // вертикальный "ус"
            g.DrawLine(Pens.Black, x + 20, y + 22, x + 20, y + 26);

            // боковые "усы"
            g.DrawLine(Pens.Black, x + 8, y + 30, x + 6, y + 28);
            g.DrawLine(Pens.Black, x + 32, y + 30, x + 34, y + 28);
        }

        // рисует флаг
        private void DrawFlag(Graphics g, int x, int y)
        {
            Point[] p = new Point[3];
            Point[] m = new Point[5];

            // флажок
            p[0].X = x + 4; p[0].Y = y + 4;
            p[1].X = x + 30; p[1].Y = y + 12;
            p[2].X = x + 4; p[2].Y = y + 20;
            g.FillPolygon(Brushes.Red, p);

            // древко
            g.DrawLine(Pens.Black, x + 4, y + 4, x + 4, y + 35);

            // буква M на флажке
            m[0].X = x + 8; m[0].Y = y + 14;
            m[1].X = x + 8; m[1].Y = y + 8;
            m[2].X = x + 10; m[2].Y = y + 10;
            m[3].X = x + 12; m[3].Y = y + 8;
            m[4].X = x + 12; m[4].Y = y + 14;
            g.DrawLines(Pens.White, m);
        }

        public void DrawCell(Graphics g, int row, int col, Cells c, GameStatus status)//Используя предыдущие методы каждую клетку рисует по факту этот метод
        {

            //Координаты левого верхнего угла клетки
            int x = col * c.CellSize + 1;
            int y = row * c.CellSize + 1;

            if (status == GameStatus.FAIL && c.MineInCell)
            {
                c.SellBackColor = Brushes.Red;
            }

            g.FillRectangle(c.SellBackColor, x - 1, y - 1, c.CellSize, c.CellSize);// рисуем фон клетки
            g.DrawRectangle(Pens.Black, x - 1, y - 1, c.CellSize, c.CellSize);  // рисуем границу клетки

            if (c.OpenCell)
            {
                if (c.MineAround == 0)
                {
                    g.DrawString("", new Font("Tahoma", 16, System.Drawing.FontStyle.Regular),
                      Brushes.Indigo, x + 10, y + 7);
                }
                else
                {
                    g.DrawString(c.MineAround.ToString(),
                        new Font("Tahoma", 16, System.Drawing.FontStyle.Regular),
                          Brushes.Indigo, x + 10, y + 7);
                }
            }

            //В клетке поставлен флаг - рисуем его на клетке, только надо не забыть огранить его постановку на открытой клетке
            if (c.FlagInCell)
            {
                DrawFlag(g, x, y);
            }

            //Если игра завершена поражением, показываем мины, не вместе с прошлым ифом потому что тогда не рисует мины
            if (status == GameStatus.FAIL && c.MineInCell)
            {
                DrawMine(g, x, y);
            }
        }

        
    }
}
