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
        Game newgame;
        Brush[] col = new[] { Color.Blue, Color.Red, Color.Yellow, Color.Green, Color.Magenta }.Select(c => new SolidBrush(c)).ToArray();
        Graphics g;
        Random rnd;
        
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();

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
            g.Clear(Color.DimGray);
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

        public void CreateField2(Cubs[,] cubs, int rows, int columns, int colCount)//САМЫЙ ВАЖНЫЙ АЛГОРИТМ 

        {
            g.Clear(Color.DimGray);
            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if(cubs[i,j].Deleted == true && i > 1)
                    {
                        for (int l = i; l > 0; l--)
                        {
                        cubs[l - 1, j].y = cubs[l, j].y;
                        cubs[l - 1, j].drawCub(g, col[cubs[l - 1, j].Colour], cubs[l - 1, j].x, cubs[l - 1, j].y);//рисуем этот кубик
                        }
                        i = rows;
                    }
                    else
                    {
                        cubs[i, j].drawCub(g, col[cubs[i, j].Colour], cubs[i, j].x, cubs[i, j].y);//рисуем этот кубик
                    }
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) //читаем положение мышки при нажатии
        {
            newgame.Click(e.Y, e.X);
           // newgame.FieldCubs[newgame.rowClick, newgame.columnClick].drawCub(g, Brushes.Black, newgame.FieldCubs[newgame.rowClick, newgame.columnClick].x, newgame.FieldCubs[newgame.rowClick, newgame.columnClick].y);//рисуем этот кубик
             CreateField2(newgame.FieldCubs, 15, 15, newgame.ColorsCount);
        }
    }
}
