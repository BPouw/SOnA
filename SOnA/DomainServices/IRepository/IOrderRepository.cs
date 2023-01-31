using System;
using Domain;

namespace DomainServices.IRepository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        Order getOrder(int orderNr);
    }
}

