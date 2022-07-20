using System;
using System.Collections.Generic;
using gldotnet.Repositories;
using gldotnet.Models;

namespace gldotnet.Services
{
    public class HousesService
    {
        private readonly HousesRepository _repo;
        public HousesService(HousesRepository repo)
        {
            _repo = repo;
        }
        internal List<House> Get()
        {
            return _repo.Get();
        }
        internal House Get(int id)
        {
            House found =  _repo.Get(id);
            if (found == null)
            {
                throw new Exception("House not found");
            }
            return found;
        }
        internal House Create(House houseData)
        {
            return _repo.Create(houseData);
        }
        internal House Update(House houseData)
        {
            House original = Get(houseData.Id);
          
            original.Color = houseData.Color ?? original.Color;
            original.Description = houseData.Description ?? original.Description;
            original.Image = houseData.Image ?? original.Image;
            _repo.Update(original);
            return original;
        }
        internal House Delete(int id)
        {
            House found = Get(id);
            _repo.Delete(id);
            return found;
        }
    }
}