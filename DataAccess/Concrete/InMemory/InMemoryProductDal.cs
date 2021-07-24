using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;

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
            if(Product.ProductName.Length>=2 && Product.DailyPrice<=0)
            {
                _products.Add(Product);
            }
            else
            {
                Console.WriteLine("Lütfen günlük kiralama bedelini ve ürün ismini tekrar gözden geçirin.");
            }
           

        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }
        
        public List<Product> GetId(Expression<Func<Product, bool>> filter = null)
        {
            return _products.Where(p => p.Id == p.Id).ToList();
        }

        public List<ProductDetailDto> ProductDetails => throw new NotImplementedException();

       

        public void Update(Product product)
        {
            Product ProductToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            ProductToUpdate.BrandId = product.BrandId;
            ProductToUpdate.ColorId = product.ColorId;
            ProductToUpdate.DailyPrice = product.DailyPrice;
            ProductToUpdate.Description = product.Description;


        }

        List<ProductDetailDto> IProductDal.ProductDetails()
        {
            throw new NotImplementedException();
        }
    }
    }

