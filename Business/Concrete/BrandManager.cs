using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public Brand GetByAll(int Id)
        {
            return _brandDal.Get(c => c.Id == Id);
        }

        public List<Brand> GetCarsByBrandId(int Id)
        {
            return _brandDal.GetAll(p => p.Id == Id);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }



        public IDataResult<Brand> GetById(int Id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.Id == Id));
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);

        }

        public IResult UpdateService(Brand entity)
        {
            _brandDal.Update(entity);
            return new SuccessResult(Messages.ColorUpdated);
        }

        public IResult DeleteService(Brand entity)
        {
            _brandDal.Delete(entity);
            return new SuccessResult(Messages.ColorDeleted);
        }


    }
}
