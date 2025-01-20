using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_dodgem
{
    public class ChessBoardManager
    {
        private int _numRow;
        private int _numCol;

        public ChessBoardManager()
        {
            NumCol = 0;
            NumRow = 0;
        }

        public ChessBoardManager(int numCol, int numRow)
        {
            this.NumRow = numRow;
            this.NumCol = numCol;
        }

        public int NumRow { get => _numRow; set => _numRow = value; }
        public int NumCol { get => _numCol; set => _numCol = value; }

        public void draw(Graphics g)
        {
            for (int i = 0; i <= NumCol; i++)
            {
                g.DrawLine(Program.pen, i * Cons._width, 0, i * Cons._width, NumRow * Cons._height);
            }
            for (int i = 0; i <= NumRow; i++)
            {
                g.DrawLine(Program.pen, 0, i * Cons._height, NumCol * Cons._height, i * Cons._height);
            }
        }

        internal void drawChess(Graphics g, Point point, SolidBrush sb)
        {
            g.FillEllipse(sb, point.X, point.Y, Cons._width, Cons._height);
        }

    }
}
