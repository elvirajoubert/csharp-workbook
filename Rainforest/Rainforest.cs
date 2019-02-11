using System;
using System.Collections.Generic;

namespace Rainforest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Company Rainforest = new Company("Rainforest");
            Warehouse Austin = new Warehouse("Austin", 3);
            Warehouse Dallas = new Warehouse("Dallas", 4);
            Warehouse Houston = new Warehouse("Houston", 5);

            Container Austin1 = new Container(3, "Austin1");
            Container Austin2 = new Container(5, "Austin2");
            Container Dallas1 = new Container(3, "Dallas1");
            Container Dallas2 = new Container(6, "Dallas2");
            Container Houston1 = new Container(3, "Houston1");
            Container Houston2 = new Container(6, "Houston2");

            Item bananas = new Item("bananas", 1.99);
            Item apples = new Item("apples", 3.49);
            Item granolabars = new Item("granola bar", 1.49);
            Item grapes = new Item("grapes", 2.49);
            Item cereal = new Item("cereal", 3.59);
            Item bread = new Item("bread", 4.20);
            Item eggs = new Item("eggs", 5.97);
            Item milk = new Item("milk", 3.80);
            Item icecream = new Item("ice-cream", 4.50);

            Rainforest.Warehouses.Add(Austin);
            Rainforest.Warehouses.Add(Dallas);
            Rainforest.Warehouses.Add(Houston);

            Austin.containers.Add(Austin1);
            Austin.containers.Add(Austin2);
            Dallas.containers.Add(Dallas1);
            Dallas.containers.Add(Dallas2);
            Houston.containers.Add(Houston1);
            Houston.containers.Add(Houston2);

            Austin1.items.Add(grapes);
            Austin1.items.Add(icecream);
            Austin2.items.Add(cereal);
            Dallas1.items.Add(bread);
            Dallas1.items.Add(milk);
            Dallas2.items.Add(eggs);
            Houston1.items.Add(bananas);
            Houston1.items.Add(apples);
            Houston2.items.Add(granolabars);

            Manifest(Rainforest);
            Console.WriteLine("");
            Index(eggs, Rainforest);
        }
        public static void Manifest(Company company)
        {
            Console.WriteLine("{0}", company.Name);
            foreach (Warehouse war in company.Warehouses)
            {
                Console.WriteLine("{0}" .PadLeft(4), war.location);
                foreach (Container cont in war.containers)
                {
                    Console.WriteLine("{0}" .PadLeft(8), cont.id);
                    foreach (Item it in cont.items)
                    {
                        Console.WriteLine("{0}" .PadLeft(12), it.name);
                    }
                }
            }
        }
        public static void Index (Item item, Company company)
        {
            Dictionary<Item, Container> indexer = new Dictionary<Item, Container>();
            foreach (Warehouse war in company.Warehouses)
            {
                foreach (Container cont in war.containers)
                {
                    foreach (Item it in cont.items)

                    {
                        indexer.Add(it, cont);
                    }
                }
            }

                if (indexer.ContainsKey(item))
                {
                    Container value = indexer[item];
                    Console.WriteLine("{0} is found in {1}", item.name, value.id);
                }
            }
        }

        class Company
        {
            public string Name { get; set; }
            public List<Warehouse> Warehouses = new List<Warehouse>();

            public Company(string Name)
            {
                this.Name = Name;
            }
        }

        class Warehouse
        {
            public string location { get; set; }
            public int size { get; set; }
            public List<Container> containers = new List<Container>();

            public Warehouse(string location, int size)
            {
                this.location = location;
                this.size = size;
            }
        }

        class Container
        {
            public int size { get; set; }
            public string id { get; set; }
            public List<Item> items = new List<Item>();

            public Container(int size, string id)
            {
                this.size = size;
                this.id = id;
            }
        }

        class Item
        {
            public string name { get; set; }
            public double price { get; set; }

            public Item(string name, double price)
            {
                this.name = name;
                this.price = price;
            }
        }
    }
