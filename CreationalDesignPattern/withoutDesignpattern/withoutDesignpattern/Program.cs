using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withoutDesignpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //string cardType="MoneyBack";
            //ICreditCard CardDetails = null;

            //if (cardType == "MoneyBack") {
            //    CardDetails = new MoneyBack();
            //}
            //else if(cardType == "Titanium")
            //{
            //    CardDetails = new Titanium();
            //}
            //else if(cardType == "Platinum")
            //{
            //    CardDetails = new Platinum();
            //}

            ICreditCard CardDetails = CreditCardFactory.GetCreditCard("Platinum");
            if (CardDetails != null)
            {
                Console.WriteLine("CardType :" + CardDetails.getCardType());
                Console.WriteLine("creditLimit :" + CardDetails.GetCreditLimit());
                Console.WriteLine("Annual Changes :" + CardDetails.GetAnnualCharge());
            }
            else
            {
               
            
                    Console.Write("Invalid Card Type");
                
            }



            Console.ReadLine();
        }
    }
}
