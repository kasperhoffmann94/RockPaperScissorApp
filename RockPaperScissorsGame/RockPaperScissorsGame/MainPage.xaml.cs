using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RockPaperScissorsGame
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<string> hands;
        Picker picker;
        string computerChoice;
        int wincounter;
        int loseCounter;
        int drawCounter;
        StatsPage stats;
        public MainPage()
        {
            InitializeComponent();
            hands = new List<string>();
            FillHandsPicker();
            SetPicker();
            computerChoice = "";
            wincounter = 0;
            loseCounter = 0;
            drawCounter = 0;
            stats = new StatsPage();
            
             
        }

        public void FillHandsPicker()
        {
            hands.Add("Rock");
            hands.Add("Paper");
            hands.Add("Scissors");
        }

        public void SetPicker()
        {
            picker = HandsPicker;
            picker.ItemsSource = hands;
        }

        public void BattleButton_Clicked(object sender, EventArgs args)
        {
          
            computerChoice = GenerateComputerMove();
            ShowComputerChoice();

            if (HandsPicker.SelectedIndex != -1)
            {
                if  (computerChoice == "Paper" && HandsPicker.SelectedItem.ToString() == "Rock")
                {
                    ResultText.Text = "Computer Wins!";

                }
                else if (computerChoice == "Paper" && HandsPicker.SelectedItem.ToString() == "Scissors")
                {
                    ResultText.Text = "Player Wins!";
                    wincounter++;
                    WinText.Text = "Wins: " + wincounter;
                   // WinPercentageText.Text = "Win %: " + CalcWinPercentage() + "%";
                }
                else if (computerChoice == "Rock" && HandsPicker.SelectedItem.ToString() == "Paper")
                {
                    ResultText.Text = "Player Wins!";
                    wincounter++;
                    WinText.Text = "Wins: " + wincounter;
                   // WinPercentageText.Text = "Win %: " + CalcWinPercentage() + "%";
                }
                else if (computerChoice == "Rock" && HandsPicker.SelectedItem.ToString() == "Scissors")
                {
                    ResultText.Text = "Computer Wins!";
                    loseCounter++;
                   // LoseText.Text = "Lost: " + loseCounter;
                    // WinPercentageText.Text = "Win %: " + CalcWinPercentage() + "%";
                }
                else if (computerChoice == "Scissors" && HandsPicker.SelectedItem.ToString() == "Paper")
                {
                    ResultText.Text = "Computer Wins!";
                    loseCounter++;
                   // LoseText.Text = "Lost: " + loseCounter;
                   // WinPercentageText.Text = "Win %: " + CalcWinPercentage() + "%";
                }
                else if (computerChoice == "Scissors" && HandsPicker.SelectedItem.ToString() == "Rock")
                {
                    ResultText.Text = "Player Wins!";
                    wincounter++;
                    WinText.Text = "Wins: " + wincounter;
                   // WinPercentageText.Text = "Win %: " + CalcWinPercentage() + "%";
                } else
                {
                    ResultText.Text = "DRAW!";
                    drawCounter++;
                    // DrawText.Text = "Draws: " + drawCounter;
                }
            } else
            {
                ResultText.Text = "Please pick a hand"; 
            }

        }

        public void ShowComputerChoice()
        {
            string choice = GenerateComputerMove();

            switch (choice)
            {
                case "Rock":
                    ComputerChoiceEntry.Text = computerChoice;
                    break;
                case "Paper":
                    ComputerChoiceEntry.Text = computerChoice;
                    break;
                case "Scissors":
                    ComputerChoiceEntry.Text = computerChoice;
                    break;
                default:
                    break;
            }
        }

        public string GenerateComputerMove()
        {
            Random rand = new Random();

            int indexInList = rand.Next(0, 3);
            string pickedMove = hands.ElementAt(indexInList);
            return pickedMove;
        }

       

        private void StatsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StatsPage());
        }
    }
}
