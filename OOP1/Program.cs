using System;
					
public class Program
{
	public static void Main()
	{   
        var person = new Person();
        Car blueCar = new Car("blue");
		Garage smallGarage = new Garage(2);
		
        car.addPerson(firstName, lastName);
		smallGarage.ParkCar(blueCar, 0);
        Console.WriteLine(Car.Person);
		Console.WriteLine(smallGarage.Cars);
	}
}

class Car
{
    private Person[] passengers;
    public Car(string initialColor)
    {
    	Color = initialColor;
        this.passengers = new Person[];
    }
    
    public string Color { get; private set; }
}
class Person
{
    private string firstName;
	private string lastName;
	public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    class Garage
{
    private Car[] cars;
    
    public Garage(int initialSize)
    {
    	Size = initialSize;
	    this.cars = new Car[initialSize];
    }
    
    public int Size { get; private set; }
    
    public void ParkCar (Car car, int spot)
    {
        cars[spot] = car;
    }
    
    public string Cars {
		get {
			for (int i = 0; i < cars.Length; i++)
			{
				if (cars[i] != null) {
					Console.WriteLine(String.Format("The {0} car is in spot {1} and passenger is .",Car.Person, cars[i].Color, i));
				}
			}
            
			return "That's all!";
		
        }
	
    }
}
}

