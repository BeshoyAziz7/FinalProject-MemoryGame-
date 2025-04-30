namespace MemoryCardGame
{
    partial class StartMenuForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewHighScores = new System.Windows.Forms.Button();
            this.groupBoxDifficulty = new System.Windows.Forms.GroupBox();
            this.radioHard = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioEasy = new System.Windows.Forms.RadioButton();
            this.btnMuteUnmute = new System.Windows.Forms.Button();
            this.groupBoxDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::MemoryCardGame.Properties.Resources._360_F_88981880_YjJManMJ6hJmKr5CZteFJAkEzXIh8mxW;
            this.btnStart.Location = new System.Drawing.Point(301, 154);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 38);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::MemoryCardGame.Properties.Resources._360_F_88981880_YjJManMJ6hJmKr5CZteFJAkEzXIh8mxW;
            this.btnExit.Location = new System.Drawing.Point(301, 257);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewHighScores
            // 
            this.btnViewHighScores.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHighScores.Image = global::MemoryCardGame.Properties.Resources._360_F_88981880_YjJManMJ6hJmKr5CZteFJAkEzXIh8mxW;
            this.btnViewHighScores.Location = new System.Drawing.Point(301, 207);
            this.btnViewHighScores.Name = "btnViewHighScores";
            this.btnViewHighScores.Size = new System.Drawing.Size(200, 34);
            this.btnViewHighScores.TabIndex = 3;
            this.btnViewHighScores.Text = "View High Scores";
            this.btnViewHighScores.UseVisualStyleBackColor = true;
            this.btnViewHighScores.Click += new System.EventHandler(this.btnViewHighScores_Click);
            // 
            // groupBoxDifficulty
            // 
            this.groupBoxDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDifficulty.Controls.Add(this.radioHard);
            this.groupBoxDifficulty.Controls.Add(this.radioMedium);
            this.groupBoxDifficulty.Controls.Add(this.radioEasy);
            this.groupBoxDifficulty.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDifficulty.Location = new System.Drawing.Point(523, 154);
            this.groupBoxDifficulty.Name = "groupBoxDifficulty";
            this.groupBoxDifficulty.Size = new System.Drawing.Size(205, 139);
            this.groupBoxDifficulty.TabIndex = 4;
            this.groupBoxDifficulty.TabStop = false;
            this.groupBoxDifficulty.Text = "Difficulty:";
            // 
            // radioHard
            // 
            this.radioHard.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioHard.AutoSize = true;
            this.radioHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioHard.Location = new System.Drawing.Point(6, 103);
            this.radioHard.Name = "radioHard";
            this.radioHard.Size = new System.Drawing.Size(145, 32);
            this.radioHard.TabIndex = 2;
            this.radioHard.Text = "Hard (16 pairs)";
            this.radioHard.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            this.radioMedium.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMedium.AutoSize = true;
            this.radioMedium.Checked = true;
            this.radioMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMedium.Location = new System.Drawing.Point(6, 63);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(169, 32);
            this.radioMedium.TabIndex = 1;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Medium (12 pairs)";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioEasy
            // 
            this.radioEasy.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioEasy.AutoSize = true;
            this.radioEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioEasy.Location = new System.Drawing.Point(6, 25);
            this.radioEasy.Name = "radioEasy";
            this.radioEasy.Size = new System.Drawing.Size(136, 32);
            this.radioEasy.TabIndex = 0;
            this.radioEasy.Text = "Easy (8 pairs)";
            this.radioEasy.UseVisualStyleBackColor = true;
            // 
            // btnMuteUnmute
            // 
            this.btnMuteUnmute.BackColor = System.Drawing.Color.Transparent;
            this.btnMuteUnmute.BackgroundImage = global::MemoryCardGame.Properties.Resources.Background;
            this.btnMuteUnmute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuteUnmute.Location = new System.Drawing.Point(12, 12);
            this.btnMuteUnmute.Name = "btnMuteUnmute";
            this.btnMuteUnmute.Size = new System.Drawing.Size(40, 36);
            this.btnMuteUnmute.TabIndex = 5;
            this.btnMuteUnmute.Text = "🔕";
            this.btnMuteUnmute.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMuteUnmute.UseVisualStyleBackColor = false;
            this.btnMuteUnmute.Click += new System.EventHandler(this.btnMuteUnmute_Click);
            // 
            // StartMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::MemoryCardGame.Properties.Resources.HomeMenu;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnMuteUnmute);
            this.Controls.Add(this.groupBoxDifficulty);
            this.Controls.Add(this.btnViewHighScores);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game - Start Menu";
            this.groupBoxDifficulty.ResumeLayout(false);
            this.groupBoxDifficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewHighScores;
        private System.Windows.Forms.GroupBox groupBoxDifficulty;
        private System.Windows.Forms.RadioButton radioHard;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioEasy;
        private System.Windows.Forms.Button btnMuteUnmute;
    }
}