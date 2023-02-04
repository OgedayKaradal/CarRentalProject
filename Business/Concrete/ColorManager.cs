using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Core.Utilities.Results.Concrete;
using Business.Constants;
using Core.CrossCuttingConcerns.Validation;
using Business.ValidationRules.FluentValidation;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            ValidationTool.Validate(new ColorValidator(), color);
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorRemoved);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetByColorId(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == id));
        }

        public IDataResult<List<Color>> GetByColorName(string colorName)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(c => c.ColorName.ToLower().Contains(colorName.ToLower())));
        }

        public IResult Update(Color color)
        {
            ValidationTool.Validate(new ColorValidator(), color);
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
