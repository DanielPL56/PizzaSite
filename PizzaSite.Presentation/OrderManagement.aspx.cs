using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaSite.Presentation
{
    public partial class OrderManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            displayOrders();
        }

        private void displayOrders()
        {
            var unCompletedOrders = Domain.OrderManager.GetUnCompletedOrders();

            unCompletedGridView.DataSource = unCompletedOrders;
            unCompletedGridView.DataBind();

            var completedOrders = Domain.OrderManager.GetCompletedOrders();

            completedGridView.DataSource = completedOrders;
            completedGridView.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);

            GridViewRow row = unCompletedGridView.Rows[index];

            var stringOrderId = row.Cells[1].Text.ToString();

            var orderId = new Guid();

            if (!Guid.TryParse(stringOrderId, out orderId))
                throw new Exception("Could not parse Guid...");
            Domain.OrderManager.CompleteOrder(orderId);

            displayOrders();
        }

        protected void goToOrderPizzaButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}