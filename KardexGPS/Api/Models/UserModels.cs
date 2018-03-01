using System;
using System.Collections.Generic;

namespace KardexGPS.Api.Models
{
    public class UserModels
    {
        public class GenericUser
        {
            public int id { get; set; }
            public string Name { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }
        public class Admin
        {
            public string AdminName { get; set; }
        }
    }
}