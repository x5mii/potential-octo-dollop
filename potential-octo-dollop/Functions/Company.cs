using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace potential_octo_dollop.Functions
{
    public class Company
    {

        public double PaidInCapital { get; set; }
        public double ParticipationCapital { get; set; }
        public double GeneralReserve { get; set; }
        public double ProfitPresentation { get; set; }
        public double DesiredDividend { get; set; }
        public double AnnualProfit { get; set; }

        public Company(double paidInCapital, 
            double generalReserve,
            double profitPresentation,
            double desiredDividend,
            double annualProfit,
            double participationCapital)
        {
            PaidInCapital = paidInCapital;
            GeneralReserve = generalReserve;
            ProfitPresentation = profitPresentation;
            DesiredDividend = desiredDividend;
            AnnualProfit = annualProfit;
            ParticipationCapital = participationCapital;
        }
    }
}
