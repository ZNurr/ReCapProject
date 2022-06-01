using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
       

        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.Id equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 DailyPrice =c.DailyPrice,
                                 
                             };
                return result.ToList();

            }
        }
    }
}
