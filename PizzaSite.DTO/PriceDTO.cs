using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSite.DTO
{
    public class PriceDTO
    {
        public int Id { get; set; }
        public decimal SmallSizeCost { get; set; }
        public decimal MediumSizeCost { get; set; }
        public decimal LargeSizeCost { get; set; }
        public decimal ThinCrustCost { get; set; }
        public decimal RegularCrustCost { get; set; }
        public decimal ThickCrustCost { get; set; }
        public decimal SausageCost { get; set; }
        public decimal PepperoniCost { get; set; }
        public decimal OnionsCost { get; set; }
        public decimal GreenPepperCost { get; set; }
    }
}
