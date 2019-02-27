using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot dannyCarLot = new CarLot("Danny's Carlot");
            CarLot tommyCarLot = new CarLot("Tommy's Carlot");
            Car car1 = new Car("Sedan", 4, "CO2=001", "Lexus", "ES350", 450000);
            Car car2 = new Car("Coupe", 2, "AJ9B123", "Ferrari", "612 Scaglietti", 343809);
            Car car3 = new Car("Hatchback", 4, "RedSox", "Mazda", "Mazda3", 28000);
            Truck truck1 = new Truck("AJ3V220", "Toyota", "Tundra", 60000, 7);
            Truck truck2 = new Truck("DJ955TF", "Chevrolet", "Colorado", 650000, 9);

            dannyCarLot.AddVehicle(car3);
            dannyCarLot.AddVehicle(truck1);
            tommyCarLot.AddVehicle(car2);
            tommyCarLot.AddVehicle(truck2);
            dannyCarLot.printInventory();
            tommyCarLot.printInventory();

        }
    }

    //Listing Vehicles and names

    public class CarLot
    {
        string Name { get; set; }
        List<Vehicle> Vehicles = new List<Vehicle>();

        public CarLot(string name)
        {
            this.Name = name;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);

        }
        public void printInventory()
        {
            Console.WriteLine($"The Carlot has {Vehicles.Count} vehicles");
            //looping through all cars
            foreach (var vehicle in Vehicles)
            {
                vehicle.PrintDescription();
            }
        }

    }

    //abstract vehicle class, cannot be instantiated
    public abstract class Vehicle
    {
        public abstract string LicenseNumber { get; set; }
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract double Price { get; set; }
        public abstract void PrintDescription();
    }

public class Car : Vehicle
    //listing properties 
    {
        string Type { get; set; }
        int NumDoors { get; set; }
        public override string LicenseNumber { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override double Price { get: set; }
        public Car(string type, int NumDoors, string LicenseNumber, string make, string model, double price)

        {
            this.Type = type;
            this.NumDoors = NumDoors;
            this.LicenseNumber = LicenseNumber;
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }
        public override void PrintDescription()
        {
            Console.WriteLine("This car is a {0} {1} with a license plate {2}.It is a {3} with {4} doors. Current value is {5}", Make, Model, LicenseNumber, NumDoors, Price);
        }

    }
    public class Truck : Vehicle
    //listing properties for truck
    {
        int BedSize{ get; set; }
        public override string LicenseNumber { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override double Price { get; set; }
        public Truck(string LicenseNumber, string make, string model, double price, int bedSize)
        {
            this.LicenseNumber = LicenseNumber;
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.BedSize = bedSize;
        }
        public override void PrintDescription()
        {
            Console.WriteLine("Thos truck is a {0} {1} with license plate {2} that has a bed size of {3}. Current value is {4}", Make, Model, LicenseNumber, BedSize, Price);
        }
    }
}



