using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental_App
{
    public class Scooter: Vehicle
    {
        private double _weight;
        private int _stateOfCharge;
          
        public Scooter(string description, string brand, int enginePower, int maxSpeed , double weight) 
            : base(description , brand , enginePower , maxSpeed) 
        {
            _weight = weight;
            _stateOfCharge = 50;
        }

        public Scooter(string description, string brand, int enginePower, double weight)
            : this(description, brand, enginePower, 25 , weight){ }

        public double Weight
        {
            get { return _weight; }
        }
        public int StateOfCharge
        {
            get { return _stateOfCharge; }
        }
        public override string GetInfoString()       // Polymorphism
        {
            return $"{Brand} - {Description}\nState of charge: {_stateOfCharge}\nweight: {_weight} kg";
             
        }
    }
}
