using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
