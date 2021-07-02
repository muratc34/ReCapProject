using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Core.Entities.Concrete;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //CarsInfoList();
            //RentalTest();
            //UserTest();

        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user1 = new User()
            {
                FirstName = "Hande",
                LastName = "Güler",
                Email = "handegüler@gmail.com",
            };
            var result = userManager.Delete(user1);
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 3, RentDate = (new DateTime(2021, 3, 29, 18, 59, 00)) });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarsInfoList()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            Console.WriteLine(result.Message);

            foreach (var car in result.Data)
            {
                Console.WriteLine("Brand Name: " + car.BrandName);
                Console.WriteLine("Description: " + car.CarName);
                Console.WriteLine("Color Name: " + car.ColorName);
                Console.WriteLine("Daily Price: " + car.DailyPrice);
                Console.WriteLine("-----------------------------------");
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            Console.WriteLine(result.Message);

            foreach (var car in result.Data)
            {
                Console.WriteLine("Id: " + car.Id);
                Console.WriteLine("Brand Id: " + car.BrandId);
                Console.WriteLine("Color Id: " + car.ColorId);
                Console.WriteLine("Model Year: " + car.ModelYear);
                Console.WriteLine("Car Name: " + car.CarName);
                Console.WriteLine("Daily Price: " + car.DailyPrice);
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
