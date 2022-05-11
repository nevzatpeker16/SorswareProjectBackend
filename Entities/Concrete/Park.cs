using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Park:IEntity
    {
        public int ParkID { get; set; }
        public string ParkName { get; set; }

        public int ParkCapacity { get; set; }

        public double PricePerHour { get; set; }
    }
}
