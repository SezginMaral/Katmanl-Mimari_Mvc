using Sezgin.Bll.Concrete;
using Sezgin.Dal.Concrete.EntityFramework;
using Sezgin.Entities;
using Sezgin.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sezgin.WcfLibrary.Concrete
{
    public class ProductService : IProductSevice
    { //NOT: servislerin constractur ı olmaz

        private ProductManager _productManager = new ProductManager(new EfProductDal());

        public void add(Product product)
        {
            _productManager.add(product);
        }

        public void delete(int productId)
        {
            _productManager.delete(productId);
        }

        public Product Get(int productId)
        {
            return _productManager.Get(productId);
        }

        public List<Product> GetAll()
        {
            return _productManager.GetAll();
        }

        public void Update(Product product)
        {
            _productManager.Update(product);
        }
    }
}
