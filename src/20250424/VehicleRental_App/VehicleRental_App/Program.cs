using BetterConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vw_golf = new Car("Golf White Edition V6", "VW", 180, 220, 5);
            var carList = new Vehicle[]
                {
                    vw_golf,
                    new Car("Demo Vehicle", "Brand New" , 90, 110,3),
                    new Car("Future Edition", "Badmobile",250,280,7),
                    new Car("Vectra 2.0i", "Opel" , 110, 185, 5),
                    new Scooter("Joy Rider" , "Segway", 10 , 15.0)
                };

            vw_golf.ChangeMediaPower(true);
            //vw_golf.CarMedia.ChangeState(PowerState.On);
            foreach (var car in carList)
            {
                car.SpeedUp(100);
                Console.WriteLine(car.GetInfoString());
                Console.WriteLine();
            }
            ShowCarsAsTable(carList); 
        }

        private static void ShowCarsAsTable(Vehicle[] carList)
        {
            var table = new Table();
            table.From(carList);
            Console.WriteLine(table.ToString());
        }
    }
}
