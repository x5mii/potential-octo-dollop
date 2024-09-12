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
        const double _firstDividendPercentage = 0.05;
        public double CalculateFirstDividend(double annualProfit, double paidInCapital, double generalReserve)
        {
            double firstDividend;
            if (paidInCapital * 0.2 >= generalReserve)
            {
                generalReserve += _firstDividendPercentage * annualProfit;
                annualProfit -= annualProfit * _firstDividendPercentage;
            }
            if (IsDividendPossible(annualProfit, paidInCapital))
            {
                firstDividend = _firstDividendPercentage * paidInCapital;
                paidInCapital -= firstDividend;
                return firstDividend;
            }
            return 0;
        }

        bool IsDividendPossible(double annualProfit, double paidInCapital)
        {
            if(paidInCapital * _firstDividendPercentage >= annualProfit)
            {
                return false;
            }
            return true;
        }
    }
}
