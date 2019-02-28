using System;
using System.Collections.Generic;

namespace CarLot 
{
    class Program 
    {
        static void Main (string[] args) {
            CarLot Scottelder = new CarLot ("Scott Elder's Carlot");
            CarLot Covert = new CarLot ("Covert's Carlot");

            Car car1 = new Car ("MyChoice", "CO2P001", "Lexus", "ES350", "Sedan", 4, 450000);
            Car car2 = new Car ( "PowerCar", "AJ9B123", "Ferrari", "612 Scaglietti", "Coupe",2, 2343809);
            Truck truck1 = new Truck ("HeavyDuty", "AJ3V220", "Toyota", "Tundra", 7, 60000);
            Truck truck2 = new Truck ("Raptor", "DJ955TF", "Chevrolet", "Colorado", 9, 650000);

            Scottelder.addVehicle(car1);
            Covert.addVehicle(truck1);
            Covert.addVehicle(car2);
            Scottelder.addVehicle(truck2);
            Covert.lotInventory();
            Scottelder.lotInventory();

            Console.WriteLine ("{0} has these vehicles.", Scottelder.name);
            Scottelder.lotInventory();
            Console.WriteLine ("");

            Console.WriteLine ("{0} has these vehicles.", Covert.name);
            Covert.lotInventory();
            Console.WriteLine ("");

        }
    }

    //Listing Names and Vehicles
    class CarLot {
        public string name = "";
        List<Vehicle> numofCars = new List<Vehicle> ();

        public CarLot (string myName) {
            this.name = myName;
        }
        //this adds vehicle type to carlot class list
        public void addVehicle (Vehicle myVehicle) {
            numofCars.Add (myVehicle);

        }
        public void lotInventory () 
        {
            Console.WriteLine ("There are {0} on the CarLot.", numofCars.Count);
            
            //looping through all cars
            foreach (Vehicle item in numofCars) {
                item.printDescription ();
                Console.WriteLine ("");
            }
        }

    }

    //abstract vehicle class, cannot be instantiated
    public abstract class Vehicle {
        public string licenseNumber;
        public string vehicleMake;
        public string vehicleModel;
        public double vehiclePrice;
        public string vehicleDescription;

        //this method printsdetails about all vehicles
        virtual public void printDescription () {
            Console.WriteLine ("Vehicle Description: {0}", this.vehicleDescription);
            Console.WriteLine ("License number : {0}", this.licenseNumber);
            Console.WriteLine ("Make : {0}", this.vehicleMake);
            Console.WriteLine ("Model : {0}", this.vehicleModel);
            Console.WriteLine ("The price of of the vehicle is ${0}", this.vehiclePrice);
        }

    }

    // overriding from the base object class
    class Car : Vehicle
    //listing properties of a car
    {
        
        int numberofDoors = 2;
        string vehicleType = "";

          //constructor for car
        public Car (string description, string license, string make, string model, string Type, int numberofDoors, double Price)

        {
            this.licenseNumber = license;
            this.vehicleMake = make;
            this.vehicleModel = model;
            this.vehiclePrice = Price;
            this.vehicleType = description;
        }
        public override void printDescription () {
            

            Console.WriteLine ("Vehicle Description: {0}", this.vehicleDescription);
            Console.WriteLine ("The license number is {0}.", this.licenseNumber);
            Console.WriteLine ("Make is a {0}.", this.vehicleMake);
            Console.WriteLine ("Model is : {0}.", this.vehicleModel);
            Console.WriteLine ("This is a {0} door {1}.", this.numberofDoors, this.vehicleType);
            Console.WriteLine ("The price of the vehicle is ${0}.", this.vehiclePrice);

        }

    }
    class Truck : Vehicle
    //listing properties for truck
    {
        int BedSize = 7;

        public Truck (string description, string license, string make, string model, int bedSize, double price) {
            this.vehicleDescription = description;
            this.licenseNumber = license;
            this.vehicleMake = make;
            this.vehicleModel = model;
            this.vehiclePrice = price;
            this.BedSize = bedSize;
        }
        override public void printDescription () {
            Console.WriteLine ("Vehicle Description: {0}", this.vehicleDescription);
            Console.WriteLine ("License number : {0}.", this.licenseNumber);
            Console.WriteLine ("Make : {0}", this.vehicleMake);
            Console.WriteLine ("Model :{0}", this.vehicleModel);
            Console.WriteLine ("This truck has a {0} ft bed", this.BedSize);
            Console.WriteLine ("The price of the vehicle is ${0}", this.vehiclePrice);
        }
    }
}
