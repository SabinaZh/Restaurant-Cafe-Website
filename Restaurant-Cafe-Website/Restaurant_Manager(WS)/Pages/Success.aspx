<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Success.aspx.cs" Inherits="Pages_Success" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-size: small;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        <asp:Button ID="Button1" runat="server" Text="ОПЛАТИТЬ" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <strong><em>Thank you!</em></strong></p>
    <span class="auto-style1">Платеж прошел успешно!</span><br class="auto-style1" />
    <br class="auto-style1" />
    <span class="auto-style1">Приятного аппетита!</span>
</asp:Content>

