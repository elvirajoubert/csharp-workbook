using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Vehicle
    {
        public Vehicle(String make, String model, int numWheel)
        {
            this.Make = make;
            this.Model = model;
            this.NumWheel = numWheel;
            this.Capacity = capacity;
        }
        public String Make { get; }
        public String Model { get; }
        public int NumWheel { get; }
        public Vehicle (String make, String model, int numWheels)
        {

            this.Make = make;
            this.Model = model;
            this.NumWheels = numWheels;


        }
    }
    public class Motorcycle : Vehicle
    {
        bool isCruiser { get; }
        public Motorcycle(String Make, String Model, String NumWheels, bool IsCruiser) : base(make, model, 2)

        {
            this.IsCruiser = IsCruiser;
        }
    }
    public class Car : Vehicle
    {
        bool IsConvertable;
        public Car(String make, String model, int numWheels, bool IsSedan) : base(make, model, numWheels) 

        {
            this.IsConvertable = IsConvertable;
        }
}
}




