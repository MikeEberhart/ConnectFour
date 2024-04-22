using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4Testing
{
    public partial class StatsForm : Form
    {
        private WelcomeForm wForm;
        private readonly string statFile = "../../Resources/StatData.txt";
        private string totalPlayerWins;
        private string totalCompWins;
        private string totalTies;
        private int totalGames;
        private string[] fileText;
        private string stats;
        private double tempPlayerWin;
        private double tempCompWin;
        private double playerWinPercentage;
        private double compWinPercentage;
        private Sound Sound = new Sound();

        public StatsForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();
            ReadTxtFile();
            WriteToFile(PassData());
            wForm = wf;
        }
        public StatsForm()
        {
            InitializeComponent();
            ReadTxtFile();
        }

        private void StatsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sound.ButtonClick();
            Environment.Exit(0);
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Sound.ButtonClick();
            Environment.Exit(0);
        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            Sound.ButtonClick();
            wForm.Show();
            this.Hide();
        }
        public void ReadTxtFile()
        {
            StreamReader readFile = null;
            try
            {
                readFile = new StreamReader(statFile);

                while ((stats = readFile.ReadLine()) != null)
                {
                    fileText = stats.Split(',');
                    totalPlayerWins = fileText[0];
                    totalCompWins = fileText[2];
                    totalTies = fileText[4];
                    totalGames = int.Parse(totalPlayerWins) + int.Parse(totalCompWins) + int.Parse(totalTies);
                    tempPlayerWin = double.Parse(totalPlayerWins) / totalGames;
                    tempCompWin = double.Parse(totalCompWins) / totalGames;
                    playerWinPercentage = Math.Round(tempPlayerWin * 100, 2);
                    compWinPercentage = Math.Round(tempCompWin * 100, 2);
                }

            }
            catch(FileNotFoundException) // error if file not found
            {
                MessageBox.Show("File Not Found");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error reading file: " + e.Message);
            }
            finally
            {
                if(readFile != null)
                {
                    readFile.Dispose();
                }
            }
            readFile.Close();
            DataToTextBoxes();

        }
        public void DataToTextBoxes()
        {
            txt_TotalPlayerWins.Text = fileText[0];
            txt_PlayerWinPercentage.Text = playerWinPercentage.ToString() + "%";
            txt_TotalCompWins.Text = fileText[2];
            txt_CompWinPercentage.Text = compWinPercentage.ToString() + "%";
            txt_TotalTies.Text = fileText[4];
            txt_TotalNumOfGames.Text = totalGames.ToString();
        }
        public void WriteToFile(string[] data)
        {
            int num = 0;
            foreach (string line in data)
            {
                //Console.WriteLine(line + " Pos: " + num);
                num++;
            }
            if (data[0] != null &&
                data[1] != null &&
                data[2] != null &&
                data[3] != null &&
                data[4] != null &&
                data[5] != null)
            {
                File.WriteAllText(statFile, data[0]
                    + "," + data[1]
                    + "," + data[2]
                    + "," + data[3]
                    + "," + data[4]
                    + "," + data[5]);
            }
        }
        public string[] PassData() //passing array with the saved data to the GameOverForm
        {
            string[] passingText = { totalPlayerWins.ToString(),
                                     playerWinPercentage.ToString(),
                                     totalCompWins.ToString(),
                                     compWinPercentage.ToString(),
                                     totalTies.ToString(),
                                     totalGames.ToString() };
            return passingText;
        }
    }
}
