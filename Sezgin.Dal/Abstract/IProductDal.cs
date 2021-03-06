﻿using Sezgin.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sezgin.Dal.Abstract
{
    public  interface IProductDal
    {
        List<Product> GetAll();

        Product Get(int productId); 

        void add(Product product);

        void delete(int productId);

        void Update(Product product);


    }
}
