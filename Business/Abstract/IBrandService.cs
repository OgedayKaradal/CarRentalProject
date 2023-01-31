using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        Result Add();
        Result Update();
        Result Delete();
        DataResult<List<Brand>> GetAll();
        DataResult<List<Brand>> GetByName(string brandName);
        DataResult<List<Brand>> GetById(int id);
    }
}
