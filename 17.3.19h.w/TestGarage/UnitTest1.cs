using System;
using System.Collections.Generic;
using _17._3._19h.w;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGarage
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException (typeof (WrongGarageException))]
        public void TestMethodAddCar()
        {
            List<string> list = new List<string> { "mazda", "mercedes", "yundai" };
            Garage garage = new Garage(list);
            Car car = new Car("mazda", false, true);
            Car d = new Car("porsh", false, true);
            garage.AddCar(car);
            garage.AddCar(d);
           

        }
        [TestMethod]
        [ExpectedException(typeof(CarNotInGarageException))]
        public void TestMethodTakeOurCar()
        {
            List<string> list = new List<string> { "mazda", "mercedes", "yundai" };
            Garage garage = new Garage(list);
            Car car = new Car("mazda", false, true);
            Car b = new Car("mercedes", false, true);
            Car d = new Car("porsh", false, true);
            garage.AddCar(car);

            garage.TakeOutCar(b);
        }
        [TestMethod]
        [ExpectedException(typeof(RepairMismatchException))]
        public void TestMethodFixCar()
        {
            List<string> list = new List<string> { "mazda", "mercedes", "yundai" };
            Garage garage = new Garage(list);
            Car car = new Car("mazda", false, true);
            Car b = new Car("mercedes",false,true);
            Car d = new Car("yundai", false, false);
            garage.AddCar(car);
            garage.AddCar(b);
            garage.AddCar(d);
            garage.FixCar(d);
        }

    }
}
