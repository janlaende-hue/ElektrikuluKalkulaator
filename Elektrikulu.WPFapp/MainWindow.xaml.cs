using System;
using System.Windows;
using System.Windows.Media;
using ElectricCostLibrary;

namespace Elektrikulu.WPFapp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = "";
            ResultText.Foreground = Brushes.Black;

            bool okPower = double.TryParse(PowerInput.Text, out double powerWatts);
            bool okHours = double.TryParse(HoursInput.Text, out double hoursPerDay);
            bool okPrice = double.TryParse(PriceInput.Text, out double pricePerKwh);

            if (!okPower || !okHours || !okPrice)
            {
                ResultText.Foreground = Brushes.Red;
                ResultText.Text = "Peab olema arvuline väärtus.";
                return;
            }

            string error = ElectricCostCalculator.ValidateInputs(powerWatts, hoursPerDay, pricePerKwh);

            if (error != null)
            {
                ResultText.Foreground = Brushes.Red;
                ResultText.Text = error;
                return;
            }

            double cost = ElectricCostCalculator.CalculateMonthlyCost(powerWatts, hoursPerDay, pricePerKwh);

            ResultText.Foreground = Brushes.Black;
            ResultText.Text = $"Kulu 30 päeva jooksul: {cost} €";
        }
    }
}
