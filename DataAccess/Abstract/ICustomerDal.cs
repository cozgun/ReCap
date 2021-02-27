using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Customer tablosuyla yapılacak database operasyonlarını burada topluyoruz.
    public interface ICustomerDal: IEntityRepository<Customer>
    {
        //GetById, GetAll, Add, Update, Delete 
        //List<CustomerDetailDto> GetCustomerDetails();

    }
}
