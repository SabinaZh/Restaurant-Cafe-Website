<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p style="clear: both">
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Name">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RestaurantDBConnectionString %>" SelectCommand="SELECT ProductType.Name FROM Products INNER JOIN ProductType ON Products.TypeId = ProductType.Id UNION SELECT 'Все' AS Expr1"></asp:SqlDataSource>
    <asp:Panel ID="pnlProducts" runat="server">
        <br />
         
    </asp:Panel>
    </p>
    <p style="clear: both"></p>
     
</asp:Content>

