using System;

namespace ElectricCostLibrary
{
    public static class ElectricCostCalculator
    {
        public static string ValidateInputs(double powerWatts, double hoursPerDay, double pricePerKwh)
        {
            if (powerWatts <= 0)
                return "Kulu peab olema suurem kui 0 W.";

            if (hoursPerDay <= 0 || hoursPerDay > 24)
                return "Töötundide arv päevas peab olema vahemikus 0–24.";

            if (pricePerKwh <= 0)
                return "Elektri hind peab olema suurem kui 0 €/kWh.";

            return null;
        }

        public static double CalculateMonthlyCost(double powerWatts, double hoursPerDay, double pricePerKwh)
        {
            double kwhPerDay = (powerWatts / 1000.0) * hoursPerDay;
            double monthlyCost = kwhPerDay * 30 * pricePerKwh;

            return Math.Round(monthlyCost, 2);
        }
    }
}