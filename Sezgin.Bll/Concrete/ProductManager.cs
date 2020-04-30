using Sezgin.Dal.Abstract;
using Sezgin.Entities;
using Sezgin.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sezgin.Bll.Concrete
{
    public class ProductManager : IProductSevice
    {
        public IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void add(Product product)
        {
            _productDal.add(product);
        }

        public void delete(int productId)
        {
            _productDal.delete(productId);
        }

        public Product Get(int productId)
        {
           return _productDal.Get(productId);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
