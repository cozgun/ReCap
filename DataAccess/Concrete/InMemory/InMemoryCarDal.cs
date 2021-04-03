using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car { BrandId=1, ColorId = 1, DailyPrice=50, Id=1, ModelYear=2019, Description="Kar lastikli"},
            new Car { BrandId = 1, ColorId = 1, DailyPrice = 150, Id = 2, ModelYear = 2018, Description = "Station wagon" },
            new Car { BrandId = 3, ColorId = 2, DailyPrice = 100, Id = 3, ModelYear = 2017, Description = "Otomatik" },
            new Car { BrandId = 4, ColorId = 3, DailyPrice = 75, Id = 4, ModelYear = 2016, Description = "Dize" },
            new Car { BrandId = 4, ColorId = 4, DailyPrice = 200, Id = 5, ModelYear = 2015, Description = "Limo" }
            };
        }
        
        public void Add(Car car)
        {
 
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;


        }
    }
}
