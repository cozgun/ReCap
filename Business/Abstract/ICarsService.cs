using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarsService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int Id);
        List<Car> GetCarsByColorId(int Id);
        void Add(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}
