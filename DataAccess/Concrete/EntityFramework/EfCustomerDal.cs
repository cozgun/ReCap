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
        public List<CustomerDetailDto> GetCustomerDetail(Expression<Func<Customer, bool>> filter = null)
        {
            using (CarLeaseContext context = new CarLeaseContext())
            {
                var result = from customer in context.Customers
                             join u in context.Users
                             on customer.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 CustomerId = customer.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = customer.CompanyName,
                                 Email = u.Email
                             };
                return result.ToList();
            }
        }

    }
}
