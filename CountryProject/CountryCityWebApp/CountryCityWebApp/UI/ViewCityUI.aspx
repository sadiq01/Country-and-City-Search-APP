<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCityUI.aspx.cs" Inherits="CountryCityWebApp.UI.ViewCityUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleViewCity.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-decoration: underline;
            color: #660066;
        }
        .auto-style2 {
            color: #660066;
        }
    </style>
</head>
<body style="height: 682px">
    <form id="form1" runat="server">
    <div>
    
        &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;<span class="auto-style2"> </span> <span class="auto-style1"><strong><em>View Cities</em></strong></span><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="cityNameRadioButton" runat="server" Text="City Name" style="font-size: large" ToolTip="Select to search by City Name" Font-Names="Cambria" />
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="citySearchTextBox" runat="server" Width="165px" ToolTip="Enter city name for partial search" Font-Names="Cambria" style="font-size: large"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="countryRadioButton" runat="server" Text="Country" style="font-size: large" ToolTip="Select to search by country" Font-Names="Cambria" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="countryDropDownList" runat="server" ToolTip="Select a country to search" Font-Names="Cambria" style="font-size: large">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" ToolTip="Click to search" Font-Names="Cambria" style="font-size: large" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;<asp:GridView ID="showCityGridView" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" style="text-align: center; font-size: large;" ToolTip="View All cities" AllowPaging="True" OnPageIndexChanging="gridView_PageIndexChanging" Font-Names="Cambria">
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
        
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
