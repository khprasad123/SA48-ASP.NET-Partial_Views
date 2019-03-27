using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partial_Views_Exercise.Models
{
    public class TransactModels
    {
        public string product { get; set; }
        public string brand { get; set; }
        public int price { get; set; }

        public TransactModels(string a,string b,int c)
        {
            this.product = a;
            this.brand = b;
            this.price = c;
        }
    }
}