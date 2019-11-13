using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Core.Entities;

namespace tiqpwa.Entities.Concrete
{
    public class User : IEntity
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
    }

  
}
