using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSite.DTO
{
    public class OrderDTO
    {
        public System.Guid Id { get; set; }
        public PizzaSite.DTO.Enums.Size Size { get; set; }
        public PizzaSite.DTO.Enums.Crust Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool GreenPeppers { get; set; }
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public bool Completed { get; set; }
        public PizzaSite.DTO.Enums.PaymentType PaymentType { get; set; }
    }
}
