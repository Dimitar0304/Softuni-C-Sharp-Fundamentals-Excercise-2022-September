using System;
using System.Collections.Generic;

namespace _4._Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            //we will create class Car with props =>model engine and cargo where engine and cargo are classes
            //enginge class has engineSpeed and enginePower
            //CarGo class has carGoWeight and CargoType
            //create a ctor that recives all info for current car
            //on first line we recive n -number of our cars
            //on every n lines we recive info model,engineSpeed,enginePower,carGoWeight,carGoType
            // after these n lines we will recive one of these command fragile or flamable
            // if command is fragile =>print cars with carGoType fragile and carGoWeight<1000
            //if command is flamable =>print cars with carGoType flamable and enginePower>250
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string model = info[0];
                int engineSpeed = int.Parse(info[1]);
                int enginePower = int.Parse(info[2]);
                int carGoWeight = int.Parse(info[3]);
                string carGoType = info[4];
                Engine engine = new Engine(engineSpeed, enginePower);
                CarGo carGo = new CarGo(carGoWeight, carGoType);
                Car car = new Car(model, engine, carGo);
                cars.Add(car);
              
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                int indexOfFragileCar = 0;
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].CarGo.CarGoWeight<1000 && cars[i].CarGo.CarGoType==command)
                    {
                        indexOfFragileCar = i;
                        Console.WriteLine(cars[indexOfFragileCar].Model);
                    }
                    
                }
            }
            else
            {
                int indexOfFlamableType = 0;
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].CarGo.CarGoType== "flamable" && cars[i].Engine.EnginePower>250)
                    {
                        indexOfFlamableType = i;
                        Console.WriteLine(cars[indexOfFlamableType].Model);
                    }
                }
            }
        }
        class Engine
        {
            public Engine(int engineSpeed,int enginePower)
            {
                EngineSpeed = engineSpeed;
                EnginePower = enginePower;
            }
           public  int EngineSpeed { get; set; }
            public int EnginePower { get; set; }
        }
        class CarGo
        {
            public CarGo(int carGoWeight,string carGoType)
            {
                CarGoWeight = carGoWeight;
                CarGoType = carGoType;
            }
            public int CarGoWeight { get; set; }
            public string CarGoType { get; set; }
        }
        class Car
        {
         

            public Car(string model,Engine engine,CarGo carGo)
            {
                Model = model;
                Engine = engine;
                CarGo = carGo;
            }
            public string Model { get; set; }
            public Engine Engine { get; set; }
            public CarGo CarGo { get; set; }
            
        }
    }
}
