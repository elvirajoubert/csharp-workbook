using System;
using System.Collections.Generic;

namespace OOP1
{
    public class Program
    {
        public static void Main()
        {
            Garage smallGarage = new Garage(2);
            Car blueCar = new Car("blue");
            Person autobot = new Person("Autobot");
            Person bumblebee = new Person("BumbleBee");
            blueCar.addPerson(autobot, 0);
            blueCar.addPerson(bumblebee, 1);
            smallGarage.ParkCar(blueCar, 0);
            Console.WriteLine(smallGarage.Cars);
        }
    }

    public class Car
    {
        public Car(string initialColor)
        {
            Color = initialColor;
            this.passengers = new List<Person>();

        }


        public string Color { get; private set; }

        public List<Person> passengers;

        public void addPerson(Person passenger, int spot)
        {
            passengers.Add(passenger);

        }

        public string Passengers
        {
            get
            {
                string passengerNames = "";
                for (int i = 0; i < passengers.Count; i++)
                {
                    if (passengers[i] != null)
                    {
                        passengerNames += passengers[i].Name + " ";
                    }
                }
                return passengerNames;
            }
        }
    }
    public class Garage
    {
        private Car[] cars;

        public Garage(int initialSize)
        {
            Size = initialSize;
            this.cars = new Car[initialSize];
        }
        public int Size { get; private set; }

        public void ParkCar(Car car, int spot)
        {
            cars[spot] = car;
        }

        public string Cars
        {
            get
            {
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i] != null)
                    {
                        Console.WriteLine(String.Format("The {0} car is in spot {1} and the people in that car are: {2}", cars[i].Color, i, cars[i].Passengers));
                    }
                }
                return "That's all!";

            }
        }
    }

    public class Person
    {
        public Person(string initialName)
        {
            Name = initialName;
        }
        public string Name { get; private set; }
    }
}



