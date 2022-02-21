using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            
            //lot is an instance of the carlot class

            var lot = new CarLot();
           




            //Now that the Car class is created we can instanciate 3 new cars
            //dot notation
            var elijahsCar = new Car();
            elijahsCar.Make = "Ford";
            elijahsCar.Model = "Focus";
            elijahsCar.Year = 2012;
            elijahsCar.EngineNoise = "vroom vroom";
            elijahsCar.HonkNoise = "boooop";
            elijahsCar.IsDrivable = true;

            lot.Cars.Add(elijahsCar);

            //object initializer syntax
            var michaelsCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "errrrrr",
                IsDrivable = false    
            };

            lot.Cars.Add(michaelsCar);

            //calling it the one-liner where you need
            //to create a new construcor to place in parameter values inside properties
            var johnsCar = new Car(1972, "Gran Torino", "Ford", "rarrr", "eeeeee", true);

            lot.Cars.Add(johnsCar);

            elijahsCar.MakeEngineNoise(elijahsCar.EngineNoise);
            michaelsCar.MakeEngineNoise(michaelsCar.EngineNoise);
            johnsCar.MakeEngineNoise(johnsCar.EngineNoise);

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}
