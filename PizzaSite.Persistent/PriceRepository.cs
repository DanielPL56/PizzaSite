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
        public static void CreatePrice(PriceDTO priceDTO)
        {
            var price = new Price()
            {
                LargeSizeCost = priceDTO.LargeSizeCost,
                MediumSizeCost = priceDTO.MediumSizeCost,
                SmallSizeCost = priceDTO.SmallSizeCost,
                ThickCrustCost = priceDTO.ThickCrustCost,
                ThinCrustCost = priceDTO.ThinCrustCost,
                RegularCrustCost = priceDTO.RegularCrustCost,
                GreenPepperCost = priceDTO.GreenPepperCost,
                OnionsCost = priceDTO.OnionsCost,
                PepperoniCost = priceDTO.PepperoniCost,
                SausageCost = priceDTO.SausageCost

            };

            using (var db = new ApplicationDbContext())
            {
                var prices = db.Prices;

                prices.Add(price);

                db.SaveChanges();
            }
        }

        public static PriceDTO GetPrice()
        {
            var db = new ApplicationDbContext();
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
