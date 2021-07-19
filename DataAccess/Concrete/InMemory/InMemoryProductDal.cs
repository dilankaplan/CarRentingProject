using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal:IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>

            {
                new Product { Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2019", DailyPrice = 1200, Description = "Red,BlueEFFICIENCY" },
                new Product { Id = 2, BrandId = 2, ColorId = 2, ModelYear = "2021", DailyPrice = 1600, Description = "Black,First Edition M Sport" },
                new Product { Id = 3, BrandId = 2, ColorId = 3, ModelYear = "2015", DailyPrice = 950, Description = "Graphite Grey,Luxury Line" },
                new Product { Id = 4, BrandId = 1, ColorId = 2, ModelYear = "2017", DailyPrice = 1100, Description = "Black,AMG package" },
                new Product { Id = 5, BrandId = 3, ColorId = 3, ModelYear = "2012", DailyPrice = 500, Description = "Graphite Grey,S-Line " },
            };
        }
        public void Add(Product Product)
        {
            _products.Add(Product);

        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetId(int ColorId)
        {
            return _products.Where(p => p.ColorId == ColorId).ToList();
        }

        public void Update(Product product)
        {
            Product ProductToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            ProductToUpdate.BrandId = product.BrandId;
            ProductToUpdate.ColorId = product.ColorId;
            ProductToUpdate.DailyPrice = product.DailyPrice;
            ProductToUpdate.Description = product.Description;


        }

       
        }
    }

