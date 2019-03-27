using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partial_Views_Exercise.Models
{
    public class ComplaintModels
    {
        public string product { get; set; }
        public string complain { get; set; }

        public ComplaintModels(string a,string b)
        {
            this.product = a;
            this.complain = b;
        }
    }
}