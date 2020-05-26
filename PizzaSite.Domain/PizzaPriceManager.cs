using PizzaSite.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSite.Domain
{
    public class PizzaPriceManager
    {
        public static void CalculateCostOfPizza(OrderDTO orderDTO)
        {
            decimal totalCost = 0;

            var price = Persistent.PriceRepository.GetPrice();

            totalCost += calculateSizeCost(orderDTO, price);
            totalCost += calculateCrustCost(orderDTO, price);
            totalCost += calculateIngredientsCost(orderDTO, price);

            orderDTO.TotalCost = totalCost;
        }

        private static decimal calculateSizeCost(OrderDTO orderDTO, PriceDTO price)
        {
            decimal sizeCost = 0;

            if (orderDTO.Size == DTO.Enums.Size.Large)
                sizeCost = price.LargeSizeCost;
            if (orderDTO.Size == DTO.Enums.Size.Medium)
                sizeCost = price.MediumSizeCost;
            if (orderDTO.Size == DTO.Enums.Size.Small)
                sizeCost = price.SmallSizeCost;

            return sizeCost;
        }

        private static decimal calculateCrustCost(OrderDTO orderDTO, PriceDTO price)
        {
            decimal crustCost = 0;

            if (orderDTO.Crust == DTO.Enums.Crust.Thick)
                crustCost = price.ThickCrustCost;
            if (orderDTO.Crust == DTO.Enums.Crust.Regular)
                crustCost = price.RegularCrustCost;
            if (orderDTO.Crust == DTO.Enums.Crust.Thin)
                crustCost = price.ThinCrustCost;

            return crustCost;
        }

        private static decimal calculateIngredientsCost(OrderDTO order, PriceDTO price)
        {
            decimal ingredientsCost = 0;

            if (order.Sausage)
                ingredientsCost += price.SausageCost;
            if (order.Pepperoni)
                ingredientsCost += price.PepperoniCost;
            if (order.Onions)
                ingredientsCost += price.OnionsCost;
            if (order.GreenPeppers)
                ingredientsCost += price.GreenPepperCost;

            return ingredientsCost;
        }
    }
}
