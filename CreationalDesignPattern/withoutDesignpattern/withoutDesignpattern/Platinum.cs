using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withoutDesignpattern
{
    class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public string getCardType()
        {
            return "Platinum plus";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }
}
