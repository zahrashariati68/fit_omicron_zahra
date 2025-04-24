using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental_App
{
    public class Car : Vehicle
    {
		private int _seatCount;

        public Car(string description, string brand, int enginePower, int maxSpeed ,int seatCount) 
            : base(description, brand, enginePower, maxSpeed)
        {
            _seatCount = seatCount;


        }

        public int SeatCount
		{
			get { return _seatCount; } 
		}
        
        public override string GetInfoString()       // Polymorphism
        {
            string info = $"{Brand} - {Description}";
            info += $"\nPower: {EnginePower} PS [{CurrentSpeed} / {MaxSpeed} km/h]";
            info += $"\ncount of seats: {_seatCount}";
            return info;
        }
        public override string ToString()
        {
            return GetInfoString();
        }

    }
}
