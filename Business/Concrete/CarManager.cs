using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Business.BusinessAspects;
using Business.BusinessAspects.Autofac;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;

namespace Business.Concrete
{
    public class CarManager : ICarsService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carsDal)
        {
            _carDal = carsDal;
        }

        //claim
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarsService.Get")] // key, value pair
        public IResult Add(Car car)
        {

            ValidationTool.Validate(new CarValidator(), car);
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }

        [CacheAspect] // key, value pair
        public IDataResult<List<Car>> GetAll()
        {
            //if (DateTime.Now.Hour == 0)
            //{
            //    return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            //}

                return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);

         }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        //public IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId)
        //{
        //    //return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsByBrandId(p => p.BrandId == brandId));
        //    return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(p => p.brandId == brandId));
        //}

        [CacheAspect]
        public IDataResult<List<Car>> GetById(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.Id== Id));
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice < 10)
            {
                throw new Exception("");
            }
            Add(car);
            return null;
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == Id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.BrandId == brandId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByColorId(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.ColorId == colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int carId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.Id == carId));
        }


    }
}
