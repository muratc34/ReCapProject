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
            CarsInfoList();

        }

        private static void CarsInfoList()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
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
            carManager.Add(new Car() {CarName = "Clio", ModelYear = "2015", BrandId = 5, ColorId = 4, DailyPrice = 100 });
            carManager.Update(new Car() { Id = 5, CarName = "190E", ModelYear = "1997", BrandId = 2, ColorId = 1, DailyPrice = 500 });

            foreach (var car in carManager.GetAll())
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
