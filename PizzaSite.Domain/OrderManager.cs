using PizzaSite.DTO;
using PizzaSite.Persistent;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSite.Domain
{
    public class OrderManager
    {
        const string errorTypeName = "Type your name";
        const string errorTypeAddress = "Type your address";
        const string errorTypePostCode = "Type your Post Code";
        const string errorTypePhoneNumber = "Type your Phone Number";

        public static void CreateOrder(OrderDTO orderDTO)
        {
            if (orderDTO.Name.Trim().Length == 0)
                throw new Exception(errorTypeName);
            if (orderDTO.Address.Trim().Length == 0)
                throw new Exception(errorTypeAddress);
            if (orderDTO.PostCode.Trim().Length == 0)
                throw new Exception(errorTypePostCode);
            if (orderDTO.PhoneNumber.Trim().Length == 0)
                throw new Exception(errorTypePhoneNumber);

            orderDTO.Id = Guid.NewGuid();
            orderDTO.Completed = false;

            PizzaPriceManager.CalculateCostOfPizza(orderDTO);

            OrderRepository.CreateOrder(orderDTO);
        }

        public static List<DTO.OrderDTO> GetUnCompletedOrders()
        {
            return Persistent.OrderRepository.GetUnCompletedOrders();
        }

        public static List<DTO.OrderDTO> GetCompletedOrders()
        {
            return Persistent.OrderRepository.GetCompletedOrders();
        }

        public static void CompleteOrder(Guid orderId)
        {
            Persistent.OrderRepository.CompleteOrder(orderId);
        }
    }
}
