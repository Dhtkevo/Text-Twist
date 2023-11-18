namespace KevinMaduProject2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            displayTxtbox = new TextBox();
            userWordTxtbox = new TextBox();
            letterBtn1 = new Button();
            letterBtn2 = new Button();
            letterBtn3 = new Button();
            letterBtn4 = new Button();
            letterBtn5 = new Button();
            letterBtn6 = new Button();
            letterBtn7 = new Button();
            submitWordBtn = new Button();
            validWordLbl = new Label();
            invalidWordLbl = new Label();
            scoreLbl = new Label();
            duplicateWordLbl = new Label();
            timerLbl = new Label();
            menuStrip1 = new MenuStrip();
            gameToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            exitGameToolStripMenuItem = new ToolStripMenuItem();
            timerToolStripMenuItem = new ToolStripMenuItem();
            oneMinuteMenuItem = new ToolStripMenuItem();
            twoMinutesMenuItem = new ToolStripMenuItem();
            threeMinutesMenuItem = new ToolStripMenuItem();
            twistLettersMenuItem = new ToolStripMenuItem();
            highScoreToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // displayTxtbox
            // 
            displayTxtbox.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            displayTxtbox.Location = new Point(127, 50);
            displayTxtbox.Multiline = true;
            displayTxtbox.Name = "displayTxtbox";
            displayTxtbox.ReadOnly = true;
            displayTxtbox.ScrollBars = ScrollBars.Vertical;
            displayTxtbox.Size = new Size(536, 169);
            displayTxtbox.TabIndex = 0;
            // 
            // userWordTxtbox
            // 
            userWordTxtbox.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            userWordTxtbox.Location = new Point(344, 262);
            userWordTxtbox.Name = "userWordTxtbox";
            userWordTxtbox.ReadOnly = true;
            userWordTxtbox.Size = new Size(195, 31);
            userWordTxtbox.TabIndex = 1;
            userWordTxtbox.TabStop = false;
            // 
            // letterBtn1
            // 
            letterBtn1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn1.Location = new Point(171, 314);
            letterBtn1.Name = "letterBtn1";
            letterBtn1.Size = new Size(47, 37);
            letterBtn1.TabIndex = 2;
            letterBtn1.Text = "1";
            letterBtn1.UseVisualStyleBackColor = true;
            letterBtn1.Click += letterBtn1_Click;
            // 
            // letterBtn2
            // 
            letterBtn2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn2.Location = new Point(242, 314);
            letterBtn2.Name = "letterBtn2";
            letterBtn2.Size = new Size(47, 37);
            letterBtn2.TabIndex = 3;
            letterBtn2.Text = "2";
            letterBtn2.UseVisualStyleBackColor = true;
            letterBtn2.Click += letterBtn2_Click;
            // 
            // letterBtn3
            // 
            letterBtn3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn3.Location = new Point(311, 314);
            letterBtn3.Name = "letterBtn3";
            letterBtn3.Size = new Size(47, 37);
            letterBtn3.TabIndex = 4;
            letterBtn3.Text = "3";
            letterBtn3.UseVisualStyleBackColor = true;
            letterBtn3.Click += letterBtn3_Click;
            // 
            // letterBtn4
            // 
            letterBtn4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn4.Location = new Point(376, 314);
            letterBtn4.Name = "letterBtn4";
            letterBtn4.Size = new Size(47, 37);
            letterBtn4.TabIndex = 5;
            letterBtn4.Text = "4";
            letterBtn4.UseVisualStyleBackColor = true;
            letterBtn4.Click += letterBtn4_Click;
            // 
            // letterBtn5
            // 
            letterBtn5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn5.Location = new Point(443, 314);
            letterBtn5.Name = "letterBtn5";
            letterBtn5.Size = new Size(47, 37);
            letterBtn5.TabIndex = 6;
            letterBtn5.Text = "5";
            letterBtn5.UseVisualStyleBackColor = true;
            letterBtn5.Click += letterBtn5_Click;
            // 
            // letterBtn6
            // 
            letterBtn6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn6.Location = new Point(508, 314);
            letterBtn6.Name = "letterBtn6";
            letterBtn6.Size = new Size(47, 37);
            letterBtn6.TabIndex = 7;
            letterBtn6.Text = "6";
            letterBtn6.UseVisualStyleBackColor = true;
            letterBtn6.Click += letterBtn6_Click;
            // 
            // letterBtn7
            // 
            letterBtn7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn7.Location = new Point(573, 314);
            letterBtn7.Name = "letterBtn7";
            letterBtn7.Size = new Size(47, 37);
            letterBtn7.TabIndex = 8;
            letterBtn7.Text = "7";
            letterBtn7.UseVisualStyleBackColor = true;
            letterBtn7.Click += letterBtn7_Click;
            // 
            // submitWordBtn
            // 
            submitWordBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            submitWordBtn.Location = new Point(545, 258);
            submitWordBtn.Name = "submitWordBtn";
            submitWordBtn.Size = new Size(75, 40);
            submitWordBtn.TabIndex = 9;
            submitWordBtn.Text = "Submit";
            submitWordBtn.UseVisualStyleBackColor = true;
            submitWordBtn.Click += submitWordBtn_Click;
            // 
            // validWordLbl
            // 
            validWordLbl.AutoSize = true;
            validWordLbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            validWordLbl.ForeColor = Color.LimeGreen;
            validWordLbl.Location = new Point(171, 375);
            validWordLbl.Name = "validWordLbl";
            validWordLbl.Size = new Size(236, 37);
            validWordLbl.TabIndex = 10;
            validWordLbl.Text = "90 POINTS FOR ''";
            validWordLbl.Visible = false;
            // 
            // invalidWordLbl
            // 
            invalidWordLbl.AutoSize = true;
            invalidWordLbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            invalidWordLbl.ForeColor = Color.Red;
            invalidWordLbl.Location = new Point(171, 375);
            invalidWordLbl.Name = "invalidWordLbl";
            invalidWordLbl.Size = new Size(347, 37);
            invalidWordLbl.TabIndex = 11;
            invalidWordLbl.Text = "' ' IS NOT A VALID WORD!";
            invalidWordLbl.Visible = false;
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLbl.Location = new Point(634, 263);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new Size(95, 30);
            scoreLbl.TabIndex = 12;
            scoreLbl.Text = "Score: 0";
            scoreLbl.Visible = false;
            // 
            // duplicateWordLbl
            // 
            duplicateWordLbl.AutoSize = true;
            duplicateWordLbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            duplicateWordLbl.ForeColor = Color.Red;
            duplicateWordLbl.Location = new Point(171, 375);
            duplicateWordLbl.Name = "duplicateWordLbl";
            duplicateWordLbl.Size = new Size(420, 37);
            duplicateWordLbl.TabIndex = 13;
            duplicateWordLbl.Text = "You already entered the word ''";
            duplicateWordLbl.Visible = false;
            // 
            // timerLbl
            // 
            timerLbl.AutoSize = true;
            timerLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            timerLbl.Location = new Point(3, 263);
            timerLbl.Name = "timerLbl";
            timerLbl.Size = new Size(185, 30);
            timerLbl.TabIndex = 14;
            timerLbl.Text = "Time Remaining:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem, timerToolStripMenuItem, twistLettersMenuItem, highScoreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, exitGameToolStripMenuItem });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.G;
            gameToolStripMenuItem.Size = new Size(50, 20);
            gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.N;
            newGameToolStripMenuItem.Size = new Size(171, 22);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // exitGameToolStripMenuItem
            // 
            exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            exitGameToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Q;
            exitGameToolStripMenuItem.Size = new Size(171, 22);
            exitGameToolStripMenuItem.Text = "Exit Game";
            exitGameToolStripMenuItem.Click += exitGameToolStripMenuItem_Click;
            // 
            // timerToolStripMenuItem
            // 
            timerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oneMinuteMenuItem, twoMinutesMenuItem, threeMinutesMenuItem });
            timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            timerToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.T;
            timerToolStripMenuItem.Size = new Size(49, 20);
            timerToolStripMenuItem.Text = "&Timer";
            // 
            // oneMinuteMenuItem
            // 
            oneMinuteMenuItem.Name = "oneMinuteMenuItem";
            oneMinuteMenuItem.Size = new Size(126, 22);
            oneMinuteMenuItem.Text = "1 Minute";
            oneMinuteMenuItem.Click += oneMinuteMenuItem_Click;
            // 
            // twoMinutesMenuItem
            // 
            twoMinutesMenuItem.Name = "twoMinutesMenuItem";
            twoMinutesMenuItem.Size = new Size(126, 22);
            twoMinutesMenuItem.Text = "2 Minutes";
            twoMinutesMenuItem.Click += twoMinutesMenuItem_Click;
            // 
            // threeMinutesMenuItem
            // 
            threeMinutesMenuItem.Name = "threeMinutesMenuItem";
            threeMinutesMenuItem.Size = new Size(126, 22);
            threeMinutesMenuItem.Text = "3 Minutes";
            threeMinutesMenuItem.Click += threeMinutesMenuItem_Click;
            // 
            // twistLettersMenuItem
            // 
            twistLettersMenuItem.Name = "twistLettersMenuItem";
            twistLettersMenuItem.ShortcutKeys = Keys.Alt | Keys.W;
            twistLettersMenuItem.Size = new Size(83, 20);
            twistLettersMenuItem.Text = "Twist Letters";
            twistLettersMenuItem.Click += twistLettersMenuItem_Click;
            // 
            // highScoreToolStripMenuItem
            // 
            highScoreToolStripMenuItem.Name = "highScoreToolStripMenuItem";
            highScoreToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.H;
            highScoreToolStripMenuItem.Size = new Size(77, 20);
            highScoreToolStripMenuItem.Text = "High Score";
            highScoreToolStripMenuItem.Click += highScoreToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(timerLbl);
            Controls.Add(duplicateWordLbl);
            Controls.Add(scoreLbl);
            Controls.Add(invalidWordLbl);
            Controls.Add(validWordLbl);
            Controls.Add(submitWordBtn);
            Controls.Add(letterBtn7);
            Controls.Add(letterBtn6);
            Controls.Add(letterBtn5);
            Controls.Add(letterBtn4);
            Controls.Add(letterBtn3);
            Controls.Add(letterBtn2);
            Controls.Add(letterBtn1);
            Controls.Add(userWordTxtbox);
            Controls.Add(displayTxtbox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Text Twist By Madu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox displayTxtbox;
        private TextBox userWordTxtbox;
        private Button letterBtn1;
        private Button letterBtn2;
        private Button letterBtn3;
        private Button letterBtn4;
        private Button letterBtn5;
        private Button letterBtn6;
        private Button letterBtn7;
        private Button submitWordBtn;
        private Label validWordLbl;
        private Label invalidWordLbl;
        private Label scoreLbl;
        private Label duplicateWordLbl;
        private Label timerLbl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem timerToolStripMenuItem;
        private ToolStripMenuItem oneMinuteMenuItem;
        private ToolStripMenuItem twoMinutesMenuItem;
        private ToolStripMenuItem threeMinutesMenuItem;
        private ToolStripMenuItem twistLettersMenuItem;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitGameToolStripMenuItem;
        private ToolStripMenuItem highScoreToolStripMenuItem;
    }
}