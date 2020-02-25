using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderService.Models;

namespace OrderService.Repositary
{
    public interface IOrderRepositary
    {
        List<Orders> GetAllOrders();
        Orders GetById(string id);
        void AddOrder(Orders obj);
        void DeleteOrder(string id);
        void Update(Orders obj);
    }
}
