using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderService.Models;
using OrderService.Controllers;
using OrderService.Repositary;


namespace OrderService.Repositary
{
    public class OrderRepositary : IOrderRepositary
    {
        private readonly ShopDBContext _context;
        public OrderRepositary(ShopDBContext context)
        {
            _context = context;
        }
        public void AddOrder(Orders obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteOrder(string id)
        {
            Orders item = _context.Orders.Find(id);
            _context.Orders.Remove(item);
            _context.SaveChanges();
        }

        public List<Orders> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Orders GetById(string id)
        {
            return _context.Orders.Find(id);
        }

        public void Update(Orders obj)
        {
            _context.Orders.Update(obj);
            _context.SaveChanges();
        }
    }
}
