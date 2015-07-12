<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCountryUI.aspx.cs" Inherits="CountryCityWebApp.UI.ViewCountryUI" ValidateRequest="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
    <link href="Style%20View%20Country.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-decoration: underline;
            color: #800000;
        }
        .auto-style2 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 817px">
    
        &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><span class="auto-style1"><em> View Country</em></span></strong><br />
&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style2">Name</span>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="searchTextBox" runat="server" Font-Names="Cambria" style="font-size: large" ToolTip="Enter country to partial search"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="searchButton" runat="server" OnClick="searchButton_Click" Text="Search" Font-Names="Cambria" style="font-size: large" ToolTip="click to search" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource1" style="text-align: center" Font-Names="Cambria" ToolTip="Showing Countries with City" Width="903px">
            <Columns>
                <asp:BoundField DataField="Serial" HeaderText="Serial" SortExpression="Serial" />
                <asp:BoundField DataField="CountryName" HeaderText="Name" SortExpression="CountryName" />
                <asp:BoundField DataField="CountryAbout" HeaderText="About" SortExpression="CountryAbout" HtmlEncode="False" />
                <asp:BoundField DataField="City_Number" HeaderText="Number of City" SortExpression="City_Number" />
                <asp:BoundField DataField="Dweller_Number" HeaderText="No of city Dwellers" SortExpression="Dweller_Number" />
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ViewCountryListSearch" TypeName="CountryCityWebApp.DAL.Gateway.CountryGateway">
            <SelectParameters>
                <asp:ControlParameter ControlID="searchTextBox" DefaultValue="" Name="countryName" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
    
    </div>
    </form>
</body>
</html>
