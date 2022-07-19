using System;
using System.Collections.Generic;
using gldotnet.db;
using gldotnet.Models;


namespace gldotnet.Services
{
    public class CarsService
    {
        internal List<Car> GetCars()
        {
            return FakeDb.Cars;
        }
        internal Car GetCar(string id)
        {
            Car found = FakeDb.Cars.Find(c => c.Id == id);
            if (found == null)
            {
                throw new Exception("Car not found");
            }
            return found;
        }
        internal Car CreateCar(Car carData)
        {
            FakeDb.Cars.Add(carData);
            return carData;
        }
        internal Car Update(Car carData)
        {
            Car original = GetCar(carData.Id);
            original.Name = carData.Name ?? original.Name;
            return original;
        }
        internal Car Delete(string id)
        {
            Car found = GetCar(id);
            FakeDb.Cars.Remove(found);
            return found;
        }
    }
}