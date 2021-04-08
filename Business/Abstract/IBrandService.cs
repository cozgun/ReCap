using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService

    {
        IDataResult<List<Brand>> GetAll();
        Brand GetByAll(int Id);
        IDataResult<Brand> GetById(int Id);
        IResult Add(Brand brand);
        IResult UpdateService(Brand brand);
        IResult DeleteService(Brand brand);
    }
}
