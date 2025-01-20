namespace BTL_dodgem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_rule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnChess = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rad_Den = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_Do = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_hard = new System.Windows.Forms.RadioButton();
            this.rad_medium = new System.Windows.Forms.RadioButton();
            this.rad_ez = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.C_score = new System.Windows.Forms.Button();
            this.P_score = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "COM";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(252, 125);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 58);
            this.panel2.TabIndex = 20;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // btn_rule
            // 
            this.btn_rule.AutoSize = true;
            this.btn_rule.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_rule.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rule.Location = new System.Drawing.Point(494, 125);
            this.btn_rule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_rule.Name = "btn_rule";
            this.btn_rule.Size = new System.Drawing.Size(75, 53);
            this.btn_rule.TabIndex = 19;
            this.btn_rule.Text = "START";
            this.btn_rule.UseVisualStyleBackColor = false;
            this.btn_rule.Click += new System.EventHandler(this.btn_rule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(51, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 68);
            this.label1.TabIndex = 18;
            this.label1.Text = "Dodgem";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(496, 191);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 298);
            this.panel1.TabIndex = 13;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick_1);
            // 
            // pnChess
            // 
            this.pnChess.BackColor = System.Drawing.Color.White;
            this.pnChess.Location = new System.Drawing.Point(252, 191);
            this.pnChess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnChess.Name = "pnChess";
            this.pnChess.Size = new System.Drawing.Size(245, 298);
            this.pnChess.TabIndex = 12;
            this.pnChess.Paint += new System.Windows.Forms.PaintEventHandler(this.pnChess_Paint);
            this.pnChess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnChess_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(7, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(173, 30);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rad_Den
            // 
            this.rad_Den.AutoSize = true;
            this.rad_Den.Location = new System.Drawing.Point(30, 54);
            this.rad_Den.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rad_Den.Name = "rad_Den";
            this.rad_Den.Size = new System.Drawing.Size(67, 20);
            this.rad_Den.TabIndex = 28;
            this.rad_Den.TabStop = true;
            this.rad_Den.Text = "Black";
            this.rad_Den.UseVisualStyleBackColor = true;
            this.rad_Den.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Do);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rad_Den);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(16, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(222, 172);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Who to move first?";
            // 
            // rad_Do
            // 
            this.rad_Do.AutoSize = true;
            this.rad_Do.ForeColor = System.Drawing.Color.Red;
            this.rad_Do.Location = new System.Drawing.Point(133, 54);
            this.rad_Do.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rad_Do.Name = "rad_Do";
            this.rad_Do.Size = new System.Drawing.Size(57, 20);
            this.rad_Do.TabIndex = 29;
            this.rad_Do.TabStop = true;
            this.rad_Do.Text = "Red";
            this.rad_Do.UseVisualStyleBackColor = true;
            this.rad_Do.CheckedChanged += new System.EventHandler(this.rad_Do_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "USER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_hard);
            this.groupBox2.Controls.Add(this.rad_medium);
            this.groupBox2.Controls.Add(this.rad_ez);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(24, 357);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(214, 132);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose level";
            // 
            // rad_hard
            // 
            this.rad_hard.AutoSize = true;
            this.rad_hard.Location = new System.Drawing.Point(152, 68);
            this.rad_hard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rad_hard.Name = "rad_hard";
            this.rad_hard.Size = new System.Drawing.Size(62, 20);
            this.rad_hard.TabIndex = 32;
            this.rad_hard.TabStop = true;
            this.rad_hard.Text = "Hard";
            this.rad_hard.UseVisualStyleBackColor = true;
            this.rad_hard.CheckedChanged += new System.EventHandler(this.rad_hard_CheckedChanged);
            // 
            // rad_medium
            // 
            this.rad_medium.AutoSize = true;
            this.rad_medium.Location = new System.Drawing.Point(69, 68);
            this.rad_medium.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rad_medium.Name = "rad_medium";
            this.rad_medium.Size = new System.Drawing.Size(82, 20);
            this.rad_medium.TabIndex = 31;
            this.rad_medium.TabStop = true;
            this.rad_medium.Text = "Medium";
            this.rad_medium.UseVisualStyleBackColor = true;
            this.rad_medium.CheckedChanged += new System.EventHandler(this.rad_medium_CheckedChanged);
            // 
            // rad_ez
            // 
            this.rad_ez.AutoSize = true;
            this.rad_ez.Location = new System.Drawing.Point(4, 68);
            this.rad_ez.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rad_ez.Name = "rad_ez";
            this.rad_ez.Size = new System.Drawing.Size(67, 20);
            this.rad_ez.TabIndex = 30;
            this.rad_ez.TabStop = true;
            this.rad_ez.Text = "Basic";
            this.rad_ez.UseVisualStyleBackColor = true;
            this.rad_ez.CheckedChanged += new System.EventHandler(this.rad_ez_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.C_score);
            this.groupBox3.Controls.Add(this.P_score);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(252, 9);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(317, 100);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "USER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "COM";
            // 
            // C_score
            // 
            this.C_score.Enabled = false;
            this.C_score.Location = new System.Drawing.Point(226, 21);
            this.C_score.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.C_score.Name = "C_score";
            this.C_score.Size = new System.Drawing.Size(70, 62);
            this.C_score.TabIndex = 1;
            this.C_score.Text = "0";
            this.C_score.UseVisualStyleBackColor = true;
            // 
            // P_score
            // 
            this.P_score.Enabled = false;
            this.P_score.Location = new System.Drawing.Point(74, 21);
            this.P_score.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.P_score.Name = "P_score";
            this.P_score.Size = new System.Drawing.Size(70, 62);
            this.P_score.TabIndex = 0;
            this.P_score.Text = "0";
            this.P_score.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 525);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_rule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnChess);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "DODGEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_rule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnChess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton rad_Den;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_Do;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_hard;
        private System.Windows.Forms.RadioButton rad_medium;
        private System.Windows.Forms.RadioButton rad_ez;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button C_score;
        private System.Windows.Forms.Button P_score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

