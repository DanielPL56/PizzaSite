<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="PizzaSite.Presentation.Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Your order is being processed ...</h1>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="NextPizzaButton" runat="server" OnClick="NextPizzaButton_Click" Text="Order Next Pizza" />
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="orderManagementButton" runat="server" OnClick="orderManagementButton_Click" Text="Go to Order Management Page" />
            </p>
        </div>
    </form>
</body>
</html>
