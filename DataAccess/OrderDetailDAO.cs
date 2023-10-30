using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccess
{
    public class OrderDetailDAO : BaseDAL
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderDetailObject> GetOrderDetailList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "select * from OrderDetail";
            var orderDetails = new List<OrderDetailObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orderDetails.Add(new OrderDetailObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        ProductId = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetDouble(4)

                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return orderDetails;
        }

        public OrderDetailObject GetOrderDetailByID(int orderId)
        {
            OrderDetailObject orderDetail = null;
            IDataReader dataReader = null;
            string SQLSelect = "select * from OrderDetail where OrderId = @OrderId";
            try
            {
                var param = dataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    orderDetail = new OrderDetailObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        ProductId = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetFloat(4)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return orderDetail;
        }

        public void AddNew(OrderDetailObject orderDetail)
        {
            try
            {
                OrderDetailObject pro = GetOrderDetailByID(orderDetail.OrderId);
                if (pro == null)
                {
                    string SQLInsert = "insert OrderDetail values(@OrderId, @ProductId, @UnitPrice, @Quantity, @Discount)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, orderDetail.OrderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 4, orderDetail.ProductId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 4, orderDetail.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Quantity", 4, orderDetail.Quantity, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Discount", 4, orderDetail.Discount, DbType.Single));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The orderDetail is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(OrderDetailObject orderDetail)
        {
            try
            {
                OrderDetailObject o = GetOrderDetailByID(orderDetail.OrderId);
                if (o != null)
                {
                    string SQLUpdate = "update OrderDetail set ProductId = @ProductId, UnitPrice = @UnitPrice," +
                        "Quantity = @Quantity, Discount = @Discount where OrderId = @OrderId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, orderDetail.OrderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 4, orderDetail.ProductId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 4, orderDetail.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Quantity", 4, orderDetail.Quantity, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Discount", 4, orderDetail.Discount, DbType.Single));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The orderDetail does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int orderId)
        {
            try
            {
                OrderDetailObject orderDetail = GetOrderDetailByID(orderId);
                if (orderDetail != null)
                {
                    string SQLDelete = "delete OrderDetail where OrderId = @OrderId";
                    var param = dataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The orderDetail does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
