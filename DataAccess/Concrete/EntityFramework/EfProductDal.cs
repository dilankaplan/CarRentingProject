using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
namespace DataAccess.EntityFramework
{
        public class EfCarDal : EfEntityRepositoryBase<Product, DatabaseContext>, IProductDal
        {

        public List<ProductDetailDto> ProductDetails()
            {
                 using (DatabaseContext context = new DatabaseContext())
                {
                    var result = from p in context.Products
                                 join c in context.Colors
                                 on c.ColorId equals c.Id
                                 join b in context.Products
                                 on c.BrandId equals b.Id
                                 select new ProductDetailDto
                                 {
                                     Id = c.Id,
                                     BrandName = b.Name,
                                     ColorName = c.Name,
                                     DailyPrice = c.DailyPrice
                                 };
                    return result.ToList();
                }
            }

       
    }

    }
