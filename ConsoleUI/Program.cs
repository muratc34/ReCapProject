using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Brand Id: " +car.BrandId);
                Console.WriteLine("Color Id: " + car.ColorId);
                Console.WriteLine("Model Year: " + car.ModelYear);
                Console.WriteLine("Description: " + car.Description);
                Console.WriteLine("Daily Price: " + car.DailyPrice);
                Console.WriteLine("-----------------------------------");
            }
            
        }
    }
}
