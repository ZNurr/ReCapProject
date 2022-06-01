using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;


ICarService carManager = new CarManager(new EfCarDal());
foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Id + "---" + car.BrandId + "---" + car.ColorId + "---" + car.DailyPrice + "---" + car.Description);
}

