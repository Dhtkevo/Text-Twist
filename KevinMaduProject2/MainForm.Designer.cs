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
            SuspendLayout();
            // 
            // displayTxtbox
            // 
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
            userWordTxtbox.Location = new Point(284, 325);
            userWordTxtbox.Name = "userWordTxtbox";
            userWordTxtbox.Size = new Size(168, 23);
            userWordTxtbox.TabIndex = 1;
            // 
            // letterBtn1
            // 
            letterBtn1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn1.Location = new Point(171, 249);
            letterBtn1.Name = "letterBtn1";
            letterBtn1.Size = new Size(47, 37);
            letterBtn1.TabIndex = 2;
            letterBtn1.Text = "1";
            letterBtn1.UseVisualStyleBackColor = true;
            // 
            // letterBtn2
            // 
            letterBtn2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn2.Location = new Point(242, 249);
            letterBtn2.Name = "letterBtn2";
            letterBtn2.Size = new Size(47, 37);
            letterBtn2.TabIndex = 3;
            letterBtn2.Text = "2";
            letterBtn2.UseVisualStyleBackColor = true;
            // 
            // letterBtn3
            // 
            letterBtn3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn3.Location = new Point(312, 249);
            letterBtn3.Name = "letterBtn3";
            letterBtn3.Size = new Size(47, 37);
            letterBtn3.TabIndex = 4;
            letterBtn3.Text = "3";
            letterBtn3.UseVisualStyleBackColor = true;
            // 
            // letterBtn4
            // 
            letterBtn4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn4.Location = new Point(388, 249);
            letterBtn4.Name = "letterBtn4";
            letterBtn4.Size = new Size(47, 37);
            letterBtn4.TabIndex = 5;
            letterBtn4.Text = "4";
            letterBtn4.UseVisualStyleBackColor = true;
            // 
            // letterBtn5
            // 
            letterBtn5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn5.Location = new Point(463, 249);
            letterBtn5.Name = "letterBtn5";
            letterBtn5.Size = new Size(47, 37);
            letterBtn5.TabIndex = 6;
            letterBtn5.Text = "5";
            letterBtn5.UseVisualStyleBackColor = true;
            // 
            // letterBtn6
            // 
            letterBtn6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn6.Location = new Point(535, 249);
            letterBtn6.Name = "letterBtn6";
            letterBtn6.Size = new Size(47, 37);
            letterBtn6.TabIndex = 7;
            letterBtn6.Text = "6";
            letterBtn6.UseVisualStyleBackColor = true;
            // 
            // letterBtn7
            // 
            letterBtn7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            letterBtn7.Location = new Point(607, 249);
            letterBtn7.Name = "letterBtn7";
            letterBtn7.Size = new Size(47, 37);
            letterBtn7.TabIndex = 8;
            letterBtn7.Text = "7";
            letterBtn7.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(letterBtn7);
            Controls.Add(letterBtn6);
            Controls.Add(letterBtn5);
            Controls.Add(letterBtn4);
            Controls.Add(letterBtn3);
            Controls.Add(letterBtn2);
            Controls.Add(letterBtn1);
            Controls.Add(userWordTxtbox);
            Controls.Add(displayTxtbox);
            Name = "MainForm";
            Text = "Text Twist By Madu";
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
    }
}