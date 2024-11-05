using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withoutDesignpattern
{
   public  class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string CardType)
        {
            ICreditCard CardDetails = null;
            if (CardType == "MoneyBack")
            {
                CardDetails = new MoneyBack();
            }
            else if (CardType == "Titaninm")
            {
                CardDetails = new Titanium();
            }
            else if (CardType == "Platinum")
            {
                CardDetails = new Platinum();
            }

            return CardDetails;
        }
    }
}
