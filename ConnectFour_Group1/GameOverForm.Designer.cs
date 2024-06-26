﻿namespace Connect4Testing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverForm));
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.btn_Review = new System.Windows.Forms.Button();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.txt_CompWinPercentage = new System.Windows.Forms.TextBox();
            this.txt_PlayerWinPercentage = new System.Windows.Forms.TextBox();
            this.txt_TotalNumOfGames = new System.Windows.Forms.TextBox();
            this.txt_TotalTies = new System.Windows.Forms.TextBox();
            this.txt_TotalCompWins = new System.Windows.Forms.TextBox();
            this.txt_TotalPlayerWins = new System.Windows.Forms.TextBox();
            this.lbl_ComputerWinPercentage = new System.Windows.Forms.Label();
            this.lbl_PlayerWinPercentage = new System.Windows.Forms.Label();
            this.lbl_TotalNumOfGames = new System.Windows.Forms.Label();
            this.lbl_TotalWins = new System.Windows.Forms.Label();
            this.lbl_TotalComputerWins = new System.Windows.Forms.Label();
            this.lbl_TotalPlayerWins = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PlayWonDisplay = new System.Windows.Forms.Label();
            this.lbl_CompWonDisplay = new System.Windows.Forms.Label();
            this.lbl_TieGameDisplay = new System.Windows.Forms.Label();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenu.Location = new System.Drawing.Point(202, 301);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(141, 48);
            this.btn_MainMenu.TabIndex = 5;
            this.btn_MainMenu.Text = "Main Menu";
            this.btn_MainMenu.UseVisualStyleBackColor = false;
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            // 
            // btn_Review
            // 
            this.btn_Review.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Review.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Review.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Review.Location = new System.Drawing.Point(55, 355);
            this.btn_Review.Name = "btn_Review";
            this.btn_Review.Size = new System.Drawing.Size(141, 48);
            this.btn_Review.TabIndex = 4;
            this.btn_Review.Text = "Review Game";
            this.btn_Review.UseVisualStyleBackColor = false;
            this.btn_Review.Click += new System.EventHandler(this.btn_Review_Click);
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayAgain.Location = new System.Drawing.Point(55, 301);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(141, 48);
            this.btn_PlayAgain.TabIndex = 3;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = false;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // txt_CompWinPercentage
            // 
            this.txt_CompWinPercentage.BackColor = System.Drawing.SystemColors.Control;
            this.txt_CompWinPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CompWinPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CompWinPercentage.Location = new System.Drawing.Point(268, 196);
            this.txt_CompWinPercentage.Name = "txt_CompWinPercentage";
            this.txt_CompWinPercentage.ReadOnly = true;
            this.txt_CompWinPercentage.Size = new System.Drawing.Size(75, 26);
            this.txt_CompWinPercentage.TabIndex = 25;
            this.txt_CompWinPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_PlayerWinPercentage
            // 
            this.txt_PlayerWinPercentage.BackColor = System.Drawing.SystemColors.Control;
            this.txt_PlayerWinPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PlayerWinPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PlayerWinPercentage.Location = new System.Drawing.Point(268, 132);
            this.txt_PlayerWinPercentage.Name = "txt_PlayerWinPercentage";
            this.txt_PlayerWinPercentage.ReadOnly = true;
            this.txt_PlayerWinPercentage.Size = new System.Drawing.Size(75, 26);
            this.txt_PlayerWinPercentage.TabIndex = 24;
            this.txt_PlayerWinPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalNumOfGames
            // 
            this.txt_TotalNumOfGames.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TotalNumOfGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TotalNumOfGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalNumOfGames.Location = new System.Drawing.Point(268, 260);
            this.txt_TotalNumOfGames.Name = "txt_TotalNumOfGames";
            this.txt_TotalNumOfGames.ReadOnly = true;
            this.txt_TotalNumOfGames.Size = new System.Drawing.Size(75, 26);
            this.txt_TotalNumOfGames.TabIndex = 23;
            this.txt_TotalNumOfGames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalTies
            // 
            this.txt_TotalTies.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TotalTies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TotalTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalTies.Location = new System.Drawing.Point(268, 228);
            this.txt_TotalTies.Name = "txt_TotalTies";
            this.txt_TotalTies.ReadOnly = true;
            this.txt_TotalTies.Size = new System.Drawing.Size(75, 26);
            this.txt_TotalTies.TabIndex = 22;
            this.txt_TotalTies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalCompWins
            // 
            this.txt_TotalCompWins.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TotalCompWins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TotalCompWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalCompWins.Location = new System.Drawing.Point(268, 164);
            this.txt_TotalCompWins.Name = "txt_TotalCompWins";
            this.txt_TotalCompWins.ReadOnly = true;
            this.txt_TotalCompWins.Size = new System.Drawing.Size(75, 26);
            this.txt_TotalCompWins.TabIndex = 21;
            this.txt_TotalCompWins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalPlayerWins
            // 
            this.txt_TotalPlayerWins.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TotalPlayerWins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TotalPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalPlayerWins.Location = new System.Drawing.Point(268, 100);
            this.txt_TotalPlayerWins.Name = "txt_TotalPlayerWins";
            this.txt_TotalPlayerWins.ReadOnly = true;
            this.txt_TotalPlayerWins.Size = new System.Drawing.Size(75, 26);
            this.txt_TotalPlayerWins.TabIndex = 20;
            this.txt_TotalPlayerWins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ComputerWinPercentage
            // 
            this.lbl_ComputerWinPercentage.AutoSize = true;
            this.lbl_ComputerWinPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ComputerWinPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ComputerWinPercentage.Location = new System.Drawing.Point(99, 199);
            this.lbl_ComputerWinPercentage.Name = "lbl_ComputerWinPercentage";
            this.lbl_ComputerWinPercentage.Size = new System.Drawing.Size(165, 22);
            this.lbl_ComputerWinPercentage.TabIndex = 19;
            this.lbl_ComputerWinPercentage.Text = "Computer Win % ->";
            // 
            // lbl_PlayerWinPercentage
            // 
            this.lbl_PlayerWinPercentage.AutoSize = true;
            this.lbl_PlayerWinPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_PlayerWinPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerWinPercentage.Location = new System.Drawing.Point(128, 135);
            this.lbl_PlayerWinPercentage.Name = "lbl_PlayerWinPercentage";
            this.lbl_PlayerWinPercentage.Size = new System.Drawing.Size(136, 22);
            this.lbl_PlayerWinPercentage.TabIndex = 18;
            this.lbl_PlayerWinPercentage.Text = "Player Win % ->";
            // 
            // lbl_TotalNumOfGames
            // 
            this.lbl_TotalNumOfGames.AutoSize = true;
            this.lbl_TotalNumOfGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TotalNumOfGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalNumOfGames.Location = new System.Drawing.Point(42, 263);
            this.lbl_TotalNumOfGames.Name = "lbl_TotalNumOfGames";
            this.lbl_TotalNumOfGames.Size = new System.Drawing.Size(222, 22);
            this.lbl_TotalNumOfGames.TabIndex = 17;
            this.lbl_TotalNumOfGames.Text = "Total Number of Games ->";
            // 
            // lbl_TotalWins
            // 
            this.lbl_TotalWins.AutoSize = true;
            this.lbl_TotalWins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TotalWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalWins.Location = new System.Drawing.Point(154, 231);
            this.lbl_TotalWins.Name = "lbl_TotalWins";
            this.lbl_TotalWins.Size = new System.Drawing.Size(110, 22);
            this.lbl_TotalWins.TabIndex = 16;
            this.lbl_TotalWins.Text = "Total Ties ->";
            // 
            // lbl_TotalComputerWins
            // 
            this.lbl_TotalComputerWins.AutoSize = true;
            this.lbl_TotalComputerWins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TotalComputerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalComputerWins.Location = new System.Drawing.Point(75, 167);
            this.lbl_TotalComputerWins.Name = "lbl_TotalComputerWins";
            this.lbl_TotalComputerWins.Size = new System.Drawing.Size(189, 22);
            this.lbl_TotalComputerWins.TabIndex = 15;
            this.lbl_TotalComputerWins.Text = "Total Comuter Wins ->";
            // 
            // lbl_TotalPlayerWins
            // 
            this.lbl_TotalPlayerWins.AutoSize = true;
            this.lbl_TotalPlayerWins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TotalPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPlayerWins.Location = new System.Drawing.Point(94, 103);
            this.lbl_TotalPlayerWins.Name = "lbl_TotalPlayerWins";
            this.lbl_TotalPlayerWins.Size = new System.Drawing.Size(170, 22);
            this.lbl_TotalPlayerWins.TabIndex = 14;
            this.lbl_TotalPlayerWins.Text = "Total Player Wins ->";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Game Over";
            // 
            // lbl_PlayWonDisplay
            // 
            this.lbl_PlayWonDisplay.AutoSize = true;
            this.lbl_PlayWonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayWonDisplay.Location = new System.Drawing.Point(89, 34);
            this.lbl_PlayWonDisplay.Name = "lbl_PlayWonDisplay";
            this.lbl_PlayWonDisplay.Size = new System.Drawing.Size(237, 50);
            this.lbl_PlayWonDisplay.TabIndex = 27;
            this.lbl_PlayWonDisplay.Text = "Congratulations\r\nPlayer 1 you\'ve won!!";
            this.lbl_PlayWonDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CompWonDisplay
            // 
            this.lbl_CompWonDisplay.AutoSize = true;
            this.lbl_CompWonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompWonDisplay.Location = new System.Drawing.Point(18, 34);
            this.lbl_CompWonDisplay.Name = "lbl_CompWonDisplay";
            this.lbl_CompWonDisplay.Size = new System.Drawing.Size(370, 50);
            this.lbl_CompWonDisplay.TabIndex = 28;
            this.lbl_CompWonDisplay.Text = "The computer has outsmarted you\r\nThe AI has won!!";
            this.lbl_CompWonDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TieGameDisplay
            // 
            this.lbl_TieGameDisplay.AutoSize = true;
            this.lbl_TieGameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieGameDisplay.Location = new System.Drawing.Point(89, 34);
            this.lbl_TieGameDisplay.Name = "lbl_TieGameDisplay";
            this.lbl_TieGameDisplay.Size = new System.Drawing.Size(233, 50);
            this.lbl_TieGameDisplay.TabIndex = 29;
            this.lbl_TieGameDisplay.Text = "The game has ended\r\nin a tie!!";
            this.lbl_TieGameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TieGameDisplay.Visible = false;
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(202, 355);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(141, 48);
            this.btn_Quit.TabIndex = 30;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::Connect4Testing.Properties.Resources.c4pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(406, 414);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.lbl_TieGameDisplay);
            this.Controls.Add(this.lbl_CompWonDisplay);
            this.Controls.Add(this.lbl_PlayWonDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CompWinPercentage);
            this.Controls.Add(this.txt_PlayerWinPercentage);
            this.Controls.Add(this.txt_TotalNumOfGames);
            this.Controls.Add(this.txt_TotalTies);
            this.Controls.Add(this.txt_TotalCompWins);
            this.Controls.Add(this.txt_TotalPlayerWins);
            this.Controls.Add(this.lbl_ComputerWinPercentage);
            this.Controls.Add(this.lbl_PlayerWinPercentage);
            this.Controls.Add(this.lbl_TotalNumOfGames);
            this.Controls.Add(this.lbl_TotalWins);
            this.Controls.Add(this.lbl_TotalComputerWins);
            this.Controls.Add(this.lbl_TotalPlayerWins);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.btn_Review);
            this.Controls.Add(this.btn_PlayAgain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameOverForm";
            this.Text = "GameOverForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameOverForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.Button btn_Review;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.TextBox txt_CompWinPercentage;
        private System.Windows.Forms.TextBox txt_PlayerWinPercentage;
        private System.Windows.Forms.TextBox txt_TotalNumOfGames;
        private System.Windows.Forms.TextBox txt_TotalTies;
        private System.Windows.Forms.TextBox txt_TotalCompWins;
        private System.Windows.Forms.TextBox txt_TotalPlayerWins;
        private System.Windows.Forms.Label lbl_ComputerWinPercentage;
        private System.Windows.Forms.Label lbl_PlayerWinPercentage;
        private System.Windows.Forms.Label lbl_TotalNumOfGames;
        private System.Windows.Forms.Label lbl_TotalWins;
        private System.Windows.Forms.Label lbl_TotalComputerWins;
        private System.Windows.Forms.Label lbl_TotalPlayerWins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PlayWonDisplay;
        private System.Windows.Forms.Label lbl_CompWonDisplay;
        private System.Windows.Forms.Label lbl_TieGameDisplay;
        private System.Windows.Forms.Button btn_Quit;
    }
}