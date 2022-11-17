namespace StopWatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBomb = new System.Windows.Forms.PictureBox();
            this.btnTarget = new System.Windows.Forms.PictureBox();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tmrBomb = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Enabled = false;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(513, 672);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 44);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "30";
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.picBomb);
            this.panel1.Controls.Add(this.btnTarget);
            this.panel1.Location = new System.Drawing.Point(34, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 584);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // picBomb
            // 
            this.picBomb.BackgroundImage = global::StopWatch.Properties.Resources.bomb;
            this.picBomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBomb.Location = new System.Drawing.Point(389, 180);
            this.picBomb.Name = "picBomb";
            this.picBomb.Size = new System.Drawing.Size(66, 63);
            this.picBomb.TabIndex = 3;
            this.picBomb.TabStop = false;
            this.picBomb.Visible = false;
            this.picBomb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bomb_ClickEvent);
            // 
            // btnTarget
            // 
            this.btnTarget.BackgroundImage = global::StopWatch.Properties.Resources.target;
            this.btnTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTarget.Location = new System.Drawing.Point(148, 246);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(66, 67);
            this.btnTarget.TabIndex = 2;
            this.btnTarget.TabStop = false;
            this.btnTarget.Visible = false;
            this.btnTarget.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Target_ClickEvent_Down);
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentScore.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScore.Location = new System.Drawing.Point(328, 20);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(46, 54);
            this.lblCurrentScore.TabIndex = 6;
            this.lblCurrentScore.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(681, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "High Score:";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(716, 128);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(45, 54);
            this.lblHighScore.TabIndex = 10;
            this.lblHighScore.Text = "0";
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Transparent;
            this.heart1.BackgroundImage = global::StopWatch.Properties.Resources.heart;
            this.heart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart1.Location = new System.Drawing.Point(521, 28);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(43, 43);
            this.heart1.TabIndex = 11;
            this.heart1.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Transparent;
            this.heart2.BackgroundImage = global::StopWatch.Properties.Resources.heart;
            this.heart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart2.Location = new System.Drawing.Point(570, 28);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(43, 43);
            this.heart2.TabIndex = 12;
            this.heart2.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Transparent;
            this.heart3.BackgroundImage = global::StopWatch.Properties.Resources.heart;
            this.heart3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart3.Location = new System.Drawing.Point(619, 28);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(43, 43);
            this.heart3.TabIndex = 13;
            this.heart3.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tmrBomb
            // 
            this.tmrBomb.Interval = 500;
            this.tmrBomb.Tick += new System.EventHandler(this.tmrBomb_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 734);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Target Practice";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.PictureBox btnTarget;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox picBomb;
        private System.Windows.Forms.Timer tmrBomb;
    }
}

