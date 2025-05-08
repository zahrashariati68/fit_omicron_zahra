using System;

namespace VehicleRental_App
{
    public abstract class Vehicle
    {
        private string _description;
        private string _brand;
        private int _currentSpeed;
        private int _maxSpeed;
        private int _enginePower;
        private Radio _carMedia;

        //user spezific constructor
        public Vehicle(string description, string brand, int enginePower, int maxSpeed)
        {
            _brand = brand;
            _enginePower = enginePower;
            _description = description;
            _maxSpeed = maxSpeed;

            _currentSpeed = 0;
            _carMedia = new Radio();
        }

        //public Radio CarMedia { get { return _carMedia; } }

        public void ChangeMediaPower(bool isPowerOn)
        {
            if (isPowerOn)
            {
                _carMedia.ChangeState(PowerState.On);
            }
            else
            {
                _carMedia.ChangeState(PowerState.Off);
            }
        }

        public string CurrentStationName { get { return _carMedia.StationName; } }
        
        public void MakeNoise()
        {
            _carMedia.Play();
        }

        public int CurrentSpeed
        {
            get
            {
                return _currentSpeed;
            }            
        }

        public string Brand 
        { 
            get { return _brand; }
        }

        public int EnginePower 
        { 
            get { return _enginePower; }
        }

        public int MaxSpeed 
        { 
            get { return _maxSpeed; }
        }

        public string Description 
        { 
            get { return _description; }
        }


        public bool SpeedUp(int delta)
        {
            if (_currentSpeed + delta <= _maxSpeed)
            {
                _currentSpeed += delta;
                return true;
            }

            return false;
        }

        //public virtual string GetInfoString() // virtual: customizable IF inherited. Not forced implementation for every subclass 
        //{
        //    string info = $"{_brand} - {_description}";
        //    info += $"\nPower: {_enginePower} PS [{_currentSpeed} / {_maxSpeed} km/h]";

        //    return info;
        //}

        public abstract string GetInfoString(); // abstract: customizable WHEREVER inherited. No default implementation, so we have forced polymorphism. An abstract member requires the class to be abstract, and no instances can be made from an abstract class. No real objects
        
    }
}