using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetCarsByColorId(int colorId);
        List<Product> GetCarsByBrandId(int brandId);
        void Add(Product product);
        List<ProductDetailDto> GetProductDetailDtos(); 
    }
}
