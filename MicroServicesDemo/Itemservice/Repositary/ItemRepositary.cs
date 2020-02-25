using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itemservice.Models;

namespace Itemservice.Repositary
{
    public class ItemRepositary:IItemRepositary
    {
        private readonly ShopDBContext _context;
        public ItemRepositary(ShopDBContext context)
        {
            _context = context;
        }
        public void AddItem(Items obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteItem(string id)
        {
            Items item = _context.Items.Find(id);
            _context.Items.Remove(item);
            _context.SaveChanges();

        }

        public List<Items> GetAllItems()
        {
            return _context.Items.ToList();
        }

        public Items GetById(string id)
        {
            return _context.Items.Find(id);
        }

        public void Update(Items obj)
        {
            _context.Items.Update(obj);
            _context.SaveChanges();
        }
    }
}



﻿
