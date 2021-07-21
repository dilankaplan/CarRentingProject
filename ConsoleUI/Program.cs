﻿using Business.Concrete;
using DataAccess.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)

        { 
            ProductManager productManager = new ProductManager(new DataAccess.EntityFramework.EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.DailyPrice);
            }
        }
    }
}
