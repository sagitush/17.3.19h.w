using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._3._19h.w
{
   public interface IGarage
    {
        void FixCar(Car car);
        void TakeOutCar(Car car);
        void AddCar(Car car);
    }
    public interface IGarageGeneric<T>
    {
        void FixVehicle(T vehicle);
        void TakeOutVehicle(T vehicle);
        void AddVehicle(T vehicle);
    }
    public interface IFixTotalLost
    {
        bool CanFixTotalLost();
    }
}
