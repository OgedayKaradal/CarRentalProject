using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        Result Add();
        Result Update();
        Result Delete();
        DataResult<List<Color>> GetAll();
        DataResult<List<Color>> GetByName(string colorName);
        DataResult<List<Color>> GetById(int id);
    }
}
