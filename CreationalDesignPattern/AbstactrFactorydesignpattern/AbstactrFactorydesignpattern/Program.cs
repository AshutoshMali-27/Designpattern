using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactrFactorydesignpattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            IvehicalFactory regularVehicalFactory = new RegularVehicalFactory();

            Ibike regularBike = regularVehicalFactory.CreateBike();
            regularBike.GetDetails();

            Icar regularCar = regularVehicalFactory.CreateCar();
            regularCar.GetDetails();


            IvehicalFactory sportsVehicleFactory = new SportVehicalFactory();
            Ibike sportBike = sportsVehicleFactory.CreateBike();
            sportBike.GetDetails();

            Icar sportCar = sportsVehicleFactory.CreateCar();
            sportCar.GetDetails();

            Console.ReadKey();
        }
        
    }
}
