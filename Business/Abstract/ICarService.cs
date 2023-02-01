using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByName(string carName);
        IDataResult<List<Car>> GetByModelYear(int minYear, int maxYear);
        IDataResult<List<Car>> GetByPrice(decimal minPrice, decimal maxPrice);
        IDataResult<Car> GetByCarId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();

    }
}
