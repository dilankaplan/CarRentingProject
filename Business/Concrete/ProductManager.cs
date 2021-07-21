using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager :IProductService
    {
        IProductDal _productDal;
        IBrandDal _brandDal;
        IColorDal _colorDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public ProductManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public ProductManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {

            return _productDal.GetAll();
        }

        public List<Product> GetCarsByBrandId(int brandId)
        {
            return _productDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Product> GetCarsByColorId(int colorId)
        {
            return _productDal.GetAll(p=>p.ColorId== colorId);
        }

       
    }
}
