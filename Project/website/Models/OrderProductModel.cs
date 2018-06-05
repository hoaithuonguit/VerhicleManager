using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace website.Models
{
    public class OrderProductModel
    {
        public string Name { get;  }
        public string Email { get; }
        public string ProductName { get; }
        public int Count { get; }
        public DateTime DateRecieved { get; }
        public string Description { get; }
    }
}