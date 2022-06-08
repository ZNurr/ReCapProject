using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarTest();
//BrandTest();
//ColorTest();
RentalTest();
//CustomerTest();
//RentalGetAll();
static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetCarDetails();
    if (result.Success==true)
    {
        foreach (var car in result.Data)
        {
            Console.WriteLine(car.CarId + " " + car.BrandId + " " +car.BrandName + " " + " " +car.ColorId + " " + car.DailyPrice);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
   
    Car car1 = new Car();

    car1.Id = 11;
    car1.CarName = "BMW";
    car1.BrandId = 2;
    car1.ColorId = 2;
    car1.ModelYear = 2012;
    car1.DailyPrice = 340;
    car1.Description = "Bu araç günlük kiralama için oldukça uygundur.";

    carManager.Add(car1);
}



//static void BrandTest()
//{
//    BrandManager brandManager = new BrandManager(new EfBrandDal());
//    foreach (var brand in brandManager.GetAll())
//    {
//        Console.WriteLine(brand.BrandId + "  " + brand.BrandName);
//    }
//}



//static void ColorTest()
//{
//    ColorManager colorManager = new ColorManager(new EfColorDal());
//    foreach (var color in colorManager.GetAll())
//    {
//        Console.WriteLine(color.ColorId + "  " + color.ColorName);
//    }
//}


    static void RentalTest()
    {
        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        Rental rental = new Rental()
        {
            Id = 2,
            CarId = 2,
            CustomerId = 3,
            //RentDate = DateTime.Now,
            RentDate = DateTime.Parse("2022-06-07"),
            ReturnDate = DateTime.Parse("2022-06-07"),
        };
        rentalManager.Add(rental);
    }




static void CustomerTest()
{
    static void CustomerTest()
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        Customer customer = new Customer()
        {
            Id = 1,
            CompanyName = "Ak Holding",
            UserId = 1,
        };
        customerManager.Add(customer);
       

    }
}




    static void RentalGetAll()
    {
        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        rentalManager.GetAll();
    }