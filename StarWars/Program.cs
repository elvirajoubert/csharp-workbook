using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StarWars
{


    public class Program
    {
        public static void Main()
        {
            Person leia = new Person("Leia", "Organa", "Rebel");
            Person darth = new Person("Darth", "Vader", "Imperial");
            Ship falcon = new Ship("Rebel", "Smuggling", 2);
            Ship tie = new Ship("Tie", "Fighter", 1);
            Ship xwing = new Ship("X Wing", "Rebel", "Fighter", 1);
            Station class1 = new Station("Class 1", "Rebel", 2);
            Station deathStar = new Station("Death Star", "Imperial", 2);
            // Console.WriteLine("Hello world!");


            //place people onto ships
            falcon.EnterShip(leia, 0);
            falcon.EnterShip(hansolo, 1);
            tie.EnterShip(darth, 0);

            //place ships onto stations
            class1.EnterStation(falcon, 0);
            deathStar.EnterStation(tie, 0);

            // class1.roster();
            // deathStar.roster();

            //roll call for each station
            // class1.roster(falcon);
            Console.WriteLine(class1.roster(falcon));
            Console.WriteLine(deathStar.roster(tie));
        }
    }


//creates a person with a first & last name, their alliance
public class Person
{
    private string firstName;
    private string lastName;
    private string alliance;
    public Person(string firstName, string lastName, string alliance)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.alliance = alliance;
    }

    public string FullName
    {
        get
        {
            return this.firstName + " " + this.lastName;
        }

        set
        {
            string[] names = value.Split(' ');
            this.firstName = names[0];
            this.lastName = names[1];
        }
    }
}

class Ship
{
    public string name;
    public Person[] passengers;
    public Ship(string alliance, string type, int size)
    {
        this.name = name;
        this.Type = type;
        this.Alliance = alliance;
        this.passengers = new Person[size];
    }

    public string Type
    {
        get;
        set;
    }

    public string Alliance
    {
        get;
        set;
    }

    public string Passengers
    {
        get
        {
            String formatted = " ";
            foreach (var person in passengers)
            {
                formatted += person + "\n";
                Console.WriteLine(String.Format("{0}", person.FullName));
            }

            return "That's Everybody!";
        }
    }

    public void EnterShip(Person person, int seat)
    {
        passengers[seat] = person;
    }

    public void ExitShip(int seat)
    {
        this.passengers[seat] = null;

    }
}
class Station
{
    public string StationName;
    private Ship[] port;
    public Station(string StationName, string alliance, int seat)
    {
        this.StationName = StationName;
        this.Alliance = alliance;
        this.port = new Ship[seat];
    }
    public string station
    {
        get;
        set;
    }
    public string Alliance
    {
        get;
        set;
    }
    public void EnterStation(Ship name, int spot)
    {
        this.port[spot] = name;
    }
    public void ExitStation(Ship name, int spot)
    {
        this.port[spot] = null;
    }

    // public string Ships
    // {
    //     Console.WriteLine(String.Format("The {0}, {1} ship arrived at the port {2}.", ships[i].NameShip, ships[i].Type, i));  
          
    // }
    //     return "";
      
     

    
//     public void roster(Ship name)
//     {
//     string rosterNames = "";
//     for (int = 0; i < namespace.passengers.Length; i++)
//     {
//     rosterNames += String.Format("Passenger {0} is on Ship {1}.\n, name,passengers[i].FullName, name.name");
//     }
//     return rosterNames;
// }

}
}
