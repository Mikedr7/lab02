using System;

namespace ClassLibrary5
{
    public class Vehicle
    {
        protected decimal Price;
        protected double Speed;
        protected int YearOfRelease;
        public Vehicle() { }
        public Vehicle(decimal Price, double Speed, int YearOfRelease)
        {
            this.Price = Price;
            this.Speed = Speed;
            this.YearOfRelease = YearOfRelease;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"\nPrice: {Price}\nSpeed: {Speed}\nYear of release: {YearOfRelease}");
        }
    }
    public class Plane : Vehicle
    {
        public int Altitude;
        public int NumbersOfPassengers;
        public Plane() { }
        public Plane(decimal Price, double Speed, int YearOfRelease, int Altitude, int NumbersOfPassengers) : base(Price, Speed, YearOfRelease)
        {
            this.Altitude = Altitude;
            this.NumbersOfPassengers = NumbersOfPassengers;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Altitude: {Altitude}\nNumbers of passengers: {NumbersOfPassengers}");
        }
    }
    public class Ship : Vehicle
    {
        public string PortOfRegistry;
        public int NumbersOfPassengers;
        public Ship() { }
        public Ship(decimal Price, double Speed, int YearOfRelease, string PortOfRegistry, int NumbersOfPassengers) : base(Price, Speed, YearOfRelease)
        {
            this.PortOfRegistry = PortOfRegistry;
            this.NumbersOfPassengers = NumbersOfPassengers;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Port of registry: {PortOfRegistry}\nNumbers of passengers: {NumbersOfPassengers}");
        }
    }
    public class Car : Vehicle {
        public Car() { }
        public Car(decimal Price, double Speed, int YearOfRelease) : base(Price, Speed, YearOfRelease) { }
    }
}
