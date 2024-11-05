using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorymethodDesignpattern
{
   public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }

    public class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }

    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 25000;
        }

        public string GetCardType()
        {

            return "Titanium Edge";
        }

        public int GetCreditLimit()
        {
            return 1500;
        }
    }


    public class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public string GetCardType()
        {
           return "Platinum Plus";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }

    public abstract class creditCardFactory
    {
        protected abstract ICreditCard MakeProduct();


        public ICreditCard CreateProduct()
        {
            ICreditCard creditCard = this.MakeProduct();
            return creditCard;
        }
    }

    public class PlatinumFactory : creditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard Product = new Platinum();
            return Product;
        }
    }

    public class MoneyBackFactory : creditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }

    public class TitaniumFactory : creditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}
