using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=3,CarName = "Walkswogen Passat",DailyPrice=520,ModelYear="2009",Description="Passat" },
                new Car{CarId=2, BrandId=1, ColorId=6,CarName = "Walkswogen Tiguan",DailyPrice=300,ModelYear="2021",Description="Tiguan" },
                new Car{CarId=3, BrandId=2, ColorId=8,CarName = "Opel Astra",DailyPrice=500,ModelYear="2020",Description="Astra" },
                new Car{CarId=4, BrandId=3, ColorId=6,CarName = "Nissan Qashqai",DailyPrice=700,ModelYear="2017",Description="Qashqai" },
                new Car{CarId=5, BrandId=4, ColorId=4,CarName = "Fiat Doblo",DailyPrice=90,ModelYear="2003",Description="Doblo" },
                new Car{CarId=6, BrandId=5, ColorId=2,CarName = "Citroen C4",DailyPrice=200,ModelYear="2012",Description="C4" },


            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
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

        public List<Car> GetAllByBrand(int BrandId)
        {
            return _cars.Where(c => c.CarId == BrandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {

            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetById(int carId)
        //{
        //    return _cars.Where(c => c.CarId == carId).ToList();
        //}

        //public List<CarDetailDto> GetCarDetails()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
