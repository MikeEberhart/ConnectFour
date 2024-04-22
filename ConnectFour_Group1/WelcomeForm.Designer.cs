namespace Connect4Testing
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.btn_SinglePlayer = new System.Windows.Forms.Button();
            this.btn_TwoPlayer = new System.Windows.Forms.Button();
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SinglePlayer
            // 
            this.btn_SinglePlayer.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_SinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SinglePlayer.Location = new System.Drawing.Point(90, 71);
            this.btn_SinglePlayer.Name = "btn_SinglePlayer";
            this.btn_SinglePlayer.Size = new System.Drawing.Size(134, 46);
            this.btn_SinglePlayer.TabIndex = 0;
            this.btn_SinglePlayer.Text = "Single Player";
            this.btn_SinglePlayer.UseVisualStyleBackColor = false;
            this.btn_SinglePlayer.Click += new System.EventHandler(this.btn_SinglePlayer_Click);
            // 
            // btn_TwoPlayer
            // 
            this.btn_TwoPlayer.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_TwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TwoPlayer.Location = new System.Drawing.Point(90, 124);
            this.btn_TwoPlayer.Name = "btn_TwoPlayer";
            this.btn_TwoPlayer.Size = new System.Drawing.Size(134, 46);
            this.btn_TwoPlayer.TabIndex = 1;
            this.btn_TwoPlayer.Text = "Two Player";
            this.btn_TwoPlayer.UseVisualStyleBackColor = false;
            this.btn_TwoPlayer.Click += new System.EventHandler(this.btn_TwoPlayer_Click);
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Statistics.Location = new System.Drawing.Point(90, 176);
            this.btn_Statistics.Name = "btn_Statistics";
            this.btn_Statistics.Size = new System.Drawing.Size(134, 46);
            this.btn_Statistics.TabIndex = 2;
            this.btn_Statistics.Text = "Statistics";
            this.btn_Statistics.UseVisualStyleBackColor = false;
            this.btn_Statistics.Click += new System.EventHandler(this.btn_Statistics_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to Connect Four";
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(90, 228);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(134, 46);
            this.btn_Quit.TabIndex = 5;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = global::Connect4Testing.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(311, 286);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Statistics);
            this.Controls.Add(this.btn_TwoPlayer);
            this.Controls.Add(this.btn_SinglePlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeForm";
            this.Text = "Welcome to Connect Four";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SinglePlayer;
        private System.Windows.Forms.Button btn_TwoPlayer;
        private System.Windows.Forms.Button btn_Statistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Quit;
    }
}

