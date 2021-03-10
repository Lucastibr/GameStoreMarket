using System;
using System.Collections.Generic;
using System.Text;
using GSM.Core.Domain.Base;

namespace GSM.Core.Domain.Users
{
    public class User : EntityBase
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
