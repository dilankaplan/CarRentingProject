using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
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
        public ProductManager(DataAccess.Abstract.IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            _productDal.GetAll();
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Brand>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(p => p.BrandId == brandId));
        }

        public SuccessDataResult<List<Color>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(p=>p.ColorId== colorId));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetailDtos()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.ProductDetails(),Messages.ProductsListed);
        }

        IDataResult<Product> IProductService.GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        IDataResult<List<Product>> IProductService.GetCarsByBrandId(int brandId)
        {
            throw new System.NotImplementedException();
        }

        IDataResult<List<Product>> IProductService.GetCarsByColorId(int colorId)
        {
            throw new System.NotImplementedException();
        }
    }
}
