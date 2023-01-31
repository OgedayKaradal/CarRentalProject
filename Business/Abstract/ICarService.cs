using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        Result Add();
        Result Update();
        Result Delete();
        DataResult<List<Car>> GetAll();
        DataResult<List<Car>> GetByName(string carName);
        DataResult<List<Car>> GetByBrand(string brand);
        DataResult<List<Car>> GetByColor(string color);
        DataResult<Car> GetByCarId(int id);

    }
}
