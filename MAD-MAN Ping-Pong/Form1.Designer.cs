namespace MAD_MAN_Ping_Pong
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
            this.components = new System.ComponentModel.Container();
            this.P1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.C2 = new System.Windows.Forms.CheckBox();
            this.C1 = new System.Windows.Forms.CheckBox();
            this.Player_Command = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Level = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Panel();
            this.Ball_Move = new System.Windows.Forms.Timer(this.components);
            this.P2_GUI = new System.Windows.Forms.Timer(this.components);
            this._p1tm = new System.Windows.Forms.Timer(this.components);
            this._p2tm = new System.Windows.Forms.Timer(this.components);
            this.pict = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // P1
            // 
            this.P1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.P1.BackColor = System.Drawing.Color.White;
            this.P1.Location = new System.Drawing.Point(2, 111);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(12, 91);
            this.P1.TabIndex = 1;
            this.P1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 13);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(230, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(2, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 131);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.C2);
            this.panel4.Controls.Add(this.C1);
            this.panel4.Controls.Add(this.Player_Command);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.Level);
            this.panel4.Controls.Add(this.Start);
            this.panel4.Controls.Add(this.Score);
            this.panel4.Location = new System.Drawing.Point(10, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(742, 105);
            this.panel4.TabIndex = 0;
            // 
            // C2
            // 
            this.C2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.C2.AutoSize = true;
            this.C2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C2.ForeColor = System.Drawing.Color.White;
            this.C2.Location = new System.Drawing.Point(417, 46);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(125, 17);
            this.C2.TabIndex = 7;
            this.C2.Text = "USING WS MOVING";
            this.C2.UseVisualStyleBackColor = true;
            this.C2.CheckedChanged += new System.EventHandler(this.C2_CheckedChanged);
            this.C2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.C2_KeyDown);
            this.C2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.C2_KeyUp);
            // 
            // C1
            // 
            this.C1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.C1.AutoSize = true;
            this.C1.Checked = true;
            this.C1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C1.ForeColor = System.Drawing.Color.White;
            this.C1.Location = new System.Drawing.Point(199, 46);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 17);
            this.C1.TabIndex = 6;
            this.C1.Text = "USING MOUSE";
            this.C1.UseVisualStyleBackColor = true;
            this.C1.CheckedChanged += new System.EventHandler(this.C1_CheckedChanged);
            this.C1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.C2_KeyDown);
            this.C1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.C2_KeyUp);
            // 
            // Player_Command
            // 
            this.Player_Command.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Player_Command.ForeColor = System.Drawing.Color.White;
            this.Player_Command.Location = new System.Drawing.Point(105, 14);
            this.Player_Command.Name = "Player_Command";
            this.Player_Command.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Player_Command.Size = new System.Drawing.Size(88, 80);
            this.Player_Command.TabIndex = 5;
            this.Player_Command.Text = "SINGLE\r\nPLAYER";
            this.Player_Command.UseVisualStyleBackColor = false;
            this.Player_Command.Click += new System.EventHandler(this.Player_Command_Click);
            this.Player_Command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Player_Command.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(642, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // Level
            // 
            this.Level.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Level.ForeColor = System.Drawing.Color.White;
            this.Level.Location = new System.Drawing.Point(548, 14);
            this.Level.Name = "Level";
            this.Level.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Level.Size = new System.Drawing.Size(88, 80);
            this.Level.TabIndex = 2;
            this.Level.Text = "EASY";
            this.Level.UseVisualStyleBackColor = false;
            this.Level.Click += new System.EventHandler(this.Level_Click);
            this.Level.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Level.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(11, 14);
            this.Start.Name = "Start";
            this.Start.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Start.Size = new System.Drawing.Size(88, 80);
            this.Start.TabIndex = 1;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Start.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // Score
            // 
            this.Score.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(271, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(0, 108);
            this.Score.TabIndex = 0;
            // 
            // P2
            // 
            this.P2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.P2.BackColor = System.Drawing.Color.White;
            this.P2.Location = new System.Drawing.Point(752, 111);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(12, 91);
            this.P2.TabIndex = 2;
            // 
            // Ball_Move
            // 
            this.Ball_Move.Interval = 10;
            this.Ball_Move.Tick += new System.EventHandler(this.Ball_Move_Tick);
            // 
            // P2_GUI
            // 
            this.P2_GUI.Interval = 10;
            this.P2_GUI.Tick += new System.EventHandler(this.P2_GUI_Tick);
            // 
            // _p1tm
            // 
            this._p1tm.Interval = 10;
            this._p1tm.Tick += new System.EventHandler(this._p1tm_Tick);
            // 
            // _p2tm
            // 
            this._p2tm.Interval = 10;
            this._p2tm.Tick += new System.EventHandler(this._p2tm_Tick);
            // 
            // pict
            // 
            this.pict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pict.BackgroundImage = global::MAD_MAN_Ping_Pong.Properties.Resources.Untitled;
            this.pict.Location = new System.Drawing.Point(390, 12);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(10, 325);
            this.pict.TabIndex = 0;
            this.pict.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Image = global::MAD_MAN_Ping_Pong.Properties.Resources.thu_14527;
            this.Ball.Location = new System.Drawing.Point(374, 145);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(38, 36);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 4;
            this.Ball.TabStop = false;
            this.Ball.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(767, 460);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.pict);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.P1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAD-MAN Ping-Pong (Batalan Vlad produkt)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel P2;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Level;
        private System.Windows.Forms.Timer Ball_Move;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Player_Command;
        private System.Windows.Forms.Timer P2_GUI;
        private System.Windows.Forms.Timer _p1tm;
        private System.Windows.Forms.Timer _p2tm;
        private System.Windows.Forms.CheckBox C1;
        private System.Windows.Forms.CheckBox C2;
        private System.Windows.Forms.PictureBox pict;
    }
}

