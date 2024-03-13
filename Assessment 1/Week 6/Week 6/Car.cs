using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6
{
    internal class Car
    {
        public string model = "Toyota";
        private string CarType = "Sedan";
        string colour = "Red";
        int year = 2003;
        int cylinders = 4;
        float fuel = 20; //in litres

        public void PrintDetails()
        {
            Console.WriteLine($"Model:{model}, carType:{CarType}");
        }

        public void UseFuel(int amount)
        {
            fuel -= amount;
            if (fuel < 0)
                fuel = 0;
        }

        public Car()
        {
            model = "Hyundai";
            year = 2022;
        }

        public Car(string model, string carType)
        {
            this.model = model;
            this.CarType = carType;
        }

    }
}
