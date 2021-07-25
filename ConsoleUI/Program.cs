using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)

        {
            //ProductManager productManager = new ProductManager(new EfProductDal());
            //foreach (var product in productManager.GetAll())
            //{
            //   Console.WriteLine(product.ProductName);
            //}
            UserManager userManager = new UserManager(new EfUserDal());
            User user1 = new User();
            user1.FirstName = "Dilan";
            user1.LastName = "Kaplan";
            user1.Email = "dilankaplan@gmail.com";
            user1.Password = "12345";

            User user2 = new User();
            user2.FirstName = "Alp";
            user2.LastName = "Uğurlu";
            user2.Email = "alpugurlu@gmail.com";
            user2.Password = "17021998";




            
        }
    }
}
