using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150, CarName="Skoda Octavia",ModelYear="2016"},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=200, CarName="Lange Rover Defender",ModelYear="2013"},
                new Car{Id=3,BrandId=2,ColorId=1,DailyPrice=110, CarName="Renault Clio",ModelYear="2015"},
                new Car{Id=4,BrandId=2,ColorId=2,DailyPrice=250, CarName="Ford Mustang",ModelYear="1968"},
                new Car{Id=5,BrandId=2,ColorId=3,DailyPrice=300, CarName="Mercedes-Benz 200D",ModelYear="2019"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarName = car.CarName;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
