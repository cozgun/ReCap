using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            if (customer.CompanyName.Length > 2 )
            {
                _customerDal.Add(customer);
                return new SuccessResult(Messages.CustomerAdded);
                //Console.WriteLine("Müşteri eklendi, hayırlı olsun");
            }
            return new ErrorResult(Messages.CustomerNameInvalid);
            //Console.WriteLine("Müşteri eklenemedi, isim uzunluğu 2'den küçük olabilir");

        }


        public IDataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            throw new NotImplementedException();
        }
    }
}
