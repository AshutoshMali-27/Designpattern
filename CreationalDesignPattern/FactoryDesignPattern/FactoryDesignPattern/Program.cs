using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("select the Payment gatewat(PayPal,Stripe,CreditCard):");

            string gatewayName = Console.ReadLine();
            try {

                IpaymentGateway paymentgateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
                paymentgateway.ProcessPayment(100.00M);

            }
            catch(ArgumentException ex) {
                Console.WriteLine(ex.Message);

            }
            Console.ReadKey();
        }
    }
}
