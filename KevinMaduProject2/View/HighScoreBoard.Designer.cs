namespace KevinMaduProject2.View
{
    partial class HighScoreBoard
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
            highScoreTxtbox = new TextBox();
            sortByOverallScoreBtn = new Button();
            sortTimeandScoreBtn = new Button();
            resetHighScoreBoardBtn = new Button();
            exportStatsBtn = new Button();
            SuspendLayout();
            // 
            // highScoreTxtbox
            // 
            highScoreTxtbox.Location = new Point(134, 47);
            highScoreTxtbox.Multiline = true;
            highScoreTxtbox.Name = "highScoreTxtbox";
            highScoreTxtbox.ReadOnly = true;
            highScoreTxtbox.ScrollBars = ScrollBars.Vertical;
            highScoreTxtbox.Size = new Size(521, 224);
            highScoreTxtbox.TabIndex = 0;
            // 
            // sortByOverallScoreBtn
            // 
            sortByOverallScoreBtn.Location = new Point(134, 308);
            sortByOverallScoreBtn.Name = "sortByOverallScoreBtn";
            sortByOverallScoreBtn.Size = new Size(134, 23);
            sortByOverallScoreBtn.TabIndex = 1;
            sortByOverallScoreBtn.Text = "Sort By Overall Score";
            sortByOverallScoreBtn.UseVisualStyleBackColor = true;
            sortByOverallScoreBtn.Click += sortByOverallScoreBtn_Click;
            // 
            // sortTimeandScoreBtn
            // 
            sortTimeandScoreBtn.Location = new Point(287, 308);
            sortTimeandScoreBtn.Name = "sortTimeandScoreBtn";
            sortTimeandScoreBtn.Size = new Size(142, 23);
            sortTimeandScoreBtn.TabIndex = 2;
            sortTimeandScoreBtn.Text = "Sort By Time and Score";
            sortTimeandScoreBtn.UseVisualStyleBackColor = true;
            sortTimeandScoreBtn.Click += sortTimeandScoreBtn_Click;
            // 
            // resetHighScoreBoardBtn
            // 
            resetHighScoreBoardBtn.Location = new Point(450, 308);
            resetHighScoreBoardBtn.Name = "resetHighScoreBoardBtn";
            resetHighScoreBoardBtn.Size = new Size(134, 23);
            resetHighScoreBoardBtn.TabIndex = 3;
            resetHighScoreBoardBtn.Text = "Reset Board";
            resetHighScoreBoardBtn.UseVisualStyleBackColor = true;
            resetHighScoreBoardBtn.Click += resetHighScoreBoardBtn_Click;
            // 
            // exportStatsBtn
            // 
            exportStatsBtn.Location = new Point(287, 370);
            exportStatsBtn.Name = "exportStatsBtn";
            exportStatsBtn.Size = new Size(142, 23);
            exportStatsBtn.TabIndex = 4;
            exportStatsBtn.Text = "Export Stats";
            exportStatsBtn.UseVisualStyleBackColor = true;
            exportStatsBtn.Click += exportStatsBtn_Click;
            // 
            // HighScoreBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exportStatsBtn);
            Controls.Add(resetHighScoreBoardBtn);
            Controls.Add(sortTimeandScoreBtn);
            Controls.Add(sortByOverallScoreBtn);
            Controls.Add(highScoreTxtbox);
            Name = "HighScoreBoard";
            Text = "HighScoreBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox highScoreTxtbox;
        private Button sortByOverallScoreBtn;
        private Button sortTimeandScoreBtn;
        private Button resetHighScoreBoardBtn;
        private Button exportStatsBtn;
    }
}