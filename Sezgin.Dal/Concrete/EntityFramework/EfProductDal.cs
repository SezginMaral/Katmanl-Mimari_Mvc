using Sezgin.Dal.Abstract;
using Sezgin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sezgin.Dal.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        SezginContext _context = new SezginContext();
        public void add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void delete(int productId)
        {
            _context.Products.Remove(_context.Products.FirstOrDefault(x => x.ProductID == productId));
            _context.SaveChanges();
        }

        public Product Get(int productId)
        {
           return _context.Products.FirstOrDefault(x => x.ProductID == productId);
        }

        public List<Product> GetAll()
        {
           return _context.Products.ToList();
        }

        public void Update(Product product)
        {
            Product productUpdate = _context.Products.FirstOrDefault(x => x.ProductID == product.ProductID);
            product.ProductName = product.ProductName;
            productUpdate.UnitPrice = product.UnitPrice;
            product.UnitsInStock = product.UnitsInStock;
            product.CategoryID = product.CategoryID;
            _context.SaveChanges();
        }
    }
}
