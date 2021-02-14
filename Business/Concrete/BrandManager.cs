using Business.Abstract;
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

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetByAll(int Id)
        {
            return _brandDal.Get(c => c.Id == Id);
        }

        public List<Brand> GetCarsByBrandId(int Id)
        {
            return _brandDal.GetAll(p => p.Id == Id);
        }

    }
}
