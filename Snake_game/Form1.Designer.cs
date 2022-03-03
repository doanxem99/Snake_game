namespace Snake_game
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extremeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PLAYERSSCORE_label = new System.Windows.Forms.Label();
            this.SCORE_label = new System.Windows.Forms.Label();
            this.PLAY_button = new System.Windows.Forms.Button();
            this.TIME_label = new System.Windows.Forms.Label();
            this.TIME3_label = new System.Windows.Forms.Label();
            this.BLOCK_checkbox = new System.Windows.Forms.CheckBox();
            this.BIGFOOD_checkbox = new System.Windows.Forms.CheckBox();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.PAUSE_button = new System.Windows.Forms.Button();
            this.TIME2_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BOX2_picture = new System.Windows.Forms.PictureBox();
            this.BOX1_picture = new System.Windows.Forms.PictureBox();
            this.BOX3_picture = new System.Windows.Forms.PictureBox();
            this.BOX4_picture = new System.Windows.Forms.PictureBox();
            this.BOX5_picture = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOX2_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOX1_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOX3_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOX4_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOX5_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "SNAKE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.difficultyToolStripMenuItem,
            this.changeNameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem,
            this.extremeToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.difficultyToolStripMenuItem.Text = "Choose Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // extremeToolStripMenuItem
            // 
            this.extremeToolStripMenuItem.Name = "extremeToolStripMenuItem";
            this.extremeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.extremeToolStripMenuItem.Text = "Extreme";
            this.extremeToolStripMenuItem.Click += new System.EventHandler(this.extremeToolStripMenuItem_Click);
            // 
            // changeNameToolStripMenuItem
            // 
            this.changeNameToolStripMenuItem.Name = "changeNameToolStripMenuItem";
            this.changeNameToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.changeNameToolStripMenuItem.Text = "Change name";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // PLAYERSSCORE_label
            // 
            this.PLAYERSSCORE_label.AutoSize = true;
            this.PLAYERSSCORE_label.Font = new System.Drawing.Font("Modern No. 20", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAYERSSCORE_label.Location = new System.Drawing.Point(515, 124);
            this.PLAYERSSCORE_label.Name = "PLAYERSSCORE_label";
            this.PLAYERSSCORE_label.Size = new System.Drawing.Size(219, 31);
            this.PLAYERSSCORE_label.TabIndex = 3;
            this.PLAYERSSCORE_label.Text = "Player\'s SCORE";
            // 
            // SCORE_label
            // 
            this.SCORE_label.AutoSize = true;
            this.SCORE_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCORE_label.Location = new System.Drawing.Point(577, 165);
            this.SCORE_label.Name = "SCORE_label";
            this.SCORE_label.Size = new System.Drawing.Size(94, 31);
            this.SCORE_label.TabIndex = 4;
            this.SCORE_label.Text = "    0    ";
            // 
            // PLAY_button
            // 
            this.PLAY_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PLAY_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAY_button.Location = new System.Drawing.Point(583, 442);
            this.PLAY_button.Name = "PLAY_button";
            this.PLAY_button.Size = new System.Drawing.Size(80, 33);
            this.PLAY_button.TabIndex = 5;
            this.PLAY_button.Text = "PLAY";
            this.PLAY_button.UseVisualStyleBackColor = false;
            this.PLAY_button.Click += new System.EventHandler(this.PLAY_button_Click);
            // 
            // TIME_label
            // 
            this.TIME_label.AutoSize = true;
            this.TIME_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TIME_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIME_label.Location = new System.Drawing.Point(540, 359);
            this.TIME_label.Name = "TIME_label";
            this.TIME_label.Size = new System.Drawing.Size(100, 42);
            this.TIME_label.TabIndex = 6;
            this.TIME_label.Text = "TIME";
            // 
            // TIME3_label
            // 
            this.TIME3_label.AutoSize = true;
            this.TIME3_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIME3_label.Location = new System.Drawing.Point(646, 367);
            this.TIME3_label.Name = "TIME3_label";
            this.TIME3_label.Size = new System.Drawing.Size(51, 31);
            this.TIME3_label.TabIndex = 7;
            this.TIME3_label.Text = "00 ";
            // 
            // BLOCK_checkbox
            // 
            this.BLOCK_checkbox.AutoSize = true;
            this.BLOCK_checkbox.Location = new System.Drawing.Point(528, 259);
            this.BLOCK_checkbox.Name = "BLOCK_checkbox";
            this.BLOCK_checkbox.Size = new System.Drawing.Size(53, 17);
            this.BLOCK_checkbox.TabIndex = 10;
            this.BLOCK_checkbox.Text = "Block";
            this.BLOCK_checkbox.UseVisualStyleBackColor = true;
            this.BLOCK_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BIGFOOD_checkbox
            // 
            this.BIGFOOD_checkbox.AutoSize = true;
            this.BIGFOOD_checkbox.Location = new System.Drawing.Point(528, 282);
            this.BIGFOOD_checkbox.Name = "BIGFOOD_checkbox";
            this.BIGFOOD_checkbox.Size = new System.Drawing.Size(65, 17);
            this.BIGFOOD_checkbox.TabIndex = 11;
            this.BIGFOOD_checkbox.Text = "Big food";
            this.BIGFOOD_checkbox.UseVisualStyleBackColor = true;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Silver;
            this.pbCanvas.Location = new System.Drawing.Point(0, 27);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(500, 500);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // PAUSE_button
            // 
            this.PAUSE_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PAUSE_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAUSE_button.Location = new System.Drawing.Point(570, 481);
            this.PAUSE_button.Name = "PAUSE_button";
            this.PAUSE_button.Size = new System.Drawing.Size(105, 33);
            this.PAUSE_button.TabIndex = 12;
            this.PAUSE_button.Text = "PAUSE";
            this.PAUSE_button.UseVisualStyleBackColor = false;
            this.PAUSE_button.Click += new System.EventHandler(this.PAUSE_button_Click);
            // 
            // TIME2_label
            // 
            this.TIME2_label.AutoSize = true;
            this.TIME2_label.BackColor = System.Drawing.Color.Transparent;
            this.TIME2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIME2_label.Location = new System.Drawing.Point(690, 367);
            this.TIME2_label.Name = "TIME2_label";
            this.TIME2_label.Size = new System.Drawing.Size(44, 31);
            this.TIME2_label.TabIndex = 13;
            this.TIME2_label.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(682, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = ":";
            // 
            // BOX2_picture
            // 
            this.BOX2_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BOX2_picture.Location = new System.Drawing.Point(380, 190);
            this.BOX2_picture.Name = "BOX2_picture";
            this.BOX2_picture.Size = new System.Drawing.Size(36, 160);
            this.BOX2_picture.TabIndex = 19;
            this.BOX2_picture.TabStop = false;
            this.BOX2_picture.Visible = false;
            // 
            // BOX1_picture
            // 
            this.BOX1_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BOX1_picture.Location = new System.Drawing.Point(160, 70);
            this.BOX1_picture.Name = "BOX1_picture";
            this.BOX1_picture.Size = new System.Drawing.Size(160, 36);
            this.BOX1_picture.TabIndex = 20;
            this.BOX1_picture.TabStop = false;
            this.BOX1_picture.Visible = false;
            // 
            // BOX3_picture
            // 
            this.BOX3_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BOX3_picture.Location = new System.Drawing.Point(160, 450);
            this.BOX3_picture.Name = "BOX3_picture";
            this.BOX3_picture.Size = new System.Drawing.Size(160, 36);
            this.BOX3_picture.TabIndex = 21;
            this.BOX3_picture.TabStop = false;
            this.BOX3_picture.Visible = false;
            // 
            // BOX4_picture
            // 
            this.BOX4_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BOX4_picture.Location = new System.Drawing.Point(80, 190);
            this.BOX4_picture.Name = "BOX4_picture";
            this.BOX4_picture.Size = new System.Drawing.Size(36, 160);
            this.BOX4_picture.TabIndex = 22;
            this.BOX4_picture.TabStop = false;
            this.BOX4_picture.Visible = false;
            // 
            // BOX5_picture
            // 
            this.BOX5_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOX5_picture.Location = new System.Drawing.Point(244, 250);
            this.BOX5_picture.Name = "BOX5_picture";
            this.BOX5_picture.Size = new System.Drawing.Size(15, 32);
            this.BOX5_picture.TabIndex = 23;
            this.BOX5_picture.TabStop = false;
            this.BOX5_picture.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.PLAY_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(734, 531);
            this.Controls.Add(this.BOX5_picture);
            this.Controls.Add(this.BOX4_picture);
            this.Controls.Add(this.BOX3_picture);
            this.Controls.Add(this.BOX1_picture);
            this.Controls.Add(this.BOX2_picture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TIME2_label);
            this.Controls.Add(this.PAUSE_button);
            this.Controls.Add(this.BIGFOOD_checkbox);
            this.Controls.Add(this.BLOCK_checkbox);
            this.Controls.Add(this.TIME3_label);
            this.Controls.Add(this.TIME_label);
            this.Controls.Add(this.PLAY_button);
            this.Controls.Add(this.SCORE_label);
            this.Controls.Add(this.PLAYERSSCORE_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNAKE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOX2_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOX1_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOX3_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOX4_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOX5_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label PLAYERSSCORE_label;
        private System.Windows.Forms.Label SCORE_label;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extremeToolStripMenuItem;
        private System.Windows.Forms.Button PLAY_button;
        private System.Windows.Forms.Label TIME_label;
        private System.Windows.Forms.Label TIME3_label;
        private System.Windows.Forms.CheckBox BLOCK_checkbox;
        private System.Windows.Forms.CheckBox BIGFOOD_checkbox;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Button PAUSE_button;
        private System.Windows.Forms.Label TIME2_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BOX2_picture;
        private System.Windows.Forms.PictureBox BOX1_picture;
        private System.Windows.Forms.PictureBox BOX3_picture;
        private System.Windows.Forms.PictureBox BOX4_picture;
        private System.Windows.Forms.PictureBox BOX5_picture;
    }
}

