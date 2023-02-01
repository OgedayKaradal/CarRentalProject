using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, SampleDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (SampleDatabaseContext context = new SampleDatabaseContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 CarName = car.CarName,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description
                             };
                return result.ToList();
            }
        }
    }
}
