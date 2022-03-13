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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (DateTime.Now.Hour == 05)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Update(Brand brand)
        {
            if (DateTime.Now.Hour == 05)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

        public IResult Remove(Brand brand)
        {
            if (DateTime.Now.Hour == 05)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _brandDal.Remove(brand);
            return new SuccessResult(Messages.BrandRemoved);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour == 05)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetByBrandId(int brandId)
        {
            if (DateTime.Now.Hour == 05)
            {
                return new ErrorDataResult<Brand>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId)) ;
        }
    }
}
