﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 3, DailyPrice = 5000000, Description = "BMW", ModelYear = 2022 },
                new Car { Id = 2, BrandId = 2, ColorId = 5, DailyPrice = 400000, Description = "Mercedes", ModelYear = 2020 },
                new Car { Id = 3, BrandId = 3, ColorId = 8, DailyPrice = 690000, Description = "Volvo", ModelYear = 2021 },
                new Car { Id = 4, BrandId = 4, ColorId = 1, DailyPrice = 500000, Description = "JEEP", ModelYear = 2022 }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(p => p.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}