<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityEntry.aspx.cs" Inherits="CountryCityWebApp.UI.CityEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>City Entry</title>
    <link href="StyleCityEntry.css" rel="stylesheet" />
    
    <style type="text/css">
        .Entry {
            height: 1076px;
        }
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            text-decoration: underline;
            color: #CC0000;
        }
        .auto-style3 {
            height: 65px;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div class="Entry">
        <h1 class="auto-style2"><em>City Entry.</em></h1>
        <table>
            <tr>
                <td class="auto-style1"><span class="auto-style1">Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="nameCityTextBox" runat="server" Width="168px" CssClass="auto-style1" ToolTip="Enter City Name" Font-Names="Cambria"></asp:TextBox></td>
            </tr>
            <br/>
            <tr>
                <td><span class="auto-style1">About&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="aboutCityTextBox" runat="server" TextMode="MultiLine" style="margin-top: 0px" CssClass="auto-style1" ToolTip="Enater about City" Font-Names="Cambria"></asp:TextBox></td>
            </tr>
            <tr>
                <td><span class="auto-style1">No of Dwellers&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; </span> <asp:TextBox ID="dwellerTextBox" runat="server" TextMode="SingleLine" Width="170px" CssClass="auto-style1" ToolTip="Enter number of Dwellers" Font-Names="Cambria"></asp:TextBox></td>
            </tr>
            <tr>
                <td><span class="auto-style1">Location&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</span><asp:TextBox ID="locationTextBox" runat="server" Width="168px" CssClass="auto-style1" ToolTip="Enter Location" Font-Names="Cambria"></asp:TextBox></td>
            </tr>
            <tr>
                <td><span class="auto-style1">Weather&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="weatherTextBox" runat="server" TextMode="MultiLine" CssClass="auto-style1" ToolTip="Enter weather of City" Font-Names="Cambria"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="auto-style1">Country&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:DropDownList ID="CountryDropDownList" runat="server" CssClass="auto-style1" ToolTip="Select a country" Font-Names="Cambria"></asp:DropDownList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" CssClass="auto-style1" ToolTip="Click to Save" Font-Names="Cambria" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp<asp:Button ID="cancelButton" runat="server" Text="Cancel" CssClass="auto-style1" ToolTip="Click to Cacel" Font-Names="Cambria" /></td>
            </tr>
            <tr>
                <td>&nbsp;<asp:Label ID="showLabel" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:GridView ID="GridView3" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="Groove" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource1" style="text-align: center" ToolTip="Showing all Cities." Font-Names="Cambria">
            <Columns>
                <asp:BoundField DataField="Serial" HeaderText="Serial" SortExpression="Serial" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="DwelerNo" HeaderText="No. of Dwellers" SortExpression="DwelerNo" />
                <asp:BoundField DataField="CountryName" HeaderText="Country" SortExpression="CountryName" />
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
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="CityCountryList" TypeName="CountryCityWebApp.DAL.Gateway.Citygateway"></asp:ObjectDataSource>
        <br />
    </div>
    </form>
</body>
</html>
