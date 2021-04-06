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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarLeaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (CarLeaseContext context = new CarLeaseContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.Id
                             join cu in context.Customers on r.CustomerId equals cu.Id
                             join u in context.Users on cu.UserId equals u.Id
                             join brand in context.Brands on c.BrandId equals brand.Id
                             join color in context.Colors on c.ColorId equals color.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarName = c.Description,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,

                                                                  
                                 CompanyName = cu.CompanyName,
                                 CarDailyPrice = c.DailyPrice,
                                 CarId = c.Id,
                                 BrandName = brand.Name,
                                 ColorName = color.Name,

                             };
                return result.ToList();

            }
        }

    }
}
