﻿using System;
using System.Collections.Generic;

using System.Text;

using Sezgin.Entities;

namespace Sezgin.Dal.Concrete.EntityFramework
{
   public class SezginContext:DbContext
    {
       public DbSet<Product> Products { get; set; }
    }
}
