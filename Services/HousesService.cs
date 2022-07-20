// using System;
// using System.Collections.Generic;
// using gldotnet.db;
// using gldotnet.Models;

// namespace gldotnet.Services
// {
//     public class HousesService
//     {
//         internal List<House> Get()
//         {
//             return FakeDb.Houses;
//         }
//         internal House Get(string id)
//         {
//             House found = FakeDb.Houses.Find(h => h.Id == id);
//             if (found == null)
//             {
//                 throw new Exception("House not found");
//             }
//             return found;
//         }
//         internal House Create(House houseData)
//         {
//             FakeDb.Houses.Add(houseData);
//             return houseData;
//         }
//         internal House Update(House houseData)
//         {
//             House original = Get(houseData.Id);
          
//             original.Color = houseData.Color ?? original.Color;
//             original.Description = houseData.Description ?? original.Description;
//             original.Image = houseData.Image ?? original.Image;
//             return original;
//         }
//         internal House Delete(string id)
//         {
//             House found = Get(id);
//             FakeDb.Houses.Remove(found);
//             return found;
//         }
//     }
// }