using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // Car tablosuyla yapılacak database operasyonlarını burada topluyoruz.
    public interface ICarDal:IEntityRepository<Car>
    {
        //GetById, GetAll, Add, Update, Delete 
        //List<CarDetailDto> GetCarDetails();
        List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null);
    }
}
