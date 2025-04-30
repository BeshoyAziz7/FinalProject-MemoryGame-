namespace MemoryCardGame
{
    partial class HighScoresForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControlDifficulties = new System.Windows.Forms.TabControl();
            this.tabEasy = new System.Windows.Forms.TabPage();
            this.tabMedium = new System.Windows.Forms.TabPage();
            this.tabHard = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlDifficulties.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(2, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(337, 402);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // tabControlDifficulties
            // 
            this.tabControlDifficulties.Controls.Add(this.tabEasy);
            this.tabControlDifficulties.Controls.Add(this.tabMedium);
            this.tabControlDifficulties.Controls.Add(this.tabHard);
            this.tabControlDifficulties.Location = new System.Drawing.Point(2, 12);
            this.tabControlDifficulties.Name = "tabControlDifficulties";
            this.tabControlDifficulties.SelectedIndex = 0;
            this.tabControlDifficulties.Size = new System.Drawing.Size(231, 19);
            this.tabControlDifficulties.TabIndex = 2;
            // 
            // tabEasy
            // 
            this.tabEasy.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEasy.Location = new System.Drawing.Point(4, 22);
            this.tabEasy.Name = "tabEasy";
            this.tabEasy.Padding = new System.Windows.Forms.Padding(3);
            this.tabEasy.Size = new System.Drawing.Size(223, 0);
            this.tabEasy.TabIndex = 0;
            this.tabEasy.Text = "Easy";
            this.tabEasy.UseVisualStyleBackColor = true;
            // 
            // tabMedium
            // 
            this.tabMedium.Location = new System.Drawing.Point(4, 22);
            this.tabMedium.Name = "tabMedium";
            this.tabMedium.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedium.Size = new System.Drawing.Size(192, 0);
            this.tabMedium.TabIndex = 1;
            this.tabMedium.Text = "Medium";
            this.tabMedium.UseVisualStyleBackColor = true;
            // 
            // tabHard
            // 
            this.tabHard.Location = new System.Drawing.Point(4, 22);
            this.tabHard.Name = "tabHard";
            this.tabHard.Padding = new System.Windows.Forms.Padding(3);
            this.tabHard.Size = new System.Drawing.Size(192, 0);
            this.tabHard.TabIndex = 2;
            this.tabHard.Text = "Hard";
            this.tabHard.UseVisualStyleBackColor = true;
            // 
            // HighScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryCardGame.Properties.Resources._1000_F_1349768929_nhW0gZtapjb58pyRTPbku8rttgRxExtR;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlDifficulties);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HighScoresForm";
            this.Text = "HighScoresForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlDifficulties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControlDifficulties;
        private System.Windows.Forms.TabPage tabEasy;
        private System.Windows.Forms.TabPage tabMedium;
        private System.Windows.Forms.TabPage tabHard;
    }
}