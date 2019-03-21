using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._3._19h.w
{
    public class Car:IFixTotalLost
    {
        public string Brand { get;private set; }
        public bool TotalLost { get;private set; }
        public bool NeedsRepair { get; set; }

        public Car(string brand, bool totalLost, bool needsRepair)
        {
            Brand = brand;
            TotalLost = totalLost;
            NeedsRepair = needsRepair;
            if(TotalLost==true&& NeedsRepair==false)
            {
                throw new RepairMismatchException("The car doesnt need care");
            }
        }

        public bool CanFixTotalLost()
        {
            return false;
        }
    }
}
