using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Car tablosuyla yapılacak database operasyonlarını burada topluyoruz.
    public interface ICarDal:IEntityRepository<Car>
    {
        //GetById, GetAll, Add, Update, Delete 
    }
}
