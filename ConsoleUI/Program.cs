using Business.Concrete;

using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new DataAccess.InMemory.Concrete.InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.DailyPrice);
            }
        }
    }
}
