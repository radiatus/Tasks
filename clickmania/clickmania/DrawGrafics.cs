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
    class DrawGrafics : Form
    {
        Brush[] col = new[] { Color.Blue, Color.Red, Color.Yellow, Color.Green, Color.Magenta }.Select(c => new SolidBrush(c)).ToArray();
        Graphics g;
        public DrawGrafics()
        {
            g = CreateGraphics();
        }

        public void DrawRectangles(int colorNumber, int j, int i)
        {
            g.Clear(Color.Black);

            g.FillRectangle(col[colorNumber], j * 25, i * 25, 25, 25);
            g.DrawRectangle(Pens.Black, j * 25, i * 25, 25, 25);
        }
    }
}
