using System.Collections.Generic;
using DariusDDD.Domain.Models;

namespace DariusDDD.Domain.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        List<Order> QueryOrders();
    }
}
