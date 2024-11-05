using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withoutDesignpattern
{
   public interface ICreditCard
    {
        string getCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
