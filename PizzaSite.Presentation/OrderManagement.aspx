<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderManagement.aspx.cs" Inherits="PizzaSite.Presentation.OrderManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>TO DO:</h1>
            <br />
            <asp:GridView ID="unCompletedGridView" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:ButtonField Text="Complete order" />
                    <asp:BoundField DataField="Id" HeaderText="OrderId" />
                    <asp:BoundField DataField="Size" HeaderText="Size" />
                    <asp:BoundField DataField="Crust" HeaderText="Crust" />
                    <asp:BoundField DataField="TotalCost" DataFormatString="{0:C2}" HeaderText="TotalCost" />
                    <asp:CheckBoxField DataField="Sausage" HeaderText="Sausage" />
                    <asp:CheckBoxField DataField="Pepperoni" HeaderText="Pepperoni" />
                    <asp:CheckBoxField DataField="Onions" HeaderText="Onions" />
                    <asp:CheckBoxField DataField="GreenPeppers" HeaderText="GreenPeppers" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="PostCode" HeaderText="Post Code" />
                    <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
                    <asp:CheckBoxField DataField="Completed" HeaderText="Completed" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="Gray" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <asp:Button ID="goToOrderPizzaButton" runat="server" OnClick="goToOrderPizzaButton_Click" Text="Order Pizza" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <h1>Orders History</h1>
            <asp:GridView ID="completedGridView" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:ButtonField Text="Complete order" />
                    <asp:BoundField DataField="Id" HeaderText="OrderId" />
                    <asp:BoundField DataField="Size" HeaderText="Size" />
                    <asp:BoundField DataField="Crust" HeaderText="Crust" />
                    <asp:BoundField DataField="TotalCost" DataFormatString="{0:C2}" HeaderText="TotalCost" />
                    <asp:CheckBoxField DataField="Sausage" HeaderText="Sausage" />
                    <asp:CheckBoxField DataField="Pepperoni" HeaderText="Pepperoni" />
                    <asp:CheckBoxField DataField="Onions" HeaderText="Onions" />
                    <asp:CheckBoxField DataField="GreenPeppers" HeaderText="GreenPeppers" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="PostCode" HeaderText="Post Code" />
                    <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
                    <asp:CheckBoxField DataField="Completed" HeaderText="Completed" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="Gray" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <p>
                &nbsp;</p>
            <br />
        </div>
    </form>
</body>
</html>
