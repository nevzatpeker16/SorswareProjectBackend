using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int CarID { get; set; }
        public string Plate { get; set; }
    }
}
