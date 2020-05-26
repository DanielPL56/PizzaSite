using PizzaSite.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSite.Persistent
{
    public class PriceRepository
    {
        public static PriceDTO GetPrice()
        {
            var db = new PizzaSiteDbEntities();
            var prices = db.Prices.First();

            var priceDTO = ConvertToDTO(prices);

            return priceDTO;
        }

        private static PriceDTO ConvertToDTO(Price price)
        {
            var priceDTO = new PriceDTO();

                priceDTO.SmallSizeCost = price.SmallSizeCost;
                priceDTO.MediumSizeCost = price.MediumSizeCost;
                priceDTO.LargeSizeCost = price.LargeSizeCost;
                priceDTO.ThinCrustCost = price.ThinCrustCost;
                priceDTO.RegularCrustCost = price.RegularCrustCost;
                priceDTO.ThickCrustCost = price.ThickCrustCost;
                priceDTO.SausageCost = price.SausageCost;
                priceDTO.PepperoniCost = price.PepperoniCost;
                priceDTO.OnionsCost = price.OnionsCost;
                priceDTO.GreenPepperCost = price.GreenPepperCost;

            return priceDTO;
        }
    }
}
