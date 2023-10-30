using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void DeleteOrderDetail(int orderId)
        {
            OrderDetailDAO.Instance.Remove(orderId);
        }

        public OrderDetailObject GetOrderDetailByID(int orderId)
        {
            return OrderDetailDAO.Instance.GetOrderDetailByID(orderId);
        }

        public IEnumerable<OrderDetailObject> GetOrderDetails()
        {
            return OrderDetailDAO.Instance.GetOrderDetailList();
        }

        public void InsertOrderDetail(OrderDetailObject orderDetail)
        {
            OrderDetailDAO.Instance.AddNew(orderDetail);
        }

        public void UpdateOrderDetail(OrderDetailObject orderDetail)
        {
            OrderDetailDAO.Instance.Update(orderDetail);
        }
    }
}
