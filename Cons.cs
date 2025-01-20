using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_dodgem
{
    public class Cons
    {
        public const int _width = 80;
        public const int _height = 80;

        private int _row;
        private int _col;
        private int _DI;
        private Point _position;

        public Point Position { get => _position; set => _position = value; }
        public int Row { get => _row; set => _row = value; }
        public int Col { get => _col; set => _col = value; }
        public int DI { get => _DI; set => _DI = value; }

        public Cons(int row, int col, int DI, Point pos)
        {
            this._row = row;
            this._col = col;
            this.DI = DI;
            this._position = pos;
        }
        public Cons(int DI, Point pos)
        {
            this.DI = DI;
            this._position = pos;
        }
    }
}
