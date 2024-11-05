using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withoutDesignpattern
{
    public class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 15000;
        }

        public string getCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 500;
        }
    }
}
