using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle harley = new harley("Harley", "FatBoy", true);
            Car civic = new Car("Honda", "Civic", 2, false);
            Vehicle myVehicle = new Car("mazda", "3", 4, false);

            List<Vehicle> invemtory = new List<Vehicle>();
            inventory.Add(harley);
            inventory.Add(civic);

            foreach(Vehicle v in inventory)
            {
                Console.WriteLine()
            }

        }
    }

    public abstract class Vehicle
    {
        public Vehicle(String make, String model, int numWheel)
        {
            String MAke;
            String Model;
            int NumWheels;
            public Vehicle(String name, String model, int numWheels
            {
                this.Make = make;
                this.Model = model;
                this.NumWheels = numWheels;

            }
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




