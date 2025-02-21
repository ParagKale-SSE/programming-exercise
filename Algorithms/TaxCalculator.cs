using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class TaxCalculator
    {
        public static double CalculateTax(int income)
        {
            double tax = 0.0;
            if (income <= 10000)
            {
                tax = (income * 0.1);
            }
            else if (income <= 50000)
            {
                tax = (1000 + (income - 10000) * 0.15);
            } 
            else if (income <= 100000)
            {
                tax = (7000 + (income - 50000) * 0.2);
            }
            return tax;
        }
    }
}
