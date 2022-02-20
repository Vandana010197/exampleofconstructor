using System;
namespace ExampleConstructor
{
    class Car
    {
        string carModel;
        int carYear;

        public Car(string model,int Year)
        {
            carModel = model;
            carYear = Year;
        }
        public Car(int Year, string model)
        {
            carModel=model;
            carYear=Year;
        }
        static void Main(string[] args)
        {
            Car myCar = new Car("mustang", 1996);
            Console.WriteLine(myCar.carYear);
            Console.ReadLine(); 
        }

    }
    

}