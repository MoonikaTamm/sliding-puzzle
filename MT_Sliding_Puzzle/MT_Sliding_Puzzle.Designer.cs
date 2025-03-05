namespace MT_Sliding_Puzzle
{
    partial class MT_Sliding_Puzzle
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
            this.MT_StartGame = new System.Windows.Forms.Button();
            this.MT_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MT_GiveUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MT_StartGame
            // 
            this.MT_StartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MT_StartGame.Location = new System.Drawing.Point(77, 31);
            this.MT_StartGame.Name = "MT_StartGame";
            this.MT_StartGame.Size = new System.Drawing.Size(225, 88);
            this.MT_StartGame.TabIndex = 0;
            this.MT_StartGame.Text = "Start Game";
            this.MT_StartGame.UseVisualStyleBackColor = false;
            this.MT_StartGame.Click += new System.EventHandler(this.MT_StartGame_Click);
            // 
            // MT_panel
            // 
            this.MT_panel.Location = new System.Drawing.Point(398, 31);
            this.MT_panel.Name = "MT_panel";
            this.MT_panel.Size = new System.Drawing.Size(510, 510);
            this.MT_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 162);
            this.label1.TabIndex = 2;
            this.label1.Text = "Put the numbers in order:\r\n 1  2  3  4\r\n 5  6  7  8\r\n 9  10 11 12\r\n 13 14 15 X\r\nX" +
    "-marking the empty slot.\r\n";
            // 
            // MT_GiveUp
            // 
            this.MT_GiveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MT_GiveUp.Location = new System.Drawing.Point(77, 157);
            this.MT_GiveUp.Name = "MT_GiveUp";
            this.MT_GiveUp.Size = new System.Drawing.Size(225, 88);
            this.MT_GiveUp.TabIndex = 3;
            this.MT_GiveUp.Text = "Give up `-´";
            this.MT_GiveUp.UseVisualStyleBackColor = false;
            this.MT_GiveUp.Click += new System.EventHandler(this.MT_GiveUp_Click);
            // 
            // MT_Sliding_Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 562);
            this.Controls.Add(this.MT_GiveUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MT_panel);
            this.Controls.Add(this.MT_StartGame);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MT_Sliding_Puzzle";
            this.Text = "Sliding Puzzle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MT_StartGame;
        private System.Windows.Forms.Panel MT_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MT_GiveUp;
    }
}

