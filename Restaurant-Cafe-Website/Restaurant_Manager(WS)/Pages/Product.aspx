<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Pages_Product" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage"/></td>
            <td class="auto-style2"><h2>
                <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
                 <hr />
                </h2> </td>
        </tr>

         <tr>
            <td class="auto-style1">
                <asp:Label ID="lblDescription" runat="server" CssClass="detailsDescription"></asp:Label></td>
            <td>
                <asp:Label ID="lblPrice" runat="server" CssClass="detailsPrice"></asp:Label>
                <br />
                <br />
             Количество :
             <asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList>
                <br />
                <asp:Button ID="btnAdd" runat="server" CssClass="button" OnClick="btnAdd_Click" Text="В корзину" /><br />
             <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
             </td><br />

             
        </tr>

         <tr>
            <td class="auto-style1"> <asp:Label ID="lblItemNr" runat="server" Text="Label" Visible="False"></asp:Label></td>
            
        </tr>

         <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="В наличии" CssClass="productPrice"></asp:Label></td>
            
        </tr>


    </table>

</asp:Content>

