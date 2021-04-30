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
