using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._3._19h.w
{
    class GarageGeneric<T>:IGarageGeneric<T> where T:IFixTotalLost
    {
        List<T> vehicles;
        List<string> vehicleTypes;

        public GarageGeneric(List<string> carTypes)
        {
            this.vehicleTypes = carTypes;
            vehicles = new List<T>();
        }

        public void AddVehicle(T vehicle )
        {
            if (vehicles.Contains(vehicle))
            {
                throw new CarAlreadyHereException($"car {vehicle} allready exist in the list");
            }
            if (vehicle.CanFixTotalLost() == false)
            {
                throw new WeNotFixTotalLostException($"The car {vehicle} is total lost");
            }
            if (!vehicleTypes.Contains(vehicle.Brand))
            {
                throw new WrongGarageException($"we dont have this car brand {vehicle.Brand} in our garage ");
            }
            if (vehicle == null)
            {
                throw new CarNullException("the car is null");
            }
            if (vehicle.NeedsRepair == false)
            {
                throw new RepairMismatchException($"The car {vehicle} dont need care");
            }
            vehicles.Add(vehicle);
        }

        public void FixVehicle(T vehicle)
        {
            if (vehicle == null)
            {
                throw new CarNullException("the car is null");
            }
            if (!vehicles.Contains(vehicle))
            {
                throw new CarNotInGarageException($"car {vehicle} not in the garage");

            }
            if (vehicles.NeedsRepair == false)
            {
                throw new RepairMismatchException($"The car {vehicle} dont need care");
            }
            vehicle.NeedsRepair = false;
        }

        public void TakeOutVehicle(T vehicle )
        {
            if (vehicle == null)
            {
                throw new CarNullException("the car is null");
            }
            if (!vehicles.Contains(vehicle))
            {
                throw new CarNotInGarageException($"car {vehicle} not in the garage");

            }
            if (vehicle.NeedsRepair == true)
            {
                throw new CarNotReadyExcption("car {car} steel needs care");
            }

            vehicles.Remove(vehicle);
        }
    }
}
