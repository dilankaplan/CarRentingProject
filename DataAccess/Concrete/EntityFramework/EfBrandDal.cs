using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, DatabaseContext>, IBrandDal
    {
        public List<Brand> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }
    }
}
