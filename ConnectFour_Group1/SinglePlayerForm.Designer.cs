namespace Connect4Testing
{
    partial class SinglePlayerForm
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
            this.btn_ColumnSix = new System.Windows.Forms.Button();
            this.btn_ColumnFive = new System.Windows.Forms.Button();
            this.btn_ColumnFour = new System.Windows.Forms.Button();
            this.btn_ColumnThree = new System.Windows.Forms.Button();
            this.btn_ColumnTwo = new System.Windows.Forms.Button();
            this.btn_ColumnOne = new System.Windows.Forms.Button();
            this.btn_ColumnZero = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.pnl_BoardPanel = new System.Windows.Forms.Panel();
            this.btn_ZeroZero = new System.Windows.Forms.Button();
            this.btn_ZeroOne = new System.Windows.Forms.Button();
            this.btn_ZeroTwo = new System.Windows.Forms.Button();
            this.btn_ZeroThree = new System.Windows.Forms.Button();
            this.btn_ZeroFour = new System.Windows.Forms.Button();
            this.btn_ZeroFive = new System.Windows.Forms.Button();
            this.btn_ZeroSix = new System.Windows.Forms.Button();
            this.btn_OneZero = new System.Windows.Forms.Button();
            this.btn_OneOne = new System.Windows.Forms.Button();
            this.btn_OneTwo = new System.Windows.Forms.Button();
            this.btn_OneThree = new System.Windows.Forms.Button();
            this.btn_OneFour = new System.Windows.Forms.Button();
            this.btn_OneFive = new System.Windows.Forms.Button();
            this.btn_OneSix = new System.Windows.Forms.Button();
            this.btn_TwoZero = new System.Windows.Forms.Button();
            this.btn_TwoOne = new System.Windows.Forms.Button();
            this.btn_TwoTwo = new System.Windows.Forms.Button();
            this.btn_TwoThree = new System.Windows.Forms.Button();
            this.btn_TwoFour = new System.Windows.Forms.Button();
            this.btn_TwoFive = new System.Windows.Forms.Button();
            this.btn_TwoSix = new System.Windows.Forms.Button();
            this.btn_ThreeZero = new System.Windows.Forms.Button();
            this.btn_ThreeOne = new System.Windows.Forms.Button();
            this.btn_ThreeTwo = new System.Windows.Forms.Button();
            this.btn_ThreeThree = new System.Windows.Forms.Button();
            this.btn_ThreeFour = new System.Windows.Forms.Button();
            this.btn_ThreeFive = new System.Windows.Forms.Button();
            this.btn_ThreeSix = new System.Windows.Forms.Button();
            this.btn_FourZero = new System.Windows.Forms.Button();
            this.btn_FourOne = new System.Windows.Forms.Button();
            this.btn_FourTwo = new System.Windows.Forms.Button();
            this.btn_FourThree = new System.Windows.Forms.Button();
            this.btn_FourFour = new System.Windows.Forms.Button();
            this.btn_FourFive = new System.Windows.Forms.Button();
            this.btn_FourSix = new System.Windows.Forms.Button();
            this.btn_FiveZero = new System.Windows.Forms.Button();
            this.btn_FiveOne = new System.Windows.Forms.Button();
            this.btn_FiveTwo = new System.Windows.Forms.Button();
            this.btn_FiveThree = new System.Windows.Forms.Button();
            this.btn_FiveFour = new System.Windows.Forms.Button();
            this.btn_FiveFive = new System.Windows.Forms.Button();
            this.btn_FiveSix = new System.Windows.Forms.Button();
            this.lbl_TurnDisplay = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_BoardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ColumnSix
            // 
            this.btn_ColumnSix.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ColumnSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ColumnSix.FlatAppearance.BorderSize = 0;
            this.btn_ColumnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ColumnSix.ForeColor = System.Drawing.Color.Black;
            this.btn_ColumnSix.Location = new System.Drawing.Point(586, 438);
            this.btn_ColumnSix.Name = "btn_ColumnSix";
            this.btn_ColumnSix.Size = new System.Drawing.Size(55, 52);
            this.btn_ColumnSix.TabIndex = 64;
            this.btn_ColumnSix.Text = "Select Column";
            this.btn_ColumnSix.UseVisualStyleBackColor = false;
            this.btn_ColumnSix.Click += new System.EventHandler(this.PlacingPieces);
            this.btn_ColumnSix.MouseEnter += new System.EventHandler(this.ShowMove);
            this.btn_ColumnSix.MouseLeave += new System.EventHandler(this.HideMove);
            // 
            // btn_ColumnFive
            // 
            this.btn_ColumnFive.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ColumnFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ColumnFive.FlatAppearance.BorderSize = 0;
            this.btn_ColumnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ColumnFive.ForeColor = System.Drawing.Color.Black;
            this.btn_ColumnFive.Location = new System.Drawing.Point(494, 438);
            this.btn_ColumnFive.Name = "btn_ColumnFive";
            this.btn_ColumnFive.Size = new System.Drawing.Size(55, 52);
            this.btn_ColumnFive.TabIndex = 63;
            this.btn_ColumnFive.Text = "Select Column";
            this.btn_ColumnFive.UseVisualStyleBackColor = false;
            this.btn_ColumnFive.Click += new System.EventHandler(this.PlacingPieces);
            this.btn_ColumnFive.MouseEnter += new System.EventHandler(this.ShowMove);
            this.btn_ColumnFive.MouseLeave += new System.EventHandler(this.HideMove);
            // 
            // btn_ColumnFour
            // 
            this.btn_ColumnFour.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ColumnFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ColumnFour.FlatAppearance.BorderSize = 0;
            this.btn_ColumnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ColumnFour.ForeColor = System.Drawing.Color.Black;
            this.btn_ColumnFour.Location = new System.Drawing.Point(405, 438);
            this.btn_ColumnFour.Name = "btn_ColumnFour";
            this.btn_ColumnFour.Size = new System.Drawing.Size(55, 52);
            this.btn_ColumnFour.TabIndex = 62;
            this.btn_ColumnFour.Text = "Select Column";
            this.btn_ColumnFour.UseVisualStyleBackColor = false;
            this.btn_ColumnFour.Click += new System.EventHandler(this.PlacingPieces);
            this.btn_ColumnFour.MouseEnter += new System.EventHandler(this.ShowMove);
            this.btn_ColumnFour.MouseLeave += new System.EventHandler(this.HideMove);
            // 
            // btn_ColumnThree
            // 
            this.btn_ColumnThree.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ColumnThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ColumnThree.FlatAppearance.BorderSize = 0;
            this.btn_ColumnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ColumnThree.ForeColor = System.Drawing.Color.Black;
            this.btn_ColumnThree.Location = new System.Drawing.Point(315, 438);
            this.btn_ColumnThree.Name = "btn_ColumnThree";
            this.btn_ColumnThree.Size = new System.Drawing.Size(55, 52);
            this.btn_ColumnThree.TabIndex = 61;
            this.btn_ColumnThree.Text = "Select Column";
            this.btn_ColumnThree.UseVisualStyleBackColor = false;
            this.btn_ColumnThree.Click += new System.EventHandler(this.PlacingPieces);
            this.btn_ColumnThree.MouseEnter += new System.EventHandler(this.ShowMove);
            this.btn_ColumnThree.MouseLeave += new System.EventHandler(this.HideMove);
            // 
            // btn_ColumnTwo
            // 
            this.btn_ColumnTwo.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ColumnTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ColumnTwo.FlatAppearance.BorderSize = 0;
            this.btn_ColumnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ColumnTwo.ForeColor = System.Drawing.Color.Black;
            this.btn_ColumnTwo.Location = new System.Drawing.Point(224, 438);
            this.btn_ColumnTwo.Name = "btn_ColumnTwo";
            this.btn_ColumnTwo.Size = new System.Drawing.Size(55, 52);
            this.btn_ColumnTwo.TabIndex = 60;
            this.btn_ColumnTwo.Text = "Select Column";
            this.btn_ColumnTwo.UseVisualStyleBackColor = false;
            this.btn_ColumnTwo.Click += new System.EventHandler(this.PlacingPieces);
            this.btn_ColumnTwo.MouseEnter += new System.EventHandler(this.ShowMove);
            this.btn_ColumnTwo.MouseLeave += new System.EventHandler(this.HideMove);
            // 
            // btn_ColumnOne
            // 
            this.btn_ColumnOne.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ColumnOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ColumnOne.FlatAppearance.BorderSize = 0;
            this.btn_ColumnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ColumnOne.ForeColor = System.Drawing.Color.Black;
            this.btn_ColumnOne.Location = new System.Drawing.Point(134, 438);
            this.btn_ColumnOne.Name = "btn_ColumnOne";
            this.btn_ColumnOne.Size = new System.Drawing.Size(55, 52);
            this.btn_ColumnOne.TabIndex = 59;
            this.btn_ColumnOne.Text = "Select Column";
            this.btn_ColumnOne.UseVisualStyleBackColor = false;
            this.btn_ColumnOne.Click += new System.EventHandler(this.PlacingPieces);
            this.btn_ColumnOne.MouseEnter += new System.EventHandler(this.ShowMove);
            this.btn_ColumnOne.MouseLeave += new System.EventHandler(this.HideMove);
            // 
            // btn_ColumnZero
            // 
            this.btn_ColumnZero.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ColumnZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ColumnZero.FlatAppearance.BorderSize = 0;
            this.btn_ColumnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ColumnZero.ForeColor = System.Drawing.Color.Black;
            this.btn_ColumnZero.Location = new System.Drawing.Point(44, 438);
            this.btn_ColumnZero.Name = "btn_ColumnZero";
            this.btn_ColumnZero.Size = new System.Drawing.Size(55, 52);
            this.btn_ColumnZero.TabIndex = 58;
            this.btn_ColumnZero.Text = "Select Column";
            this.btn_ColumnZero.UseVisualStyleBackColor = false;
            this.btn_ColumnZero.Click += new System.EventHandler(this.PlacingPieces);
            this.btn_ColumnZero.MouseEnter += new System.EventHandler(this.ShowMove);
            this.btn_ColumnZero.MouseLeave += new System.EventHandler(this.HideMove);
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(452, 533);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(145, 52);
            this.btn_Quit.TabIndex = 78;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenu.Location = new System.Drawing.Point(273, 533);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(145, 52);
            this.btn_MainMenu.TabIndex = 77;
            this.btn_MainMenu.Text = "Main Menu";
            this.btn_MainMenu.UseVisualStyleBackColor = false;
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayAgain.Location = new System.Drawing.Point(92, 533);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(145, 52);
            this.btn_PlayAgain.TabIndex = 76;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = false;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // pnl_BoardPanel
            // 
            this.pnl_BoardPanel.BackgroundImage = global::Connect4Testing.Properties.Resources.board;
            this.pnl_BoardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_BoardPanel.Controls.Add(this.btn_ZeroZero);
            this.pnl_BoardPanel.Controls.Add(this.btn_ZeroOne);
            this.pnl_BoardPanel.Controls.Add(this.btn_ZeroTwo);
            this.pnl_BoardPanel.Controls.Add(this.btn_ZeroThree);
            this.pnl_BoardPanel.Controls.Add(this.btn_ZeroFour);
            this.pnl_BoardPanel.Controls.Add(this.btn_ZeroFive);
            this.pnl_BoardPanel.Controls.Add(this.btn_ZeroSix);
            this.pnl_BoardPanel.Controls.Add(this.btn_OneZero);
            this.pnl_BoardPanel.Controls.Add(this.btn_OneOne);
            this.pnl_BoardPanel.Controls.Add(this.btn_OneTwo);
            this.pnl_BoardPanel.Controls.Add(this.btn_OneThree);
            this.pnl_BoardPanel.Controls.Add(this.btn_OneFour);
            this.pnl_BoardPanel.Controls.Add(this.btn_OneFive);
            this.pnl_BoardPanel.Controls.Add(this.btn_OneSix);
            this.pnl_BoardPanel.Controls.Add(this.btn_TwoZero);
            this.pnl_BoardPanel.Controls.Add(this.btn_TwoOne);
            this.pnl_BoardPanel.Controls.Add(this.btn_TwoTwo);
            this.pnl_BoardPanel.Controls.Add(this.btn_TwoThree);
            this.pnl_BoardPanel.Controls.Add(this.btn_TwoFour);
            this.pnl_BoardPanel.Controls.Add(this.btn_TwoFive);
            this.pnl_BoardPanel.Controls.Add(this.btn_TwoSix);
            this.pnl_BoardPanel.Controls.Add(this.btn_ThreeZero);
            this.pnl_BoardPanel.Controls.Add(this.btn_ThreeOne);
            this.pnl_BoardPanel.Controls.Add(this.btn_ThreeTwo);
            this.pnl_BoardPanel.Controls.Add(this.btn_ThreeThree);
            this.pnl_BoardPanel.Controls.Add(this.btn_ThreeFour);
            this.pnl_BoardPanel.Controls.Add(this.btn_ThreeFive);
            this.pnl_BoardPanel.Controls.Add(this.btn_ThreeSix);
            this.pnl_BoardPanel.Controls.Add(this.btn_FourZero);
            this.pnl_BoardPanel.Controls.Add(this.btn_FourOne);
            this.pnl_BoardPanel.Controls.Add(this.btn_FourTwo);
            this.pnl_BoardPanel.Controls.Add(this.btn_FourThree);
            this.pnl_BoardPanel.Controls.Add(this.btn_FourFour);
            this.pnl_BoardPanel.Controls.Add(this.btn_FourFive);
            this.pnl_BoardPanel.Controls.Add(this.btn_FourSix);
            this.pnl_BoardPanel.Controls.Add(this.btn_FiveZero);
            this.pnl_BoardPanel.Controls.Add(this.btn_FiveOne);
            this.pnl_BoardPanel.Controls.Add(this.btn_FiveTwo);
            this.pnl_BoardPanel.Controls.Add(this.btn_FiveThree);
            this.pnl_BoardPanel.Controls.Add(this.btn_FiveFour);
            this.pnl_BoardPanel.Controls.Add(this.btn_FiveFive);
            this.pnl_BoardPanel.Controls.Add(this.btn_FiveSix);
            this.pnl_BoardPanel.Location = new System.Drawing.Point(12, 12);
            this.pnl_BoardPanel.Name = "pnl_BoardPanel";
            this.pnl_BoardPanel.Size = new System.Drawing.Size(662, 420);
            this.pnl_BoardPanel.TabIndex = 0;
            // 
            // btn_ZeroZero
            // 
            this.btn_ZeroZero.BackColor = System.Drawing.Color.Transparent;
            this.btn_ZeroZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ZeroZero.Enabled = false;
            this.btn_ZeroZero.FlatAppearance.BorderSize = 0;
            this.btn_ZeroZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ZeroZero.Location = new System.Drawing.Point(32, 345);
            this.btn_ZeroZero.Name = "btn_ZeroZero";
            this.btn_ZeroZero.Size = new System.Drawing.Size(55, 55);
            this.btn_ZeroZero.TabIndex = 119;
            this.btn_ZeroZero.UseVisualStyleBackColor = false;
            // 
            // btn_ZeroOne
            // 
            this.btn_ZeroOne.BackColor = System.Drawing.Color.Transparent;
            this.btn_ZeroOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ZeroOne.Enabled = false;
            this.btn_ZeroOne.FlatAppearance.BorderSize = 0;
            this.btn_ZeroOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ZeroOne.Location = new System.Drawing.Point(122, 345);
            this.btn_ZeroOne.Name = "btn_ZeroOne";
            this.btn_ZeroOne.Size = new System.Drawing.Size(55, 55);
            this.btn_ZeroOne.TabIndex = 118;
            this.btn_ZeroOne.UseVisualStyleBackColor = false;
            // 
            // btn_ZeroTwo
            // 
            this.btn_ZeroTwo.BackColor = System.Drawing.Color.Transparent;
            this.btn_ZeroTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ZeroTwo.Enabled = false;
            this.btn_ZeroTwo.FlatAppearance.BorderSize = 0;
            this.btn_ZeroTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ZeroTwo.Location = new System.Drawing.Point(212, 345);
            this.btn_ZeroTwo.Name = "btn_ZeroTwo";
            this.btn_ZeroTwo.Size = new System.Drawing.Size(55, 55);
            this.btn_ZeroTwo.TabIndex = 117;
            this.btn_ZeroTwo.UseVisualStyleBackColor = false;
            // 
            // btn_ZeroThree
            // 
            this.btn_ZeroThree.BackColor = System.Drawing.Color.Transparent;
            this.btn_ZeroThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ZeroThree.Enabled = false;
            this.btn_ZeroThree.FlatAppearance.BorderSize = 0;
            this.btn_ZeroThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ZeroThree.Location = new System.Drawing.Point(303, 345);
            this.btn_ZeroThree.Name = "btn_ZeroThree";
            this.btn_ZeroThree.Size = new System.Drawing.Size(55, 55);
            this.btn_ZeroThree.TabIndex = 116;
            this.btn_ZeroThree.UseVisualStyleBackColor = false;
            // 
            // btn_ZeroFour
            // 
            this.btn_ZeroFour.BackColor = System.Drawing.Color.Transparent;
            this.btn_ZeroFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ZeroFour.Enabled = false;
            this.btn_ZeroFour.FlatAppearance.BorderSize = 0;
            this.btn_ZeroFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ZeroFour.Location = new System.Drawing.Point(393, 345);
            this.btn_ZeroFour.Name = "btn_ZeroFour";
            this.btn_ZeroFour.Size = new System.Drawing.Size(55, 55);
            this.btn_ZeroFour.TabIndex = 115;
            this.btn_ZeroFour.UseVisualStyleBackColor = false;
            // 
            // btn_ZeroFive
            // 
            this.btn_ZeroFive.BackColor = System.Drawing.Color.Transparent;
            this.btn_ZeroFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ZeroFive.Enabled = false;
            this.btn_ZeroFive.FlatAppearance.BorderSize = 0;
            this.btn_ZeroFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ZeroFive.Location = new System.Drawing.Point(482, 345);
            this.btn_ZeroFive.Name = "btn_ZeroFive";
            this.btn_ZeroFive.Size = new System.Drawing.Size(55, 55);
            this.btn_ZeroFive.TabIndex = 114;
            this.btn_ZeroFive.UseVisualStyleBackColor = false;
            // 
            // btn_ZeroSix
            // 
            this.btn_ZeroSix.BackColor = System.Drawing.Color.Transparent;
            this.btn_ZeroSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ZeroSix.Enabled = false;
            this.btn_ZeroSix.FlatAppearance.BorderSize = 0;
            this.btn_ZeroSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ZeroSix.Location = new System.Drawing.Point(574, 345);
            this.btn_ZeroSix.Name = "btn_ZeroSix";
            this.btn_ZeroSix.Size = new System.Drawing.Size(55, 55);
            this.btn_ZeroSix.TabIndex = 113;
            this.btn_ZeroSix.UseVisualStyleBackColor = false;
            // 
            // btn_OneZero
            // 
            this.btn_OneZero.BackColor = System.Drawing.Color.Transparent;
            this.btn_OneZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OneZero.Enabled = false;
            this.btn_OneZero.FlatAppearance.BorderSize = 0;
            this.btn_OneZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OneZero.Location = new System.Drawing.Point(32, 279);
            this.btn_OneZero.Name = "btn_OneZero";
            this.btn_OneZero.Size = new System.Drawing.Size(55, 55);
            this.btn_OneZero.TabIndex = 112;
            this.btn_OneZero.UseVisualStyleBackColor = false;
            // 
            // btn_OneOne
            // 
            this.btn_OneOne.BackColor = System.Drawing.Color.Transparent;
            this.btn_OneOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OneOne.Enabled = false;
            this.btn_OneOne.FlatAppearance.BorderSize = 0;
            this.btn_OneOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OneOne.Location = new System.Drawing.Point(122, 279);
            this.btn_OneOne.Name = "btn_OneOne";
            this.btn_OneOne.Size = new System.Drawing.Size(55, 55);
            this.btn_OneOne.TabIndex = 111;
            this.btn_OneOne.UseVisualStyleBackColor = false;
            // 
            // btn_OneTwo
            // 
            this.btn_OneTwo.BackColor = System.Drawing.Color.Transparent;
            this.btn_OneTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OneTwo.Enabled = false;
            this.btn_OneTwo.FlatAppearance.BorderSize = 0;
            this.btn_OneTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OneTwo.Location = new System.Drawing.Point(212, 279);
            this.btn_OneTwo.Name = "btn_OneTwo";
            this.btn_OneTwo.Size = new System.Drawing.Size(55, 55);
            this.btn_OneTwo.TabIndex = 110;
            this.btn_OneTwo.UseVisualStyleBackColor = false;
            // 
            // btn_OneThree
            // 
            this.btn_OneThree.BackColor = System.Drawing.Color.Transparent;
            this.btn_OneThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OneThree.Enabled = false;
            this.btn_OneThree.FlatAppearance.BorderSize = 0;
            this.btn_OneThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OneThree.Location = new System.Drawing.Point(303, 279);
            this.btn_OneThree.Name = "btn_OneThree";
            this.btn_OneThree.Size = new System.Drawing.Size(55, 55);
            this.btn_OneThree.TabIndex = 109;
            this.btn_OneThree.UseVisualStyleBackColor = false;
            // 
            // btn_OneFour
            // 
            this.btn_OneFour.BackColor = System.Drawing.Color.Transparent;
            this.btn_OneFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OneFour.Enabled = false;
            this.btn_OneFour.FlatAppearance.BorderSize = 0;
            this.btn_OneFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OneFour.Location = new System.Drawing.Point(393, 279);
            this.btn_OneFour.Name = "btn_OneFour";
            this.btn_OneFour.Size = new System.Drawing.Size(55, 55);
            this.btn_OneFour.TabIndex = 108;
            this.btn_OneFour.UseVisualStyleBackColor = false;
            // 
            // btn_OneFive
            // 
            this.btn_OneFive.BackColor = System.Drawing.Color.Transparent;
            this.btn_OneFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OneFive.Enabled = false;
            this.btn_OneFive.FlatAppearance.BorderSize = 0;
            this.btn_OneFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OneFive.Location = new System.Drawing.Point(482, 279);
            this.btn_OneFive.Name = "btn_OneFive";
            this.btn_OneFive.Size = new System.Drawing.Size(55, 55);
            this.btn_OneFive.TabIndex = 107;
            this.btn_OneFive.UseVisualStyleBackColor = false;
            // 
            // btn_OneSix
            // 
            this.btn_OneSix.BackColor = System.Drawing.Color.Transparent;
            this.btn_OneSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OneSix.Enabled = false;
            this.btn_OneSix.FlatAppearance.BorderSize = 0;
            this.btn_OneSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OneSix.Location = new System.Drawing.Point(574, 279);
            this.btn_OneSix.Name = "btn_OneSix";
            this.btn_OneSix.Size = new System.Drawing.Size(55, 55);
            this.btn_OneSix.TabIndex = 106;
            this.btn_OneSix.UseVisualStyleBackColor = false;
            // 
            // btn_TwoZero
            // 
            this.btn_TwoZero.BackColor = System.Drawing.Color.Transparent;
            this.btn_TwoZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TwoZero.Enabled = false;
            this.btn_TwoZero.FlatAppearance.BorderSize = 0;
            this.btn_TwoZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TwoZero.Location = new System.Drawing.Point(32, 213);
            this.btn_TwoZero.Name = "btn_TwoZero";
            this.btn_TwoZero.Size = new System.Drawing.Size(55, 55);
            this.btn_TwoZero.TabIndex = 105;
            this.btn_TwoZero.UseVisualStyleBackColor = false;
            // 
            // btn_TwoOne
            // 
            this.btn_TwoOne.BackColor = System.Drawing.Color.Transparent;
            this.btn_TwoOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TwoOne.Enabled = false;
            this.btn_TwoOne.FlatAppearance.BorderSize = 0;
            this.btn_TwoOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TwoOne.Location = new System.Drawing.Point(122, 213);
            this.btn_TwoOne.Name = "btn_TwoOne";
            this.btn_TwoOne.Size = new System.Drawing.Size(55, 55);
            this.btn_TwoOne.TabIndex = 104;
            this.btn_TwoOne.UseVisualStyleBackColor = false;
            // 
            // btn_TwoTwo
            // 
            this.btn_TwoTwo.BackColor = System.Drawing.Color.Transparent;
            this.btn_TwoTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TwoTwo.Enabled = false;
            this.btn_TwoTwo.FlatAppearance.BorderSize = 0;
            this.btn_TwoTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TwoTwo.Location = new System.Drawing.Point(212, 213);
            this.btn_TwoTwo.Name = "btn_TwoTwo";
            this.btn_TwoTwo.Size = new System.Drawing.Size(55, 55);
            this.btn_TwoTwo.TabIndex = 103;
            this.btn_TwoTwo.UseVisualStyleBackColor = false;
            // 
            // btn_TwoThree
            // 
            this.btn_TwoThree.BackColor = System.Drawing.Color.Transparent;
            this.btn_TwoThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TwoThree.Enabled = false;
            this.btn_TwoThree.FlatAppearance.BorderSize = 0;
            this.btn_TwoThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TwoThree.Location = new System.Drawing.Point(303, 213);
            this.btn_TwoThree.Name = "btn_TwoThree";
            this.btn_TwoThree.Size = new System.Drawing.Size(55, 55);
            this.btn_TwoThree.TabIndex = 102;
            this.btn_TwoThree.UseVisualStyleBackColor = false;
            // 
            // btn_TwoFour
            // 
            this.btn_TwoFour.BackColor = System.Drawing.Color.Transparent;
            this.btn_TwoFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TwoFour.Enabled = false;
            this.btn_TwoFour.FlatAppearance.BorderSize = 0;
            this.btn_TwoFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TwoFour.Location = new System.Drawing.Point(393, 213);
            this.btn_TwoFour.Name = "btn_TwoFour";
            this.btn_TwoFour.Size = new System.Drawing.Size(55, 55);
            this.btn_TwoFour.TabIndex = 101;
            this.btn_TwoFour.UseVisualStyleBackColor = false;
            // 
            // btn_TwoFive
            // 
            this.btn_TwoFive.BackColor = System.Drawing.Color.Transparent;
            this.btn_TwoFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TwoFive.Enabled = false;
            this.btn_TwoFive.FlatAppearance.BorderSize = 0;
            this.btn_TwoFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TwoFive.Location = new System.Drawing.Point(482, 213);
            this.btn_TwoFive.Name = "btn_TwoFive";
            this.btn_TwoFive.Size = new System.Drawing.Size(55, 55);
            this.btn_TwoFive.TabIndex = 100;
            this.btn_TwoFive.UseVisualStyleBackColor = false;
            // 
            // btn_TwoSix
            // 
            this.btn_TwoSix.BackColor = System.Drawing.Color.Transparent;
            this.btn_TwoSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TwoSix.Enabled = false;
            this.btn_TwoSix.FlatAppearance.BorderSize = 0;
            this.btn_TwoSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TwoSix.Location = new System.Drawing.Point(574, 213);
            this.btn_TwoSix.Name = "btn_TwoSix";
            this.btn_TwoSix.Size = new System.Drawing.Size(55, 55);
            this.btn_TwoSix.TabIndex = 99;
            this.btn_TwoSix.UseVisualStyleBackColor = false;
            // 
            // btn_ThreeZero
            // 
            this.btn_ThreeZero.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThreeZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ThreeZero.Enabled = false;
            this.btn_ThreeZero.FlatAppearance.BorderSize = 0;
            this.btn_ThreeZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThreeZero.Location = new System.Drawing.Point(32, 147);
            this.btn_ThreeZero.Name = "btn_ThreeZero";
            this.btn_ThreeZero.Size = new System.Drawing.Size(55, 55);
            this.btn_ThreeZero.TabIndex = 98;
            this.btn_ThreeZero.UseVisualStyleBackColor = false;
            // 
            // btn_ThreeOne
            // 
            this.btn_ThreeOne.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThreeOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ThreeOne.Enabled = false;
            this.btn_ThreeOne.FlatAppearance.BorderSize = 0;
            this.btn_ThreeOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThreeOne.Location = new System.Drawing.Point(122, 147);
            this.btn_ThreeOne.Name = "btn_ThreeOne";
            this.btn_ThreeOne.Size = new System.Drawing.Size(55, 55);
            this.btn_ThreeOne.TabIndex = 97;
            this.btn_ThreeOne.UseVisualStyleBackColor = false;
            // 
            // btn_ThreeTwo
            // 
            this.btn_ThreeTwo.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThreeTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ThreeTwo.Enabled = false;
            this.btn_ThreeTwo.FlatAppearance.BorderSize = 0;
            this.btn_ThreeTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThreeTwo.Location = new System.Drawing.Point(212, 147);
            this.btn_ThreeTwo.Name = "btn_ThreeTwo";
            this.btn_ThreeTwo.Size = new System.Drawing.Size(55, 55);
            this.btn_ThreeTwo.TabIndex = 96;
            this.btn_ThreeTwo.UseVisualStyleBackColor = false;
            // 
            // btn_ThreeThree
            // 
            this.btn_ThreeThree.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThreeThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ThreeThree.Enabled = false;
            this.btn_ThreeThree.FlatAppearance.BorderSize = 0;
            this.btn_ThreeThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThreeThree.Location = new System.Drawing.Point(303, 147);
            this.btn_ThreeThree.Name = "btn_ThreeThree";
            this.btn_ThreeThree.Size = new System.Drawing.Size(55, 55);
            this.btn_ThreeThree.TabIndex = 95;
            this.btn_ThreeThree.UseVisualStyleBackColor = false;
            // 
            // btn_ThreeFour
            // 
            this.btn_ThreeFour.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThreeFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ThreeFour.Enabled = false;
            this.btn_ThreeFour.FlatAppearance.BorderSize = 0;
            this.btn_ThreeFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThreeFour.Location = new System.Drawing.Point(393, 147);
            this.btn_ThreeFour.Name = "btn_ThreeFour";
            this.btn_ThreeFour.Size = new System.Drawing.Size(55, 55);
            this.btn_ThreeFour.TabIndex = 94;
            this.btn_ThreeFour.UseVisualStyleBackColor = false;
            // 
            // btn_ThreeFive
            // 
            this.btn_ThreeFive.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThreeFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ThreeFive.Enabled = false;
            this.btn_ThreeFive.FlatAppearance.BorderSize = 0;
            this.btn_ThreeFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThreeFive.Location = new System.Drawing.Point(482, 147);
            this.btn_ThreeFive.Name = "btn_ThreeFive";
            this.btn_ThreeFive.Size = new System.Drawing.Size(55, 55);
            this.btn_ThreeFive.TabIndex = 93;
            this.btn_ThreeFive.UseVisualStyleBackColor = false;
            // 
            // btn_ThreeSix
            // 
            this.btn_ThreeSix.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThreeSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ThreeSix.Enabled = false;
            this.btn_ThreeSix.FlatAppearance.BorderSize = 0;
            this.btn_ThreeSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThreeSix.Location = new System.Drawing.Point(574, 147);
            this.btn_ThreeSix.Name = "btn_ThreeSix";
            this.btn_ThreeSix.Size = new System.Drawing.Size(55, 55);
            this.btn_ThreeSix.TabIndex = 92;
            this.btn_ThreeSix.UseVisualStyleBackColor = false;
            // 
            // btn_FourZero
            // 
            this.btn_FourZero.BackColor = System.Drawing.Color.Transparent;
            this.btn_FourZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FourZero.Enabled = false;
            this.btn_FourZero.FlatAppearance.BorderSize = 0;
            this.btn_FourZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FourZero.Location = new System.Drawing.Point(32, 82);
            this.btn_FourZero.Name = "btn_FourZero";
            this.btn_FourZero.Size = new System.Drawing.Size(55, 55);
            this.btn_FourZero.TabIndex = 91;
            this.btn_FourZero.UseVisualStyleBackColor = false;
            // 
            // btn_FourOne
            // 
            this.btn_FourOne.BackColor = System.Drawing.Color.Transparent;
            this.btn_FourOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FourOne.Enabled = false;
            this.btn_FourOne.FlatAppearance.BorderSize = 0;
            this.btn_FourOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FourOne.Location = new System.Drawing.Point(122, 82);
            this.btn_FourOne.Name = "btn_FourOne";
            this.btn_FourOne.Size = new System.Drawing.Size(55, 55);
            this.btn_FourOne.TabIndex = 90;
            this.btn_FourOne.UseVisualStyleBackColor = false;
            // 
            // btn_FourTwo
            // 
            this.btn_FourTwo.BackColor = System.Drawing.Color.Transparent;
            this.btn_FourTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FourTwo.Enabled = false;
            this.btn_FourTwo.FlatAppearance.BorderSize = 0;
            this.btn_FourTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FourTwo.Location = new System.Drawing.Point(212, 82);
            this.btn_FourTwo.Name = "btn_FourTwo";
            this.btn_FourTwo.Size = new System.Drawing.Size(55, 55);
            this.btn_FourTwo.TabIndex = 89;
            this.btn_FourTwo.UseVisualStyleBackColor = false;
            // 
            // btn_FourThree
            // 
            this.btn_FourThree.BackColor = System.Drawing.Color.Transparent;
            this.btn_FourThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FourThree.Enabled = false;
            this.btn_FourThree.FlatAppearance.BorderSize = 0;
            this.btn_FourThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FourThree.Location = new System.Drawing.Point(303, 82);
            this.btn_FourThree.Name = "btn_FourThree";
            this.btn_FourThree.Size = new System.Drawing.Size(55, 55);
            this.btn_FourThree.TabIndex = 88;
            this.btn_FourThree.UseVisualStyleBackColor = false;
            // 
            // btn_FourFour
            // 
            this.btn_FourFour.BackColor = System.Drawing.Color.Transparent;
            this.btn_FourFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FourFour.Enabled = false;
            this.btn_FourFour.FlatAppearance.BorderSize = 0;
            this.btn_FourFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FourFour.Location = new System.Drawing.Point(393, 82);
            this.btn_FourFour.Name = "btn_FourFour";
            this.btn_FourFour.Size = new System.Drawing.Size(55, 55);
            this.btn_FourFour.TabIndex = 87;
            this.btn_FourFour.UseVisualStyleBackColor = false;
            // 
            // btn_FourFive
            // 
            this.btn_FourFive.BackColor = System.Drawing.Color.Transparent;
            this.btn_FourFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FourFive.Enabled = false;
            this.btn_FourFive.FlatAppearance.BorderSize = 0;
            this.btn_FourFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FourFive.Location = new System.Drawing.Point(482, 82);
            this.btn_FourFive.Name = "btn_FourFive";
            this.btn_FourFive.Size = new System.Drawing.Size(55, 55);
            this.btn_FourFive.TabIndex = 80;
            this.btn_FourFive.UseVisualStyleBackColor = false;
            // 
            // btn_FourSix
            // 
            this.btn_FourSix.BackColor = System.Drawing.Color.Transparent;
            this.btn_FourSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FourSix.Enabled = false;
            this.btn_FourSix.FlatAppearance.BorderSize = 0;
            this.btn_FourSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FourSix.Location = new System.Drawing.Point(574, 82);
            this.btn_FourSix.Name = "btn_FourSix";
            this.btn_FourSix.Size = new System.Drawing.Size(55, 55);
            this.btn_FourSix.TabIndex = 86;
            this.btn_FourSix.UseVisualStyleBackColor = false;
            // 
            // btn_FiveZero
            // 
            this.btn_FiveZero.BackColor = System.Drawing.Color.Transparent;
            this.btn_FiveZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FiveZero.Enabled = false;
            this.btn_FiveZero.FlatAppearance.BorderSize = 0;
            this.btn_FiveZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FiveZero.Location = new System.Drawing.Point(32, 17);
            this.btn_FiveZero.Name = "btn_FiveZero";
            this.btn_FiveZero.Size = new System.Drawing.Size(55, 55);
            this.btn_FiveZero.TabIndex = 85;
            this.btn_FiveZero.UseVisualStyleBackColor = false;
            // 
            // btn_FiveOne
            // 
            this.btn_FiveOne.BackColor = System.Drawing.Color.Transparent;
            this.btn_FiveOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FiveOne.Enabled = false;
            this.btn_FiveOne.FlatAppearance.BorderSize = 0;
            this.btn_FiveOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FiveOne.Location = new System.Drawing.Point(122, 17);
            this.btn_FiveOne.Name = "btn_FiveOne";
            this.btn_FiveOne.Size = new System.Drawing.Size(55, 55);
            this.btn_FiveOne.TabIndex = 84;
            this.btn_FiveOne.UseVisualStyleBackColor = false;
            // 
            // btn_FiveTwo
            // 
            this.btn_FiveTwo.BackColor = System.Drawing.Color.Transparent;
            this.btn_FiveTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FiveTwo.Enabled = false;
            this.btn_FiveTwo.FlatAppearance.BorderSize = 0;
            this.btn_FiveTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FiveTwo.Location = new System.Drawing.Point(212, 17);
            this.btn_FiveTwo.Name = "btn_FiveTwo";
            this.btn_FiveTwo.Size = new System.Drawing.Size(55, 55);
            this.btn_FiveTwo.TabIndex = 83;
            this.btn_FiveTwo.UseVisualStyleBackColor = false;
            // 
            // btn_FiveThree
            // 
            this.btn_FiveThree.BackColor = System.Drawing.Color.Transparent;
            this.btn_FiveThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FiveThree.Enabled = false;
            this.btn_FiveThree.FlatAppearance.BorderSize = 0;
            this.btn_FiveThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FiveThree.Location = new System.Drawing.Point(303, 17);
            this.btn_FiveThree.Name = "btn_FiveThree";
            this.btn_FiveThree.Size = new System.Drawing.Size(55, 55);
            this.btn_FiveThree.TabIndex = 82;
            this.btn_FiveThree.UseVisualStyleBackColor = false;
            // 
            // btn_FiveFour
            // 
            this.btn_FiveFour.BackColor = System.Drawing.Color.Transparent;
            this.btn_FiveFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FiveFour.Enabled = false;
            this.btn_FiveFour.FlatAppearance.BorderSize = 0;
            this.btn_FiveFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FiveFour.Location = new System.Drawing.Point(393, 17);
            this.btn_FiveFour.Name = "btn_FiveFour";
            this.btn_FiveFour.Size = new System.Drawing.Size(55, 55);
            this.btn_FiveFour.TabIndex = 81;
            this.btn_FiveFour.UseVisualStyleBackColor = false;
            // 
            // btn_FiveFive
            // 
            this.btn_FiveFive.BackColor = System.Drawing.Color.Transparent;
            this.btn_FiveFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FiveFive.Enabled = false;
            this.btn_FiveFive.FlatAppearance.BorderSize = 0;
            this.btn_FiveFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FiveFive.Location = new System.Drawing.Point(482, 17);
            this.btn_FiveFive.Name = "btn_FiveFive";
            this.btn_FiveFive.Size = new System.Drawing.Size(55, 55);
            this.btn_FiveFive.TabIndex = 80;
            this.btn_FiveFive.UseVisualStyleBackColor = false;
            // 
            // btn_FiveSix
            // 
            this.btn_FiveSix.BackColor = System.Drawing.Color.Transparent;
            this.btn_FiveSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FiveSix.Enabled = false;
            this.btn_FiveSix.FlatAppearance.BorderSize = 0;
            this.btn_FiveSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FiveSix.Location = new System.Drawing.Point(574, 17);
            this.btn_FiveSix.Name = "btn_FiveSix";
            this.btn_FiveSix.Size = new System.Drawing.Size(55, 55);
            this.btn_FiveSix.TabIndex = 79;
            this.btn_FiveSix.UseVisualStyleBackColor = false;
            // 
            // lbl_TurnDisplay
            // 
            this.lbl_TurnDisplay.AutoSize = true;
            this.lbl_TurnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TurnDisplay.Location = new System.Drawing.Point(252, 497);
            this.lbl_TurnDisplay.Name = "lbl_TurnDisplay";
            this.lbl_TurnDisplay.Size = new System.Drawing.Size(184, 25);
            this.lbl_TurnDisplay.TabIndex = 80;
            this.lbl_TurnDisplay.Text = "Player One\'s Turn";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(195, 438);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(145, 52);
            this.btn_Back.TabIndex = 81;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Visible = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // SinglePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(685, 596);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_TurnDisplay);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.btn_ColumnSix);
            this.Controls.Add(this.btn_ColumnFive);
            this.Controls.Add(this.btn_ColumnFour);
            this.Controls.Add(this.btn_ColumnThree);
            this.Controls.Add(this.btn_ColumnTwo);
            this.Controls.Add(this.btn_ColumnOne);
            this.Controls.Add(this.btn_ColumnZero);
            this.Controls.Add(this.pnl_BoardPanel);
            this.Name = "SinglePlayerForm";
            this.Text = "SinglePlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SinglePlayerForm_FormClosed);
            this.Load += new System.EventHandler(this.SinglePlayerForm_Load);
            this.pnl_BoardPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_BoardPanel;
        private System.Windows.Forms.Button btn_ColumnSix;
        private System.Windows.Forms.Button btn_ColumnFive;
        private System.Windows.Forms.Button btn_ColumnFour;
        private System.Windows.Forms.Button btn_ColumnThree;
        private System.Windows.Forms.Button btn_ColumnTwo;
        private System.Windows.Forms.Button btn_ColumnOne;
        private System.Windows.Forms.Button btn_ColumnZero;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.Button btn_FiveSix;
        private System.Windows.Forms.Button btn_FourSix;
        private System.Windows.Forms.Button btn_FiveZero;
        private System.Windows.Forms.Button btn_FiveOne;
        private System.Windows.Forms.Button btn_FiveTwo;
        private System.Windows.Forms.Button btn_FiveThree;
        private System.Windows.Forms.Button btn_FiveFour;
        private System.Windows.Forms.Button btn_FiveFive;
        private System.Windows.Forms.Button btn_TwoFive;
        private System.Windows.Forms.Button btn_TwoSix;
        private System.Windows.Forms.Button btn_ThreeZero;
        private System.Windows.Forms.Button btn_ThreeOne;
        private System.Windows.Forms.Button btn_ThreeTwo;
        private System.Windows.Forms.Button btn_ThreeThree;
        private System.Windows.Forms.Button btn_ThreeFour;
        private System.Windows.Forms.Button btn_ThreeFive;
        private System.Windows.Forms.Button btn_ThreeSix;
        private System.Windows.Forms.Button btn_FourZero;
        private System.Windows.Forms.Button btn_FourOne;
        private System.Windows.Forms.Button btn_FourTwo;
        private System.Windows.Forms.Button btn_FourThree;
        private System.Windows.Forms.Button btn_FourFour;
        private System.Windows.Forms.Button btn_FourFive;
        private System.Windows.Forms.Button btn_ZeroZero;
        private System.Windows.Forms.Button btn_ZeroOne;
        private System.Windows.Forms.Button btn_ZeroTwo;
        private System.Windows.Forms.Button btn_ZeroThree;
        private System.Windows.Forms.Button btn_ZeroFour;
        private System.Windows.Forms.Button btn_ZeroFive;
        private System.Windows.Forms.Button btn_ZeroSix;
        private System.Windows.Forms.Button btn_OneZero;
        private System.Windows.Forms.Button btn_OneOne;
        private System.Windows.Forms.Button btn_OneTwo;
        private System.Windows.Forms.Button btn_OneThree;
        private System.Windows.Forms.Button btn_OneFour;
        private System.Windows.Forms.Button btn_OneFive;
        private System.Windows.Forms.Button btn_OneSix;
        private System.Windows.Forms.Button btn_TwoZero;
        private System.Windows.Forms.Button btn_TwoOne;
        private System.Windows.Forms.Button btn_TwoTwo;
        private System.Windows.Forms.Button btn_TwoThree;
        private System.Windows.Forms.Button btn_TwoFour;
        private System.Windows.Forms.Label lbl_TurnDisplay;
        private System.Windows.Forms.Button btn_Back;
    }
}