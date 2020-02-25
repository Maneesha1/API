using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itemservice.Models;

namespace Itemservice.Repositary
{
    public interface IItemRepositary
    {
        List<Items> GetAllItems();
        Items GetById(string id);
        void AddItem(Items obj);
        void DeleteItem(string id);
        void Update(Items obj);
    }
}




