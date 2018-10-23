<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="Pages_ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="pnlShoppingCart" runat="server">
        <span style="color: rgb(96, 94, 94); font-family: din-next-w01-light, din-next-w02-light, din-next-w10-light, sans-serif; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;"><span class="Apple-converted-space">&nbsp;</span></span></asp:Panel>

    <table>
         <tr>
            <td><b>Дата </b></td>
            <td>
                <br />
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Date" ></asp:TextBox>
             </td>
        </tr>
         <tr>
            <td><b>Время <em>(введите время в формате 00:00 )</em></b></td>
            <td>
                <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
             </td>
        </tr>

         <tr>
            <td><b>Адрес <em>( или номер стола ) </em>: </b></td>
            <td>
                <asp:TextBox ID="txtAdress" runat="server"></asp:TextBox>
             </td>
        </tr>

         <tr>
            <td><b>Телефон: </b></td>
            <td>
                <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
             </td>
        </tr>

        <tr>
            <td><b>Стоимость: </b></td>
            <td><asp:Literal ID="litTotal" runat="server" Text="" /></td>
        </tr>

        <tr>
            <td><b>Доставка: </b></td>
            <td>0 ₽</td>
        </tr>

        <tr>
            <td><b>Итого: </b></td>
            <td><asp:Literal ID="litTotalAmount" runat="server" Text="" /></td>
        </tr>

        <tr>
            <td>
                <asp:LinkButton ID="lnkContinue" runat="server" PostBackUrl="~/Index.aspx"
                    Text="Continue shopping" />
                OR
                  <asp:Button ID="btnCheckOut" runat="server"
                    CssClass="button" Width="250" Text="Check out" OnClick="btnCheckOut_Click" />
                <br />
                <br />
                
                <br />
                <br />
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </td>

        </tr>

    </table>

    

</asp:Content>

