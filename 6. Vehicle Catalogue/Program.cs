using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal avarageCarsHp = 0.00m;
            decimal avarageTrucksHp = 0.00m;
            int allCarsHp = 0;
            int allTrucksHp = 0;
            string command = Console.ReadLine();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while (command!="End")
            {
                string[] infoArg = command.Split(" ");
                string typeOfVeahle = infoArg[0];
                string model = infoArg[1];
                string color = infoArg[2];
                int hp = int.Parse(infoArg[3]);

                if (typeOfVeahle == "car")
                {
                    Car car = new Car(model, color, hp);
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck(model, color, hp);
                    trucks.Add(truck);
                }
                command = Console.ReadLine();
            }
            Catalogue catologue = new Catalogue(cars, trucks);

            string currentModel = Console.ReadLine();
            while (currentModel != "Close the Catalogue")
            {
                if (IsThatACar(currentModel,cars))
                {
                    Console.WriteLine($"Type: Car");
                    foreach (Car car in cars.Where(c=>c.Model==currentModel))
                    {
                        Console.WriteLine($"Model: { car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: { car.HP}");
                    }
                }
                else if (IsThatATruck(currentModel,trucks))
                {
                    Console.WriteLine($"Type: Truck");
                    foreach (Truck truck in trucks.Where(t => t.Model == currentModel))
                    {
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: { truck.HP}");
                    }
                }
                currentModel = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                allCarsHp += car.HP;
            }
            foreach (var truck in trucks)
            {
                allTrucksHp += truck.HP;
            }

            if (cars.Count>0)
            {
                avarageCarsHp = (decimal)allCarsHp / cars.Count;
            }
            if (trucks.Count>0)
            {
                avarageTrucksHp = (decimal)allTrucksHp / trucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {avarageCarsHp:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avarageTrucksHp:F2}.");
          

        } 
        static bool IsThatACar(string currentModel,List<Car>cars)
        {
            return cars.Any(c => c.Model == currentModel);
        }
        static bool IsThatATruck(string currentModel, List<Truck> trucks)
        {
            return trucks.Any(t => t.Model == currentModel);
        }
    }
    class Car
    {
        public Car(string model,string color,int hp)
        {
            Model = model;
            Color = color;
            HP = hp;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }
    }
    class Truck
    {
        public Truck(string model,string color,int hp)
        {
            Model = model;
            Color = color;
            HP = hp;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }
    }
    class Catalogue
    {
        public Catalogue(List<Car>cars,List<Truck>trucks)
        {
            Cars = cars;
            Trucks = trucks;
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
