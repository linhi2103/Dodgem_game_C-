using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_dodgem
{
    public partial class Form1 : Form
    {
        private DodgemChess dogemChess;
        private Graphics graphics;
        // biến d kiểm soát lượt đi
        private int d = 0;
        // khởi tạo độ sâu
        private int depth = 0;
        // khởi tạo người chơi 1 là đen 2 là đỏ.
        private int player = 0;
        public Form1()
        {
            InitializeComponent();
            dogemChess = new DodgemChess();
            graphics = pnChess.CreateGraphics();
            newGame();
        }
        private void newGame()
        {
            player = 0;
            depth = 0;
            //khởi tạo trạng thái ban đầu
            int[,] initial = {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 } };

            // vẽ lại bàn cờ khi người chơi hay máy đánh cờ
            dogemChess.draw(graphics);
            // vẽ lại các ô cớ trên bàn cờ
            dogemChess.init(initial, graphics);
            dogemChess.repaint(graphics, dogemChess.Ocoss);
        }
        private void updateBroad(int[,] initial)
        {
            // khời tạo trạng thái ban đầu
            Game begin = new Game(initial, player);


            // chạy minimax 
            if (player > 0)
            {
                Game res = RunMinMax(begin, depth);
                // ánh xạ ma trận trạng thái sang đồ họa
                
                dogemChess.init(res.outRes(), graphics);
                
                // vẽ bàn cờ
                dogemChess.draw(graphics);
                // vẽ lại các ô cớ trên bàn cờ
                
                dogemChess.init(res.outRes(), graphics);
                
                dogemChess.repaint(graphics, dogemChess.Ocoss);
                {
                    int a = 0, b = 0;
                    if (res.gameOver() == 1)
                    {
                        MessageBox.Show("Black win");
                        //P
                        a=a+1;
                        P_score.Text = ""+a.ToString();
                        pnChess.Enabled = false;
                        panel1.Enabled = false;
                        panel2.Enabled = false;
                        return;
                    }

                    if (res.gameOver() == 2)
                    {
                        MessageBox.Show("Red win");
                        //C
                        b=b+1;
                        C_score.Text = ""+b.ToString();
                        pnChess.Enabled = false;
                        panel1.Enabled = false;
                        panel2.Enabled = false;
                        return;
                    }

                }
            }



        }

      
        public Game RunMinMax(Game game, int dept)
        {
            Game res = null;
            Game tmp1 = null;

              //int alpha = Int32.MinValue;
              //int beta = Int32.MaxValue;
            int val = game.player == 1 ? Int32.MaxValue : Int32.MinValue;


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
                        tmp1 = new Game(tmp.a, tmp.player);

                        int sr = game.player == 1 ? Game.MinValue(tmp, dept - 1) : Game.MaxValue(tmp, dept - 1);

                        if (game.player == 1 && sr <= val)
                        {
                            val = sr;
                            res = tmp1;
                        }
                        else if (game.player == 2 && sr >= val)
                        {
                            val = sr;
                            res = tmp1;
                        }
                    }
                }

            }
            return res;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
            P_score.Text = "0";
            C_score.Text = "0";
            rad_Do.Enabled= true;
            rad_Den.Enabled= true;
            rad_ez.Enabled= true;
            rad_medium.Enabled= true;
            rad_hard.Enabled = true;
            btn_rule.Enabled = true;
            pnChess.Enabled = true;
            panel1.Enabled = true;
            panel2.Enabled = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quân đen có thể đi tới ô trống bên phải, ở trên hoặc ở dưới\n" +
                            "\nQuân đỏ có thể đi tới ô trống bên trái, bên phải, ở trên\n" +
                            "\nQuân đen nếu ở cột ngoài cùng bên phải có thể đi ra ngoài bàn cờ\n" +
                            "\nQuân trắng nếu ở hàng trên cùng có thể đi ra khỏi bàn cờ\n" +
                            "\nAi đưa cả hai quân của mình ra khỏi bàn cờ trước sẽ thắng\n" +
                            "\nhoặc tạo ra tình huống mà đối phương không đi được cũng sẽ thắng", "Rules ");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\r\tNguyễn Hồng Ngọc - 94208\n\r\t"+"Nguyễn Thanh Minh - 90510\n\r\t"+"Nguyễn Thị Linh Nhi - 94318", "Developer");
        }
        private void btn_rule_Click(object sender, EventArgs e)
        {
            if ((rad_ez.Checked==false&&rad_hard.Checked==false&&rad_medium.Checked== false) || (rad_Den.Checked == false &&rad_Do.Checked== false))
            {
                rad_hard.Enabled = true;
                rad_ez.Enabled = true;
                rad_medium.Enabled = true;
                rad_Den.Enabled = true;
                rad_Do.Enabled = true;
                MessageBox.Show("Bạn phải chọn màu quân và độ khó");
                return;
            }
            else
            {
                if (rad_ez.Checked == true)
                {
                    depth = 1;
                    if (rad_Do.Checked == true)
                    {
                        player = 1;
                        d = 0;
                        int[,] initial = {
                            { 1, 0, 0 },
                            { 1, 0, 0 },
                            { 0, 2, 2 } };
                        // vẽ lại bàn cờ khi người chơi hay máy đánh cờ
                        updateBroad(initial);
                        btn_rule.Enabled = false;
                    }
                    else
                    {
                        player = 2;
                        d = 0;
                        int[,] initial = {
                            { 1, 0, 0 },
                            { 1, 0, 0 },
                            { 0, 2, 2 } };
                        // vẽ lại bàn cờ khi người chơi hay máy đánh cờ
                        updateBroad(initial);
                        btn_rule.Enabled = false;
                    }
                }
                if (rad_medium.Checked == true)
                {
                    depth= 2;
                    if (rad_Do.Checked == true)
                    {
                        player = 1;
                        d = 0;
                        int[,] initial = {
                            { 1, 0, 0 },
                            { 1, 0, 0 },
                            { 0, 2, 2 } };
                        // vẽ lại bàn cờ khi người chơi hay máy đánh cờ
                        updateBroad(initial);
                        btn_rule.Enabled = false;
                    }
                    else
                    {
                        player = 2;
                        d = 0;
                        int[,] initial = {
                            { 1, 0, 0 },
                            { 1, 0, 0 },
                            { 0, 2, 2 } };
                        // vẽ lại bàn cờ khi người chơi hay máy đánh cờ
                        updateBroad(initial);
                        btn_rule.Enabled = false;
                    }
                }
                if (rad_hard.Checked == true)
                {
                    depth= 5;
                    if (rad_Do.Checked == true)
                    {
                        player = 1;
                        d = 0;
                        int[,] initial = {
                            { 1, 0, 0 },
                            { 1, 0, 0 },
                            { 0, 2, 2 } };
                        // vẽ lại bàn cờ khi người chơi hay máy đánh cờ
                        updateBroad(initial);
                        btn_rule.Enabled = false;
                    }
                    else
                    {
                        player = 2;
                        d = 0;
                        int[,] initial = {
                            { 1, 0, 0 },
                            { 1, 0, 0 },
                            { 0, 2, 2 } };
                        // vẽ lại bàn cờ khi người chơi hay máy đánh cờ
                        updateBroad(initial);
                        btn_rule.Enabled = false;
                    }
                }
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "USER";
            label2.Text = "COM";
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Black;
        }

        private void rad_Do_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "USER";
            label3.Text = "COM";
            label3.ForeColor = Color.Black ;
            label2.ForeColor = Color.Red;
        }

        private void panel1_MouseClick_1(object sender, MouseEventArgs e)
        {
            d++;
            int[,] maxtrixCurrent = dogemChess.getMatrix();
            updateBroad(maxtrixCurrent);
            dogemChess.Go = 0;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            d++;
            int[,] maxtrixCurrent = dogemChess.getMatrix();
            updateBroad(maxtrixCurrent);
            dogemChess.Go = 0;
        }

        private void pnChess_MouseClick(object sender, MouseEventArgs e)
        {
            if (player == 0)
            {
                MessageBox.Show("Vui Lòng chọn màu quân");
                return;
            }
            d++;
            dogemChess.danh(e.X, e.Y, graphics, player);
            if (d % 2 == 0)
            {
                int[,] maxtrixCurrent = dogemChess.getMatrix();
                updateBroad(maxtrixCurrent);
            }
        }

        private void pnChess_Paint(object sender, PaintEventArgs e)
        {
            // vẽ bàn cờ
            dogemChess.draw(graphics);
            // vẽ lại các ô cờ trên bàn cờ
            dogemChess.repaint(graphics, dogemChess.Ocoss);
        }

        private void rad_ez_CheckedChanged(object sender, EventArgs e)
        {
            depth = 1;
        }

        private void rad_medium_CheckedChanged(object sender, EventArgs e)
        {
            depth = 2;
        }

        private void rad_hard_CheckedChanged(object sender, EventArgs e)
        {
            depth = 5;
        }
    }
}
