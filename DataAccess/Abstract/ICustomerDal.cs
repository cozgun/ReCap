using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // Customer tablosuyla yapılacak database operasyonlarını burada topluyoruz.
    public interface ICustomerDal: IEntityRepository<Customer>
    {
        //GetById, GetAll, Add, Update, Delete 
        //List<CustomerDetailDto> GetCustomerDetails();
        List<CustomerDetailDto> GetCustomerDetail(Expression<Func<Customer, bool>> filter = null);
    }
}
