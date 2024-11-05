using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactrFactorydesignpattern
{
    public class Anbstractfacgtory
    {
    }

    public interface Ibike
    {
        void GetDetails();
    }
    public interface Icar
    {
        void GetDetails();
    }

    public class RegularBike : Ibike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularBike Details");
        }
    }

    public class SportBike : Ibike
    {
        public void GetDetails()
        {
            Console.WriteLine("fetching Sportbike Details");
        }
    }

    public class RegularCar : Icar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularCar Details..");
        }
    }

    public class SportCar : Icar
    {
        public void GetDetails()
        {
            Console.WriteLine("fetching Sportcar Details");
        }
    }


    public interface IvehicalFactory
    {
        Ibike CreateBike();
        Icar CreateCar();
    }

    public class RegularVehicalFactory : IvehicalFactory
    {
        public Ibike CreateBike()
        {
            return new RegularBike();
        }

        public Icar CreateCar()
        {
            return new RegularCar();
        }
    }

    public class SportVehicalFactory : IvehicalFactory
    {
        public Ibike CreateBike()
        {
            return new SportBike();
        }

        public Icar CreateCar()
        {
            return new SportCar();
        }
    }
}
