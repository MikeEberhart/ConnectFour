namespace Connect4Testing
{
    partial class GameOverForm
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
            this.btn_Quit = new System.Windows.Forms.Button();
            this.btn_Review = new System.Windows.Forms.Button();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(459, 347);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(101, 41);
            this.btn_Quit.TabIndex = 5;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // btn_Review
            // 
            this.btn_Review.Location = new System.Drawing.Point(352, 347);
            this.btn_Review.Name = "btn_Review";
            this.btn_Review.Size = new System.Drawing.Size(101, 41);
            this.btn_Review.TabIndex = 4;
            this.btn_Review.Text = "Review Game";
            this.btn_Review.UseVisualStyleBackColor = true;
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.Location = new System.Drawing.Point(245, 347);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(101, 41);
            this.btn_PlayAgain.TabIndex = 3;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = true;
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Review);
            this.Controls.Add(this.btn_PlayAgain);
            this.Name = "GameOverForm";
            this.Text = "GameOverForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameOverForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button btn_Review;
        private System.Windows.Forms.Button btn_PlayAgain;
    }
}