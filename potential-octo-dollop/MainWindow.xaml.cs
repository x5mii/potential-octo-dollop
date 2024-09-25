using System;
using System.Windows;
using potential_octo_dollop.Functions;

namespace potential_octo_dollop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Parse input values
                double annualProfit = double.Parse(AnnualProfitInput.Text);
                double shareCapital = double.Parse(ShareCapitalInput.Text);
                double participationCapital = double.Parse(ParticipationCapitalInput.Text);
                double generalReserve = double.Parse(GeneralReserveInput.Text);
                double profitPresentation = double.Parse(ProfitPresentationInput.Text);
                double desiredDividend = double.Parse(DesiredDividendInput.Text);

                var company = new Company(shareCapital, generalReserve, profitPresentation, desiredDividend, annualProfit, participationCapital);

                var calc = new Calculation();
                calc.CalculateResults(company);

                // Display results
                LegalReserveResult.Text = $"Legal Reserve: {calc.CalculateLegalReserve(company):C}";
                double availableProfit = calc.CalculateAvailableProfit(company, calc.CalculateLegalReserve(company));
                DividendResult.Text = $"Dividend Payout: {calc.CalculateDividend(company, availableProfit):C}";
                NewProfitPresentationResult.Text = $"New Profit Presentation: {calc.CalculateNewProfitPresentation(company, availableProfit, calc.CalculateDividend(company, availableProfit)):C}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in all fields.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
