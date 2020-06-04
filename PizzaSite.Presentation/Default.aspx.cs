using PizzaSite.Domain;
using PizzaSite.DTO;
using PizzaSite.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaSite.Presentation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var price = new PriceDTO()
            //{
            //    SmallSizeCost = 12,
            //    MediumSizeCost = 14,
            //    LargeSizeCost = 16,
            //    ThickCrustCost = 2,
            //    ThinCrustCost = 0,
            //    RegularCrustCost = 1,
            //    SausageCost = 2,
            //    PepperoniCost = 1.5M,
            //    OnionsCost = 1,
            //    GreenPepperCost = 1
            //};

            //Domain.PizzaPriceManager.CreatePrice(price);
        }

        protected void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (!isValidateDropDownList())
                return;

            if (!isValidateTextBoxes())
                return;

            var orderDTO = new OrderDTO();

            string errorMessage;
            try
            {
                assignOrderInformationFromPage(orderDTO);
                Domain.OrderManager.CreateOrder(orderDTO);
            }
            catch (Exception ex)
            {
                errorMessage = "There was a problem" + ex.Message;
            }

            Response.Redirect("Success.aspx");
        }

        private bool isValidateDropDownList()
        {
            if (sizeDropDownList.SelectedValue.Trim().Length == 0)
            {
                errorLabel.Text = "Choice size of pizza";
                errorLabel.Visible = true;
                return false;
            }

            if (crustDropDownList.SelectedValue.Trim().Length == 0)
            {
                errorLabel.Text = "Choice crust of pizza";
                errorLabel.Visible = true;
                return false;
            }
            else return true;
        }

        private bool isValidateTextBoxes()
        {
            if (nameTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = errorLabelMessage("Name");
                return false;
            }

            if (addressTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = errorLabelMessage("Address");
                return false;
            }

            if (postCodeTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = errorLabelMessage("Post Code");
                return false;
            }

            if (phoneNumberTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = errorLabelMessage("Phone Number");
                return false;
            }
            
            else return true;
        }

        private string errorLabelMessage(string type)
        {
            string message = $"Type your {type}";
            errorLabel.Visible = true;
            return message;
        }

        protected void recalculateTotalCost(object sender, EventArgs e)
        {
            if (sizeDropDownList.SelectedValue.Trim().Length == 0)
                return;
            if (crustDropDownList.SelectedValue.Trim().Length == 0)
                return;

            var orderDTO = new OrderDTO();
            
            assignOrderInformationFromPage(orderDTO);
            Domain.PizzaPriceManager.CalculateCostOfPizza(orderDTO);
            totalCostLabel.Text = $"{orderDTO.TotalCost:C2}";
        }

        private void assignOrderInformationFromPage(OrderDTO orderDTO)
        {
            orderDTO.Size = determineSize();
            orderDTO.Crust = determineCrust();
            orderDTO.Sausage = sausageCheckBox.Checked;
            orderDTO.Pepperoni = pepperoniCheckBox.Checked;
            orderDTO.Onions = onionsCheckBox.Checked;
            orderDTO.GreenPeppers = greenPeppersCheckBox.Checked;
            orderDTO.Name = nameTextBox.Text;
            orderDTO.Address = addressTextBox.Text;
            orderDTO.PhoneNumber = phoneNumberTextBox.Text;
            orderDTO.PostCode = postCodeTextBox.Text;
            orderDTO.PaymentType = determinePayment();
        }

        private DTO.Enums.Size determineSize()
        {
            DTO.Enums.Size size;

            if (!Enum.TryParse(sizeDropDownList.SelectedValue.ToString(), out size))
            {
                throw new Exception(displayExceptionMessage("Size"));
            }
            return size;
        }

        private DTO.Enums.Crust determineCrust()
        {
            DTO.Enums.Crust crust;

            if (!Enum.TryParse(crustDropDownList.SelectedValue.ToString(), out crust))
                throw new Exception(displayExceptionMessage("Crust"));

                return crust;
        }

        private DTO.Enums.PaymentType determinePayment()
        {
            if (cashRadioButton.Checked)
                return DTO.Enums.PaymentType.Cash;
            else return DTO.Enums.PaymentType.Card;
        }

        private string displayExceptionMessage(string typeOfMessage)
        {
            string message = String.Format("Can't determine {0}", typeOfMessage);
            return message;
        }
    }
}