using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public  interface IpaymentGateway
    {
        void ProcessPayment(decimal amount);
    }

    public class PayPalGateway : IpaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing {amount} payment ThorThrough Paypal..");
        }
    }
    public class StripeGateway : IpaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {

            Console.WriteLine($"Processing {amount} payment ThorThrough Stripe..");
        }
    }

    public class CreditCardGateway : IpaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing {amount} payment ThorThrough Credit Card..");
        }
    }



    public static class PaymentGatewayFactory
    {
        public static IpaymentGateway CreatePaymentGateway(string gatewayName)
        {
            switch (gatewayName.ToLower())
            {
                case "paypal":
                    return new PayPalGateway();

                case "stripe":
                    return new StripeGateway();
                case "creditcard":
                    return new CreditCardGateway();
                default:
                    throw new ArgumentException("Invalid Payment gateway specified");
            }

        }
    }
}
