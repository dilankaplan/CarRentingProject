using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
namespace DataAccess.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, DatabaseContext>,IProductDal
    {

        public List<ProductDetailDto> GetProductDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from p in context.Products
                             join b in context.Brands on p.BrandId equals b.BrandId
                             join k in context.Colors on p.ColorId equals k.ColorId
                             select new ProductDetailDto
                             {
                                 ProductName = p.ProductName,
                                 BrandName = b.BrandName,
                                 DailyPrice = p.DailyPrice,
                                 ColorName = k.ColorName
                             };

                return result.ToList();
            }
        }
    }

}
