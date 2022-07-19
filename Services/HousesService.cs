using System;
using System.Collections.Generic;
using gldotnet.db;
using gldotnet.Models;

namespace gldotnet.Services
{
    public class HousesService
    {
        internal List<House> GetHouses()
        {
            return FakeDb.Houses;
        }
        internal House GetHouse(string id)
        {
            House found = FakeDb.Houses.Find(h => h.Id == id);
            if (found == null)
            {
                throw new Exception("House not found");
            }
            return found;
        }
        internal House CreateHouse(House houseData)
        {
            FakeDb.Houses.Add(houseData);
            return houseData;
        }
        internal House Update(House houseData)
        {
            House original = GetHouse(houseData.Id);
            original.Name = houseData.Name ?? original.Name;
            return original;
        }
        internal House Delete(string id)
        {
            House found = GetHouse(id);
            FakeDb.Houses.Remove(found);
            return found;
        }
    }
}