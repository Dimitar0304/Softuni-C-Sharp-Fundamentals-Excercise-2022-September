using System;
using System.Collections.Generic;

namespace _3._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            //you have to define a clas Car wich will has following properties
            //model,fuel amount,fuel consumation per kilometer and travelled distance
            //in that class will has a method for move the car - model car and how many km are travaled
            //on the first line we recive n-number of cars
            int n = int.Parse(Console.ReadLine());
            //after these n lines their movement after recive End command
            //I should create method for check if current car can move these km with his fuel reduce the fuel and increase
            // traveled km
            //otherwise if current car can not move these km with this fuel they save same and print
            //"Insufficient fuel for the drive"
            //when we recive end command we will print all cars with their fuel model and traveled distance 
            //fuel ammount is formed two digits after decimal point.
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string model = info[0];
                double fuelAmount = double.Parse(info[1]);
                double fuelConsumation = double.Parse(info[2]);
                double travaledDistance = 0;
                Car car = new Car(model, fuelAmount, fuelConsumation, travaledDistance);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] commandInfo = command.Split();
                string drivenModel = commandInfo[1];
                double currentKm = double.Parse(commandInfo[2]);

                if (IsThatCarCanMoveThoughTheseKm(cars,drivenModel,currentKm)==false)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                else
                {
                    DecreaseFuel(cars, drivenModel, currentKm);
                    IncreaseTravaledKm(cars, drivenModel, currentKm);
                }
               
                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravaledDistance}");
            }

        }

        private static void IncreaseTravaledKm(List<Car> cars, string drivenModel, double currentKm)
        {
            int indexOfDrivenCar = 0;  
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Model == drivenModel)
                {
                    indexOfDrivenCar = i;
                }
            }
            cars[indexOfDrivenCar].TravaledDistance += currentKm;
        }

        private static void DecreaseFuel(List<Car> cars, string drivenModel, double currentKm)
        {
            int indexOfDrivenCar = 0;
            double fuelconsumation = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Model == drivenModel)
                {
                    indexOfDrivenCar = i;
                }
            }
            fuelconsumation = cars[indexOfDrivenCar].FuelConsumation;
            double KmMyltyplyConsumation = fuelconsumation * currentKm;
            double curentFuelAmmount = cars[indexOfDrivenCar].FuelAmount - KmMyltyplyConsumation;
            cars[indexOfDrivenCar].FuelAmount = curentFuelAmmount;
        }

      

        class Car
        {
            public Car(string model,double fuelAmount,double fuelConsumation,double travaledDistance)
            {
                Model = model;
                FuelAmount = fuelAmount;
                FuelConsumation = fuelConsumation;
                TravaledDistance = travaledDistance;
            }
            public string Model { get; set; }
            public double FuelAmount { get; set; }
            public double FuelConsumation { get; set; }
            public double TravaledDistance { get; set; }

            
        }
        static bool IsThatCarCanMoveThoughTheseKm(List<Car>cars,string drivenModel,double currentKm)
        {
            int indexOfdrivenModel = 0;
            double fuelconsumation = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Model == drivenModel)
                {
                    indexOfdrivenModel = i;
                }
            }
            fuelconsumation = cars[indexOfdrivenModel].FuelConsumation;
            double KmMyltyplyConsumation = fuelconsumation * currentKm;
            if (cars[indexOfdrivenModel].FuelAmount - KmMyltyplyConsumation >=0)
            {
                return true;
            }
            return false;
        }
    }
}
