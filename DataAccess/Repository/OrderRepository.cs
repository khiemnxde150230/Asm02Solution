using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(int orderId)
        {
            OrderDAO.Instance.Remove(orderId);
        }

        public OrderObject GetOrderById(int orderId)
        {
            return OrderDAO.Instance.GetOrderByID(orderId);
        }

        public IEnumerable<OrderObject> GetOrders()
        {
            return OrderDAO.Instance.GetOrderList();
        }

        public void InsertOrder(OrderObject order)
        {
            OrderDAO.Instance.AddNew(order);
        }

        public void UpdateOrder(OrderObject order)
        {
            OrderDAO.Instance.Update(order);
        }

        public IEnumerable<OrderObject> GetOrderByMemberID(int memberId)
        {
            return OrderDAO.Instance.GetOrderByMemberID(memberId);
        }
    }
}
