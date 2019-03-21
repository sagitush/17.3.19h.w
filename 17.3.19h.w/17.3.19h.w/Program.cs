using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._3._19h.w
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "mazda", "mercedes", "yundai" };
            Garage garage = new Garage(list);
            Car car = new Car("mazda", false, true);
            Car d = new Car("porsh", false, true);
            garage.AddCar(car);
            garage.AddCar(d);

        }
    }
}
