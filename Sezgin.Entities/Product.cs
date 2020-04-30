﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sezgin.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }



    }
}
