using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarLeaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarLeaseContext context = new CarLeaseContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.BrandId equals c.Id
                             select new CarDetailDto
                             {
                                 CarName = p.Description,
                                 BrandName = c.Name,
                                 DailyPrice = p.DailyPrice
                             };
                return result.ToList();
            }
            
        }
    }
}
