using Business.Abstract;
using Business.Constants;
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

        IResult IBrandService.GetByAll(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brand>> GetById(int Id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(p => p.Id == Id));
        }

        public IResult Add(Brand brand)
        {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandAdded);

        }
    }
}
