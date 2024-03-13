using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car();
            Car car3 = new Car("Porche", "F1 racer");

            car.model = "Ford";
            car.UseFuel(2);
            car.PrintDetails();
            car2.PrintDetails();
            car3.PrintDetails();

            Console.ReadKey();
        }
    }
}
