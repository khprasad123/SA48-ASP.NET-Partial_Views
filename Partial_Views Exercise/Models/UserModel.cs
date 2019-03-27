using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partial_Views_Exercise.Models
{
    public class UserModel
    {
        public string name { get; set; }
        public string email { get; set; }

        public UserModel(string a,string b)
        {
            this.name = a;
            this.email = b;
        }
    }
}