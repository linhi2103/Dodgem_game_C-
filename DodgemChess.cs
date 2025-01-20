using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_dodgem
{
    public class DodgemChess
    {
        public static SolidBrush SolidBlack;
        public static SolidBrush SolidWhite;
        public static SolidBrush SolidRed;
        private ChessBoardManager broadChess;
        private Cons[,] ocoss;
        private List<Cons> list_plays;
        //luot di
        private int go;

        public Cons[,] Ocoss { get => ocoss; set => ocoss = value; }
        public int Go { get => go; set => go = value; }

        public DodgemChess()
        {
            broadChess = new ChessBoardManager(3, 3);
            Ocoss = new Cons[broadChess.NumRow, broadChess.NumRow];
            SolidBlack = new SolidBrush(Color.Black);
            SolidWhite = new SolidBrush(Color.White);
            SolidRed = new SolidBrush(Color.Red);
            list_plays = new List<Cons>();
            //luot di
            Go = 0;

        }
        public void draw(Graphics g)
        {
            broadChess.draw(g);
        }

        public void init(int[,] x, Graphics g)
        {
            for (int i = 0; i < broadChess.NumCol; i++)
            {
                for (int j = 0; j < broadChess.NumRow; j++)
                {
                    int DI = x[i, j];
                    Ocoss[i, j] = new Cons(i, j, DI, new Point(j * Cons._width, i * Cons._height));
                }
            }

        }

        public bool danh(int mouseX, int mouseY, Graphics g, int player)
        {
            int col = mouseX / Cons._width;
            int row = mouseY / Cons._height;


            switch (Go)
            {
                case 0:
                    Ocoss[row, col].DI = 0;
                    broadChess.drawChess(g, Ocoss[row, col].Position, SolidWhite);
                    Go = player == 1 ? 2 : 1;
                    break;
                case 1:
                    Ocoss[row, col].DI = 1;
                    broadChess.drawChess(g, Ocoss[row, col].Position, SolidBlack);
                    Go = 0;
                    break;
                case 2:
                    Ocoss[row, col].DI = 2;
                    broadChess.drawChess(g, Ocoss[row, col].Position, SolidRed);
                    Go = 0;
                    break;

            }
            list_plays.Add(Ocoss[row, col]);
            return true;
        }

        public void initGame(int mouseX, int mouseY, Graphics g, SolidBrush brush)
        {
            int col = mouseX / Cons._width;
            int row = mouseY / Cons._height;


            for (int i = 0; i < broadChess.NumCol; i++)
            {
                for (int j = 0; j < broadChess.NumRow; j++)
                {
                    broadChess.drawChess(g, Ocoss[row, col].Position, brush);
                }
            }
        }

        public void repaint(Graphics g, Cons[,] oCoss)
        {
            SolidBlack = new SolidBrush(Color.Black);
            SolidWhite = new SolidBrush(Color.White);
            SolidRed = new SolidBrush(Color.Red);

            for (int i = 0; i < broadChess.NumCol; i++)
            {
                for (int j = 0; j < broadChess.NumRow; j++)
                {

                    if (ocoss[i, j].DI == 1)
                    {
                        broadChess.drawChess(g, ocoss[i, j].Position, SolidBlack);
                    }
                    if (ocoss[i, j].DI == 0)
                    {
                        broadChess.drawChess(g, ocoss[i, j].Position, SolidWhite);
                    }
                    if (ocoss[i, j].DI == 2)
                    {
                        broadChess.drawChess(g, ocoss[i, j].Position, SolidRed);
                    }
                }
            }
        }

        public void printMatrix()
        {

            for (int i = 0; i < broadChess.NumCol; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < broadChess.NumRow; j++)
                {

                    Console.Write(ocoss[i, j].DI);
                }
            }
            Console.WriteLine();

        }

        public int[,] getMatrix()
        {
            int[,] res = new int[3, 3];
            for (int i = 0; i < broadChess.NumCol; i++)
            {

                for (int j = 0; j < broadChess.NumRow; j++)
                {

                    res[i, j] = ocoss[i, j].DI;
                }
            }
            return res;
        }
    }
}
