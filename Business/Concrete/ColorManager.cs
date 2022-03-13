using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            if (DateTime.Now.Hour == 05)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Update(Color color)
        {
            if (DateTime.Now.Hour == 05)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }

        public IResult Remove(Color color)
        {
            if (DateTime.Now.Hour == 05)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _colorDal.Remove(color);
            return new SuccessResult(Messages.ColorRemoved);
        }

        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour == 05)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.ColorsListed);
        }

        public IDataResult<Color> GetByColorId(int colorId)
        {
            if (DateTime.Now.Hour == 05)
            {
                return new ErrorDataResult<Color>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == colorId));
        }
    }
}
