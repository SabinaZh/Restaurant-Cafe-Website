<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Account_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        <asp:Literal ID="litStatus" runat="server"></asp:Literal>
        &nbsp;</p>
    <p>
        Логин:&nbsp;</p>
    <p>
        <asp:TextBox ID="txtUserName" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
    Пароль:<br />
    <br />
    <asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    Подтвердите пароль:<br />
    <br />
    <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    Имя:<br />
    <br />
        <asp:TextBox ID="txtFirstName" runat="server" CssClass="inputs"></asp:TextBox>
    <br />
    <br />
    Фамилия:<br />
    <br />
    <br />
        <asp:TextBox ID="txtLastName" runat="server" CssClass="inputs"></asp:TextBox>
    <br />
    <br />
    Адрес:<br />
    <br />
        <asp:TextBox ID="txtAddress" runat="server" CssClass="inputs"></asp:TextBox>
    <br />
    Почтовый индекс<br />
    <br />
        <asp:TextBox ID="txtPostalCode" runat="server" CssClass="inputs"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Button" />
</asp:Content>

