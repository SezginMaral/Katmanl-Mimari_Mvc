using Sezgin.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace Sezgin.Interfaces
{
    [ServiceContract]
   public interface IProductSevice
    {
        [OperationContract]
        List<Product> GetAll();

        [OperationContract]
        Product Get(int productId);

        [OperationContract]
        void add(Product product);

        [OperationContract]
        void delete(int productId);

        [OperationContract]
        void Update(Product product);
    }
}
