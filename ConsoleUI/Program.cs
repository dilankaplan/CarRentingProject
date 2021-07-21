using Business.Concrete;
using DataAccess.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)

        {
            DatabaseContext databaseContex = new DatabaseContext();
            foreach (var product in DatabaseContext.Cars)
            {
                Console.WriteLine(product.ProductName);
            }



            ProductManager productManager = new ProductManager(new DataAccess.EntityFramework.EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.DailyPrice);
            }
        }
    }
}
