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

        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç eklendi, hayırlı olsun");
            }
            Console.WriteLine("Araç eklenemedi, araç isim uzunluğu 2'den küçük ya da günlük fiyat 0 girilmiş olabilir");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();

         }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(p => p.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(p => p.ColorId == Id);
        }
    }
}
