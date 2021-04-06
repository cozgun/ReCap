using Business.Abstract;
using DataAccess.Abstract;
using System;
using Entities.Concrete;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
    public class ColorManager: IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public Color GetByAll(int Id)
        {
            return _colorDal.Get(c => c.Id == Id);
        }

        public List<Color> GetCarsByColorId(int Id)
        {
            return _colorDal.GetAll(p => p.Id == Id);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<List<Color>> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }


    }
}
