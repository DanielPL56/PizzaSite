using PizzaSite.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSite.Persistent
{
    public class OrderRepository
    {
        public static void CreateOrder(OrderDTO orderDTO)
        {
            var db = new ApplicationDbContext();

            db.Orders.Add(ConverToDb(orderDTO));
            db.SaveChanges();
        }

        private static Order ConverToDb(OrderDTO orderDTO)
        {
            var order = new Order();

            order.Id = orderDTO.Id;
            order.Size = orderDTO.Size;
            order.Crust = orderDTO.Crust;
            order.Sausage = orderDTO.Sausage;
            order.Pepperoni = orderDTO.Pepperoni;
            order.Onions = orderDTO.Onions;
            order.GreenPeppers = orderDTO.GreenPeppers;
            order.Name = orderDTO.Name;
            order.Address = orderDTO.Address;
            order.PostCode = orderDTO.PostCode;
            order.PhoneNumber = orderDTO.PhoneNumber;
            order.PaymentType = orderDTO.PaymentType;
            order.TotalCost = orderDTO.TotalCost;
            order.Completed = orderDTO.Completed;

            return order;
        }

        public static List<DTO.OrderDTO> GetUnCompletedOrders()
        {
            var db = new ApplicationDbContext();
            var orders = db.Orders.Where(p => p.Completed == false).ToList();

            return convertToDTO(orders);
        }

        public static List<DTO.OrderDTO> GetCompletedOrders()
        {
            var db = new ApplicationDbContext();
            var orders = db.Orders.Where(p => p.Completed == true).ToList();

            return convertToDTO(orders);
        }

        private static List<DTO.OrderDTO> convertToDTO(List<Order> orders)
        {
            var ordersDTO = new List<DTO.OrderDTO>();

            foreach (var order in orders)
            {
                var orderDTO = new DTO.OrderDTO();

                orderDTO.Id = order.Id;
                orderDTO.Size = order.Size;
                orderDTO.Crust = order.Crust;
                orderDTO.Sausage = order.Sausage;
                orderDTO.Pepperoni = order.Pepperoni;
                orderDTO.Onions = order.Onions;
                orderDTO.GreenPeppers = order.GreenPeppers;
                orderDTO.Name = order.Name;
                orderDTO.Address = order.Address;
                orderDTO.PostCode = order.PostCode;
                orderDTO.PhoneNumber = order.PhoneNumber;
                orderDTO.PaymentType = order.PaymentType;
                orderDTO.TotalCost = order.TotalCost;
                orderDTO.Completed = order.Completed;

                ordersDTO.Add(orderDTO);
            }

            return ordersDTO;
        }

        public static void CompleteOrder(Guid orderId)
        {
            var db = new ApplicationDbContext();

            var orders = db.Orders.Where(p => p.Id == orderId);

            foreach (var order in orders)
            {
                order.Completed = true;
            }

            db.SaveChanges();
        }
    }
}
