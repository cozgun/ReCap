using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();
            //CarDetailTest();
            //CustomerAddTest();

            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //rentalManager.Add(new Rental { Id = 5, CarId=1, CustomerId = 2, RentDate = System.DateTime.Now });

            //UserManager userManager = new UserManager(new EfUserDal());
            //var result = userManager.GetClaims();
            //Console.WriteLine(userManager.GetClaims("1003");

        }

        private static void CustomerAddTest()
        {
            Customer cust = new Customer { Id = 5, CompanyName = "Ar Döner" };

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(cust);
            Console.WriteLine("Müşteri eklendi, hayırlı olsun");
        }

        //private static void CarDetailTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    var result = carManager.GetCarDetails();
        //    if (result.Success == true)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.CarName + " / " + car.BrandName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}



        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.Name);
        //    }
        //}

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.Name);
        //    }
        //}

        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //}
    }
}
