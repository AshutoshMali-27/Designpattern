using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withoutDesignpattern
{
    class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
        }

        public string getCardType()
        {
            return "Titanum";
        }

        public int GetCreditLimit()
        {
            return 1500;
        }
    }
}
