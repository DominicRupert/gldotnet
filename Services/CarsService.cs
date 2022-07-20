using System;
using System.Collections.Generic;
using gldotnet.Models;
using gldotnet.Repositories;


namespace gldotnet.Services
{
    public class CarsService
    {
        private readonly CarsRepository _repo;
        public CarsService(CarsRepository repo)
        {
            _repo = repo;
        }
        internal List<Car> Get()
        {
            return _repo.Get();
        }
        internal Car Get(int id)
        {
            return _repo.Get(id);
            if (found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;
        }
        internal Car Create(Car carData)
        {
            return _repo.Create(carData);
        }
       
           internal Car Update(Car carData)
        {
            Car original = Get(carData.Id);
            original.Make = carData.Make ?? original.Make;
            original.Price = carData.Price ?? original.Price;
            original.Year = carData.Year ?? original.Year;
            
                
            original.Color = carData.Color ?? original.Color;

            original.Description = carData.Description ?? original.Description;
            original.Image = carData.Image ?? original.Image;
            _repo.Update(original);

            return original;
        }
        internal Car Delete(int id, string userId)
        {
            Car original = Get(id);
          _repo.Delete(id);
            return original;
        }
    }
    //     internal List<Car> GetCars()
    //     {
    //         return FakeDb.Cars;
    //     }
    //     internal Car GetCar(string id)
    //     {
    //         Car found = FakeDb.Cars.Find(c => c.Id == id);
    //         if (found == null)
    //         {
    //             throw new Exception("Car not found");
    //         }
    //         return found;
    //     }
    //     internal Car CreateCar(Car carData)
    //     {
    //         FakeDb.Cars.Add(carData);
    //         return carData;
    //     }
        // internal Car Update(Car carData)
        // {
        //     Car original = GetCar(carData.Id);
        //     original.Make = carData.Make ?? original.Make;
        //     original.Price = carData.Price ?? original.Price;
        //     original.Year = carData.Year ?? original.Year;
            
                
        //     original.Color = carData.Color ?? original.Color;

        //     original.Description = carData.Description ?? original.Description;
        //     original.Image = carData.Image ?? original.Image;

        //     return original;
        // }
    //     internal Car Delete(string id)
    //     {
    //         Car found = GetCar(id);
    //         FakeDb.Cars.Remove(found);
    //         return found;
    //     }
    }
