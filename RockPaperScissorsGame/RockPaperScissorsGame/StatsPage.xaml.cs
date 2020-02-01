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
        int loseCounter;
        int winCounter;
        public StatsPage()
        {
            InitializeComponent();
            loseCounter = 0;
            winCounter = 0;
        }

       private void StatsButton_Clicked(object sender, EventArgs e)
        {
            LoseText.Text = "Lost: " + loseCounter;
            WinPercentageText.Text = "Win %: " + CalcWinPercentage() + "%";
        }

        public double CalcWinPercentage()
        {
            double Total = 0.0;
            double temp = 0.0;
            double result = 0.0;
            if (winCounter != 0 && loseCounter != 0)
            {
                Total = winCounter + loseCounter;
                temp = winCounter / Total;
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