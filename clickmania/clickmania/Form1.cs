using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace clickmania
{
    public partial class Form1 : Form
    {
        private Game newgame;
        private Brush[] col = new[] { Color.FromArgb(0,0,255), Color.FromArgb(255,0,0), Color.FromArgb(255,255,0), Color.FromArgb(0,255,0), Color.FromArgb(255,0,255) }.Select(c => new SolidBrush(c)).ToArray();
        private Graphics g;
        private Random rnd;
        
        public Form1()
        {
            InitializeComponent();
            g = panel2.CreateGraphics();

            rnd = new Random();

            for (int i = 1; i <= 5; i++) // Добавляет количество цветов на выбор
                ColorsCounts.Items.Add(i);
        }

        
        private void StartGame_Click(object sender, EventArgs e)
        {
            int rowCounts = (int)RowCountsNumeric.Value;
            int columnCounts = (int)ColumnCountsNumeric.Value;
            int colorsCounts = Convert.ToInt32(ColorsCounts.Text);

            newgame = new Game(rowCounts, columnCounts, colorsCounts);
            g.Clear(Color.LightGray);
            newgame.FieldCubs = new Cubs[rowCounts,columnCounts];//досоздаем поле нужного размера
            CreateField(newgame.FieldCubs, rowCounts, columnCounts, colorsCounts);//заполняем его
        }


        public void CreateField(Cubs[,] cubs, int rows, int columns, int colCount)//геним поле
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    Cubs elem = new Cubs(i * 25, j * 25, rnd.Next(0, colCount), false);//создаем кубик со всеми свойствами
                    elem.drawCub(g, col[elem.Colour], elem.x, elem.y);//рисуем этот кубик
                    cubs[i,j] = elem;//пихаем кубик в массив поля для дальнейшего юзанья
                }
        }

        public void CreateField2(Cubs[,] cubs, int colCount)//САМЫЙ ВАЖНЫЙ АЛГОРИТМ 

        {
            int index;
           // g.Clear(Color.DimGray);
            for (int j = 0; j < cubs.GetLength(0); j++)
            {
                for (int i = cubs.GetLength(1) - 1; i >= 0; i--)
                {
                    if (cubs[j, i].Deleted == true && j > 1)
                    {
                         for (int l = i; l > 0; l--)
                        {
                            // int index = cubs[j, i].y;
                            // int index2 = cubs[j, i-1].y;
                            // index = cubs[j, i - 1].y;
                            cubs[j, l].Colour = cubs[j, l-1].Colour;
                            cubs[j, l].drawCub(g, col[cubs[j, l].Colour], cubs[j, l].x, cubs[j, l].y);//рисуем этот кубик
                           // if(l == 0) cubs[j, l].drawCub(g, Brushes.DimGray, cubs[j, l].x, cubs[j, l].y);
                            // cubs[j, l - 1].y = cubs[j, l].y;
                        }
                        cubs[j, i].Deleted = false;
                    }
                    else
                    {
                        //cubs[j, i].drawCub(g, col[cubs[j, i].Colour], cubs[j, i].x, cubs[j, i].y);//рисуем этот кубик
                    }
                }
            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            newgame.Click(e.Y, e.X);
            // newgame.FieldCubs[newgame.rowClick, newgame.columnClick].drawCub(g, Brushes.Black, newgame.FieldCubs[newgame.rowClick, newgame.columnClick].x, newgame.FieldCubs[newgame.rowClick, newgame.columnClick].y);//рисуем этот кубик
            CreateField2(newgame.FieldCubs, newgame.ColorsCount);
        }
    }
}
