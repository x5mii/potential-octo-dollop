using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace potential_octo_dollop.Functions
{
    class Company
    {
        public double PaidInCapital { get; set; }
        public double GeneralReserve { get; set; }
        public double AnnualProfit { get; set; }

        public Company(double paidInCapital, double generalReserve, double annualProfit)
        {
            PaidInCapital = paidInCapital;
            GeneralReserve = generalReserve;
            AnnualProfit = annualProfit;
        }


    }
}
