using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace potential_octo_dollop.Functions
{
    public class Calculation
    {
        private const double ReservePercentage = 0.05;
        private const double ReserveThreshold = 0.2;

        // Main function to calculate dividend and other required outputs
        public void CalculateResults(Company company)
        {
            // Validate inputs
            if (!IsInputValid(company))
            {
                return;
            }

            // Calculate values
            double legalReserve = CalculateLegalReserve(company);
            double availableProfit = CalculateAvailableProfit(company, legalReserve);
            double dividend = CalculateDividend(company, availableProfit);
            double newProfitPresentation = CalculateNewProfitPresentation(company, availableProfit, dividend);

            // Output results
            Console.WriteLine($"Legal Reserve: {legalReserve}");
            Console.WriteLine($"Dividend Payout: {dividend}");
            Console.WriteLine($"New Profit/Loss Carryforward: {newProfitPresentation}");
        }

        // Validate all inputs
        public bool IsInputValid(Company company)
        {
            if (company.AnnualProfit < 0)
            {
                Console.WriteLine("Error: Annual profit must be positive.");
                return false;
            }

            if (company.ShareCapital <= 0)
            {
                Console.WriteLine("Error: Share capital must be greater than zero.");
                return false;
            }

            if (company.DesiredDividend < 0)
            {
                Console.WriteLine("Error: Desired dividend cannot be negative.");
                return false;
            }

            return true;
        }

        // Calculate the legal reserve
        public double CalculateLegalReserve(Company company)
        {
            double reserveThreshold = company.ShareCapital * ReserveThreshold;
            double currentReserve = company.GeneralReserve;
            double annualContribution = company.AnnualProfit * ReservePercentage;

            if (currentReserve >= reserveThreshold)
            {
                return 0;
            }

            double remainingToThreshold = reserveThreshold - currentReserve;
            return Math.Min(annualContribution, remainingToThreshold);
        }

        // Calculate the profit available for dividend payout
        public double CalculateAvailableProfit(Company company, double legalReserve)
        {
            return company.AnnualProfit - legalReserve + company.ProfitPresentation;
        }

        // Calculate the actual dividend based on the available profit
        public double CalculateDividend(Company company, double availableProfit)
        {
            if (availableProfit >= company.DesiredDividend)
            {
                return company.DesiredDividend;
            }
            else
            {
                return availableProfit; // Return the maximum possible dividend
            }
        }

        // Calculate the new profit or loss carryforward
        public double CalculateNewProfitPresentation(Company company, double availableProfit, double dividend)
        {
            return availableProfit - dividend;
        }
    }
}
