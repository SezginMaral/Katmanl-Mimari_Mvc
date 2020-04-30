using System;
using System.Collections.Generic;
using System.Text;

namespace Sezgin.Entities
{
   public class Customer
    {
        public int CustomerID { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
