using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RockPaperScissorsGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatsPage : ContentPage
    {
        int _loseCounter;
        int _winCounter;
        int _drawCounter;
        int _totalGames;
        public StatsPage(int winCounter, int loseCounter, int drawCounter)
        {
            InitializeComponent();
            _loseCounter = loseCounter;
            _winCounter = winCounter;
            _drawCounter = drawCounter;
            _totalGames = 0;
            WinText.Text = "Wins: " + _winCounter;
            LoseText.Text = "Loses: " + _loseCounter;
            DrawText.Text = "Draws: " + _drawCounter;
            TotalGamesText.Text = _winCounter + _loseCounter + _drawCounter + " total games played";
            WinPercentageText.Text = "Win %: " + CalcWinPercentage() + "%";
        }

        public double CalcWinPercentage()
        {
            double Total;
            double temp;
            double result = 0.0;
            if (_winCounter != 0 && _loseCounter != 0)
            {
                Total = _winCounter + _loseCounter;
                temp = _winCounter / Total;
                result = temp * 100;
                return Math.Round(result);
            }
            else
            {
                return Math.Round(result);
            }


        }

    }
}