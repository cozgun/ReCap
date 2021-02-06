using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarsService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carsDal)
        {
            _carDal = carsDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();

         }
    }
}
