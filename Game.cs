using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_dodgem
{
    public class Game
    {
        public int[,] a = new int[10, 10];

        public int player;
        public static int[,] MOVE_BLACK = { { 0, 1 }, { -1, 0 }, { 1, 0 } };
        public static int[,] MOVE_WHITE = { { -1, 0 }, { 0, 1 }, { 0, -1 } };

        static int[,] DATA_BLACK = { { -10, -25, -40 }, { -5, -20, -35 }, { 0, -15, -30 } };
        static int[,] DATA_WHITE = { { 30, 35, 40 }, { 15, 20, 25 }, { 0, 5, 10 } };

        public Game(int[,] x, int p)
        {
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    a[i, j] = x[i, j];
            player = p;
        }



        public Game(int[][] b, int p)
        {
            for (int i = 0; i < 3; ++i) for (int j = 0; j < 3; ++j) a[i, j] = b[i][j];
            player = p;
        }

        public Boolean canMove(int x, int y)
        {
            if (canGetOut(x, y)) return true;
            if (player == 1)
            {
                Boolean ok = false;
                for (int i = 0; i < 3; ++i)
                {
                    int x1 = x + MOVE_BLACK[i, 0];
                    int y1 = y + MOVE_BLACK[i, 1];
                    if (x1 >= 0 && x1 < 3 && y1 >= 0 && y1 < 3 && a[x1, y1] == 0) ok = true;
                }
                return ok;
            }
            else
            {
                Boolean ok = false;
                for (int i = 0; i < 3; ++i)
                {
                    int x1 = x + MOVE_WHITE[i, 0];
                    int y1 = y + MOVE_WHITE[i, 1];
                    if (x1 >= 0 && x1 < 3 && y1 >= 0 && y1 < 3 && a[x1, y1] == 0) ok = true;
                }
                return ok;
            }
        }

        public Boolean move(int x1, int y1, int x2, int y2)
        {
            if (canGetOut(x1, y1))
            {
                a[x1, y1] = 0;
                return true;
            }

            if (x2 < 0 || y2 >= 3 || x2 >= 3 || y2 < 0) return false;
            if (a[x2, y2] == 0)
            {
                a[x2, y2] = a[x1, y1];
                a[x1, y1] = 0;
                return true;
            }
            return false;
        }

        public Boolean canGetOut(int x, int y)
        {
            if (player == 1) return y == 2 && (x >= 0 && x < 3);
            return x == 0 && (y >= 0 && y < 3);
        }

        public List<int[]> getLocal(int u)
        {
            List<int[]> list = new List<int[]>();
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    if (a[i, j] == u)
                    {
                        int[] x = new int[2];
                        x[0] = i;
                        x[1] = j;
                        list.Add(x);
                    }
            return list;
        }


        public int gameOver()
        {
            if (player > 0)
            {
                List<int[]> list = getLocal(player);
                List<int[]> list1 = getLocal(player == 1 ? 2 : 1);
                if (list.Count == 0) return player;
                if (list1.Count == 0) return player == 1 ? 2 : 1;
                Boolean ok = false;
                foreach (int[] x in list) if (canMove(x[0], x[1])) ok = true;
                if (!ok) return player == 1 ? 2 : 1;
            }
            return 0;

        }

        public int get()
        {
            int total = 0;
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                {
                    if (a[i, j] == 1) total += DATA_BLACK[i, j] + getPointBlock(i, j, 1);
                    else if (a[i, j] == 2) total += DATA_WHITE[i, j] + getPointBlock(i, j, 2);
                }

            return total;
        }

        public int getPointBlock(int x, int y, int s)
        {
            int res = 0;
            for (int k = 1; k <= 2; ++k)
            {
                int dx = s == 1 ? 0 : -1;
                int dy = s == 1 ? 1 : 0;
                int x1 = x + k * dx, y1 = y + k * dy;
                if (x1 < 0 || x1 >= 3 || y1 < 0 || y1 >= 3 || a[x1, y1] == 0) continue;
                if (a[x1, y1] != s) res += k == 1 ? 40 : 30;
            }
            return s == 1 ? res : -res;
        }



        public String toString()
        {
            return "";
        }

        public int[,] outRes()
        {
            int[,] res = new int[10, 10];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    res[i, j] = a[i, j];
                }
            }
            return res;
        }

        public static int MinValue(Game game, int dept)
        {
            if (game.gameOver() != 0 || dept == 0) return game.get();

            int min = Int32.MaxValue;

            List<int[]> list = game.getLocal(game.player);
            foreach (int[] x in list)
            {
                int[,] move = game.player == 1 ? Game.MOVE_BLACK : Game.MOVE_WHITE;

                for (int i = 0; i < 3; ++i)
                {
                    Game tmp = new Game(game.a, game.player);
                    int x1 = x[0], y1 = x[1], x2 = x1 + move[i, 0], y2 = y1 + move[i, 1];

                    if (tmp.move(x1, y1, x2, y2))
                    {
                        tmp.player = game.player == 1 ? 2 : 1;
                        min = Math.Min(min, MaxValue(tmp, dept - 1));

                    }
                }
            }
            return min;
        }


        public static int MaxValue(Game game, int dept)
        {
            if (game.gameOver() != 0 || dept == 0) return game.get();

            int max = Int32.MinValue;

            List<int[]> list = game.getLocal(game.player);
            foreach (int[] x in list)
            {
                int[,] move = game.player == 1 ? Game.MOVE_BLACK : Game.MOVE_WHITE;

                for (int i = 0; i < 3; ++i)
                {
                    Game tmp = new Game(game.a, game.player);
                    int x1 = x[0], y1 = x[1], x2 = x1 + move[i, 0], y2 = y1 + move[i, 1];

                    if (tmp.move(x1, y1, x2, y2))
                    {
                        tmp.player = game.player == 1 ? 2 : 1;
                        max = Math.Max(max, MinValue(tmp, dept - 1));

                    }
                }
            }
            return max;
        }
    }
}
