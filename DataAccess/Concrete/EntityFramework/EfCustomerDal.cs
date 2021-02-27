using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer, CarLeaseContext>, ICustomerDal
    {
        //public List<CustomerDetailDto> GetCustomerDetails()
        //{
        //    using (CarLeaseContext context = new CarLeaseContext())
        //    {
        //        var result = from p in context.Customers
        //                     join c in context.Users
        //                     on p.UserId equals c.Id
        //                     select new CustomerDetailDto
        //                     {
        //                         CompanyName = p.CompanyName,
        //                         FirstName = c.FirstName,
        //                         LastName = c.LastName,
        //                         Email = c.Email,
        //                         Password = c.Password,
        //                     };    
        //            return result.ToList();
        //    }
        // }

    }
}
