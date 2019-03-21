using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._3._19h.w
{
    public class Garage : IGarage
    {
        List<Car> cars;
        List<string> carTypes;

        public Garage(List<string> carTypes)
        {
            this.carTypes = carTypes;
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            if (cars.Contains(car))
            {
                throw new CarAlreadyHereException($"car {car} allready exist in the list");
            }
            if(car.TotalLost==true)
            {
                throw new WeNotFixTotalLostException($"The car {car} is total lost");
            }
            if (!carTypes.Contains(car.Brand))
            {
                throw new WrongGarageException($"we dont have this car brand {car.Brand} in our garage ");
            }
            if(car==null)
            {
                throw new CarNullException("the car is null");
            }
            if (car.NeedsRepair==false)
            {
                throw new RepairMismatchException($"The car {car} dont need care");
            }
            cars.Add(car);
        }

        public void FixCar(Car car)
        {
            if (car == null)
            {
                throw new CarNullException("the car is null");
            }
            if (!cars.Contains(car))
            {
                throw new CarNotInGarageException($"car {car} not in the garage");

            }
            if (car.NeedsRepair == false)
            {
                throw new RepairMismatchException($"The car {car} dont need care");
            }
            car.NeedsRepair = false;
        }

        public void TakeOutCar(Car car)
        {
            if(car==null)
            {
                throw new CarNullException("the car is null");
            }
            if(!cars.Contains(car))
            {
                throw new CarNotInGarageException($"car {car} not in the garage");

            }
            if(car.NeedsRepair==true)
            {
                throw new CarNotReadyExcption("car {car} steel needs care");
            }

            cars.Remove(car);
        }

    }
}
