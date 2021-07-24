using Core.Utilities;
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
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetCarsByColorId(int colorId);
        IDataResult<List<Product>> GetCarsByBrandId(int brandId);
        IDataResult<List<ProductDetailDto>> GetProductDetailDtos();
        IDataResult<Product> GetById(int Id);
        IResult Add(Product product);

    }
}
