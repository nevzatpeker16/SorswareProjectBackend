using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ParkLog:IEntity
    {
        public int LogID { get; set; }

        public int ParkID { get; set; }

        public int CarID { get; set; }

    }
}
