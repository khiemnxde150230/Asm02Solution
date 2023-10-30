using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO : BaseDAL
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderObject> GetOrderList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "select * from [Order]";
            var orders = new List<OrderObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orders.Add(new OrderObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        ShippedDate = dataReader.GetDateTime(3),
                        Freight = dataReader.GetDecimal(4),
                        RequiredDate = dataReader.GetDateTime(5),

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
            return orders;
        }

        public OrderObject GetOrderByID(int orderId)
        {
            OrderObject order = null;
            IDataReader dataReader = null;
            string SQLSelect = "select * from [Order] where OrderId = @OrderId";
            try
            {
                var param = dataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    order = new OrderObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        ShippedDate = dataReader.GetDateTime(3),
                        Freight = dataReader.GetDecimal(4),
                        RequiredDate = dataReader.GetDateTime(5),

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
            return order;
        }

        public IEnumerable<OrderObject> GetOrderByMemberID(int memberId)
        {
            IDataReader dataReader = null;
            string SQLSelect = "select * from [Order] where MemberId = @MemberId";
            var orders = new List<OrderObject>();
            try
            {
                var param = dataProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    orders.Add(new OrderObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        ShippedDate = dataReader.GetDateTime(3),
                        Freight = dataReader.GetDecimal(4),
                        RequiredDate = dataReader.GetDateTime(5),
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
            return orders;
        }

        public void AddNew(OrderObject order)
        {
            try
            {
                OrderObject pro = GetOrderByID(order.OrderId);
                if (pro == null)
                {
                    string SQLInsert = "insert into [Order] values(@OrderId, @MemberId, @OrderDate, @ShippedDate, @Freight, @RequiredDate)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, order.OrderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, order.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderDate", 50, order.OrderDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@ShippedDate", 50, order.ShippedDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@Freight", 4, order.Freight, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@RequiredDate", 50, order.RequiredDate, DbType.DateTime));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order is already exist.");
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

        public void Update(OrderObject order)
        {
            try
            {
                OrderObject o = GetOrderByID(order.OrderId);
                if (o != null)
                {
                    string SQLUpdate = "update [Order] set MemberId = @MemberId, OrderDate = @OrderDate," +
                        " ShippedDate = @ShippedDate, Freight = @Freight, RequiredDate = @RequiredDate where OrderId = @OrderId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, order.OrderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, order.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderDate", 50, order.OrderDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@ShippedDate", 50, order.ShippedDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@Freight", 4, order.Freight, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@RequiredDate", 50, order.RequiredDate, DbType.DateTime));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order does not already exist.");
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
                OrderObject order = GetOrderByID(orderId);
                if (order != null)
                {
                    string SQLDelete = "delete [Order] where OrderId = @OrderId";
                    var param = dataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The order does not already exist.");
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
