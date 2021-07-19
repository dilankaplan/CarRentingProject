using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetId(int ColorId);
        List<Product> GetAll();
        void Add(Product Product);
        void Update(Product product);
        void Delete(Product product);


    }
}
