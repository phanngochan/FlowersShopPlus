using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowersShop.Objects
{
    public class User
    {
        public string number { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string cccd { get; set; }

        public User(string number, string username, string password, string cccd) { 
            this.number = number;
            this.username = username;
            this.password = password;
            this.cccd = cccd;
        }
    }
}