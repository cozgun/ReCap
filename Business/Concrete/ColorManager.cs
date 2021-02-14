using Business.Abstract;
using DataAccess.Abstract;
using System;
using Entities.Concrete;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager: IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetByAll(int Id)
        {
            return _colorDal.Get(c => c.Id == Id);
        }

        public List<Color> GetCarsByColorId(int Id)
        {
            return _colorDal.GetAll(p => p.Id == Id);
        }
    }
}
