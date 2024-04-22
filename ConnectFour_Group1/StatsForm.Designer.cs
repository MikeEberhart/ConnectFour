namespace Connect4Testing
{
    partial class StatsForm
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
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.lbl_TotalPlayerWins = new System.Windows.Forms.Label();
            this.lbl_TotalComputerWins = new System.Windows.Forms.Label();
            this.lbl_TotalWins = new System.Windows.Forms.Label();
            this.lbl_TotalNumOfGames = new System.Windows.Forms.Label();
            this.lbl_PlayerWinPercentage = new System.Windows.Forms.Label();
            this.lbl_ComputerWinPercentage = new System.Windows.Forms.Label();
            this.txt_TotalPlayerWins = new System.Windows.Forms.TextBox();
            this.txt_TotalCompWins = new System.Windows.Forms.TextBox();
            this.txt_TotalTies = new System.Windows.Forms.TextBox();
            this.txt_TotalNumOfGames = new System.Windows.Forms.TextBox();
            this.txt_PlayerWinPercentage = new System.Windows.Forms.TextBox();
            this.txt_CompWinPercentage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenu.Location = new System.Drawing.Point(61, 248);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(123, 48);
            this.btn_MainMenu.TabIndex = 0;
            this.btn_MainMenu.Text = "Main Menu";
            this.btn_MainMenu.UseVisualStyleBackColor = false;
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(190, 248);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(123, 48);
            this.btn_Quit.TabIndex = 1;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // lbl_TotalPlayerWins
            // 
            this.lbl_TotalPlayerWins.AutoSize = true;
            this.lbl_TotalPlayerWins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TotalPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPlayerWins.Location = new System.Drawing.Point(64, 37);
            this.lbl_TotalPlayerWins.Name = "lbl_TotalPlayerWins";
            this.lbl_TotalPlayerWins.Size = new System.Drawing.Size(170, 22);
            this.lbl_TotalPlayerWins.TabIndex = 2;
            this.lbl_TotalPlayerWins.Text = "Total Player Wins ->";
            // 
            // lbl_TotalComputerWins
            // 
            this.lbl_TotalComputerWins.AutoSize = true;
            this.lbl_TotalComputerWins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TotalComputerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalComputerWins.Location = new System.Drawing.Point(45, 101);
            this.lbl_TotalComputerWins.Name = "lbl_TotalComputerWins";
            this.lbl_TotalComputerWins.Size = new System.Drawing.Size(189, 22);
            this.lbl_TotalComputerWins.TabIndex = 3;
            this.lbl_TotalComputerWins.Text = "Total Comuter Wins ->";
            // 
            // lbl_TotalWins
            // 
            this.lbl_TotalWins.AutoSize = true;
            this.lbl_TotalWins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TotalWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalWins.Location = new System.Drawing.Point(124, 165);
            this.lbl_TotalWins.Name = "lbl_TotalWins";
            this.lbl_TotalWins.Size = new System.Drawing.Size(110, 22);
            this.lbl_TotalWins.TabIndex = 4;
            this.lbl_TotalWins.Text = "Total Ties ->";
            // 
            // lbl_TotalNumOfGames
            // 
            this.lbl_TotalNumOfGames.AutoSize = true;
            this.lbl_TotalNumOfGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TotalNumOfGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalNumOfGames.Location = new System.Drawing.Point(12, 197);
            this.lbl_TotalNumOfGames.Name = "lbl_TotalNumOfGames";
            this.lbl_TotalNumOfGames.Size = new System.Drawing.Size(222, 22);
            this.lbl_TotalNumOfGames.TabIndex = 5;
            this.lbl_TotalNumOfGames.Text = "Total Number of Games ->";
            // 
            // lbl_PlayerWinPercentage
            // 
            this.lbl_PlayerWinPercentage.AutoSize = true;
            this.lbl_PlayerWinPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_PlayerWinPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerWinPercentage.Location = new System.Drawing.Point(131, 69);
            this.lbl_PlayerWinPercentage.Name = "lbl_PlayerWinPercentage";
            this.lbl_PlayerWinPercentage.Size = new System.Drawing.Size(103, 22);
            this.lbl_PlayerWinPercentage.TabIndex = 6;
            this.lbl_PlayerWinPercentage.Text = "<- Win % ->";
            // 
            // lbl_ComputerWinPercentage
            // 
            this.lbl_ComputerWinPercentage.AutoSize = true;
            this.lbl_ComputerWinPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ComputerWinPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ComputerWinPercentage.Location = new System.Drawing.Point(131, 133);
            this.lbl_ComputerWinPercentage.Name = "lbl_ComputerWinPercentage";
            this.lbl_ComputerWinPercentage.Size = new System.Drawing.Size(103, 22);
            this.lbl_ComputerWinPercentage.TabIndex = 7;
            this.lbl_ComputerWinPercentage.Text = "<- Win % ->";
            // 
            // txt_TotalPlayerWins
            // 
            this.txt_TotalPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalPlayerWins.Location = new System.Drawing.Point(238, 34);
            this.txt_TotalPlayerWins.Name = "txt_TotalPlayerWins";
            this.txt_TotalPlayerWins.ReadOnly = true;
            this.txt_TotalPlayerWins.Size = new System.Drawing.Size(75, 26);
            this.txt_TotalPlayerWins.TabIndex = 8;
            this.txt_TotalPlayerWins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalCompWins
            // 
            this.txt_TotalCompWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalCompWins.Location = new System.Drawing.Point(238, 98);
            this.txt_TotalCompWins.Name = "txt_TotalCompWins";
            this.txt_TotalCompWins.ReadOnly = true;
            this.txt_TotalCompWins.Size = new System.Drawing.Size(75, 26);
            this.txt_TotalCompWins.TabIndex = 9;
            this.txt_TotalCompWins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalTies
            // 
            this.txt_TotalTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalTies.Location = new System.Drawing.Point(238, 162);
            this.txt_TotalTies.Name = "txt_TotalTies";
            this.txt_TotalTies.ReadOnly = true;
            this.txt_TotalTies.Size = new System.Drawing.Size(75, 26);
            this.txt_TotalTies.TabIndex = 10;
            this.txt_TotalTies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalNumOfGames
            // 
            this.txt_TotalNumOfGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalNumOfGames.Location = new System.Drawing.Point(238, 194);
            this.txt_TotalNumOfGames.Name = "txt_TotalNumOfGames";
            this.txt_TotalNumOfGames.ReadOnly = true;
            this.txt_TotalNumOfGames.Size = new System.Drawing.Size(75, 26);
            this.txt_TotalNumOfGames.TabIndex = 11;
            this.txt_TotalNumOfGames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_PlayerWinPercentage
            // 
            this.txt_PlayerWinPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PlayerWinPercentage.Location = new System.Drawing.Point(238, 66);
            this.txt_PlayerWinPercentage.Name = "txt_PlayerWinPercentage";
            this.txt_PlayerWinPercentage.ReadOnly = true;
            this.txt_PlayerWinPercentage.Size = new System.Drawing.Size(75, 26);
            this.txt_PlayerWinPercentage.TabIndex = 12;
            this.txt_PlayerWinPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_CompWinPercentage
            // 
            this.txt_CompWinPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CompWinPercentage.Location = new System.Drawing.Point(238, 130);
            this.txt_CompWinPercentage.Name = "txt_CompWinPercentage";
            this.txt_CompWinPercentage.ReadOnly = true;
            this.txt_CompWinPercentage.Size = new System.Drawing.Size(75, 26);
            this.txt_CompWinPercentage.TabIndex = 13;
            this.txt_CompWinPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::Connect4Testing.Properties.Resources.c4pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 328);
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
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_MainMenu);
            this.DoubleBuffered = true;
            this.Name = "StatsForm";
            this.Text = "Statistics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Label lbl_TotalPlayerWins;
        private System.Windows.Forms.Label lbl_TotalComputerWins;
        private System.Windows.Forms.Label lbl_TotalWins;
        private System.Windows.Forms.Label lbl_TotalNumOfGames;
        private System.Windows.Forms.Label lbl_PlayerWinPercentage;
        private System.Windows.Forms.Label lbl_ComputerWinPercentage;
        private System.Windows.Forms.TextBox txt_TotalPlayerWins;
        private System.Windows.Forms.TextBox txt_TotalCompWins;
        private System.Windows.Forms.TextBox txt_TotalTies;
        private System.Windows.Forms.TextBox txt_TotalNumOfGames;
        private System.Windows.Forms.TextBox txt_PlayerWinPercentage;
        private System.Windows.Forms.TextBox txt_CompWinPercentage;
    }
}