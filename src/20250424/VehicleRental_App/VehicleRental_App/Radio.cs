using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental_App
{
   public class Radio
    {
        private PowerState _state;
        private String _stationName="Classic";
        private int _volume;

        public Radio()
        {
            _volume = 5;
            _state = PowerState.Off;
        }

        public void ChangeState(PowerState newState)
        {
            _state = newState;
        }

        public void Play()
        {
            if (_state == PowerState.On)
            {
                _volume = 20;
            }
            Console.WriteLine(" ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ");
            Console.WriteLine("Playing from channel "+StationName);
            Console.WriteLine(" ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ");
        }

        public PowerState State
        {
            get { return _state; }
        }

        public String StationName
        { 
            get { return _stationName; } 
        }

        public int Volume
        {
            set
            {
                if (value<=10 || value>=0)
                {
                    _volume = value;
                }
                 
            }
            get { return _volume; } 
        } 

    }
}
