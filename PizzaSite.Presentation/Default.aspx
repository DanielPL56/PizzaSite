<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizzaSite.Presentation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order your Delicious Pizza</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class ="container">
            <h1>Order Your Delicious Pizza</h1>
            <div class="lead">Choose what you like!</div>
            <hr />

            <div class="form-group">
                <label>Size: </label>
                <asp:DropDownList ID ="sizeDropDownList" runat ="server" AutoPostBack ="true" Width ="400" CssClass ="form-control" OnSelectedIndexChanged ="recalculateTotalCost">
                    <asp:ListItem Text ="Choose your size" Selected ="True" Value ="" ></asp:ListItem> 
                    <asp:ListItem Text ="Small (+ $12)" Value ="Small" ></asp:ListItem> 
                    <asp:ListItem Text ="Medium (+ $14)" Value ="Medium" ></asp:ListItem>
                    <asp:ListItem Text ="Large (+ $16)" Value ="Large" ></asp:ListItem>
                       </asp:DropDownList>
            </div>

            <div class="form-group">
                <label>Crust: </label>
                <asp:DropDownList ID ="crustDropDownList" runat ="server" AutoPostBack ="true" Width ="400" CssClass="form-control" OnSelectedIndexChanged ="recalculateTotalCost">
                    <asp:ListItem Text ="Choose your crust" Selected ="True" Value =""></asp:ListItem>
                    <asp:ListItem Text ="Thin" Value ="Thin" ></asp:ListItem>
                    <asp:ListItem Text ="Regular (+ $1)" Value ="Regular"></asp:ListItem>
                    <asp:ListItem Text ="Thick (+ $2)" Value ="Thick"></asp:ListItem>
                               </asp:DropDownList>
            </div>

            <asp:CheckBox ID ="sausageCheckBox" AutoPostBack ="true" OnCheckedChanged ="recalculateTotalCost" Text ="Sausage (+ $2)" runat ="server" /><br />
            <asp:CheckBox ID ="pepperoniCheckBox" AutoPostBack ="true" OnCheckedChanged ="recalculateTotalCost" Text ="Pepperoni (+ $1.5)" runat ="server" /><br />
            <asp:CheckBox ID ="onionsCheckBox" AutoPostBack ="true" OnCheckedChanged ="recalculateTotalCost" Text ="Onions (+ $1)" runat ="server" /><br />
            <asp:CheckBox ID ="greenPeppersCheckBox" AutoPostBack ="true" OnCheckedChanged ="recalculateTotalCost" Text ="Green Peppers (+ $1)" runat ="server" /><br />
            
            <h2>Deliver To: </h2> 
            <br />

            <div >
                <label>Name: </label><asp:TextBox ID ="nameTextBox" runat ="server" CssClass ="form-control" Width ="400" ></asp:TextBox>
                <label>Address: </label><asp:TextBox ID ="addressTextBox" runat ="server" CssClass ="form-control" Width ="400"></asp:TextBox>
                <label>Post code: </label><asp:TextBox ID ="postCodeTextBox" runat ="server" CssClass ="form-control" Width ="400"></asp:TextBox>
                <label>Phone Number: </label><asp:TextBox ID ="phoneNumberTextBox" runat ="server" CssClass ="form-control" Width ="400"></asp:TextBox>
            </div>
            <br />

            <asp:Label runat ="server" ID ="errorLabel" BackColor ="#ff0000" Visible ="false" ></asp:Label>

            <h2>Payment: </h2>
            <br />

            <div>
                <label>Cash:</label><asp:RadioButton ID ="cashRadioButton" runat ="server" Checked ="true" GroupName ="Payment" CssClass ="form-group" /><br />
                <label>Card:</label><asp:RadioButton ID ="creditRadioButton" runat ="server" GroupName ="Payment" CssClass ="form-group" /><br />
            </div>


            <asp:Button ID="CreateOrderButton" runat="server" Text="Create Order" OnClick ="CreateOrderButton_Click" />
            <br />
            <br />

            <label>Total Cost: </label><asp:Label ID ="totalCostLabel" runat ="server"></asp:Label> 
        </div>
    </form>
    <script src="Scripts/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
