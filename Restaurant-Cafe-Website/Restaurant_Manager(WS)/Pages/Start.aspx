<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Start.aspx.cs" Inherits="Pages_Start" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            color: #FF9933;
        }
        .новыйСтиль1 {
            font-family: "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
            color: #FF6666;
        }
        .auto-style2 {
            color: #FFCC66;
        }
        .auto-style3 {
            font-size: x-large;
            color: #CC9900;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <img src="~/Images/main1.jpg" runat="server" class="imgLeft1" />

    <h2 style="font-size: medium">НАШ РЕСТОРАН
</h2>
    <h1 class="auto-style1"><em class="новыйСтиль1">Традиционная итальянская кухня в самом центре Казани.
</em></h1>
    <p>Итальянский ресторан "Sorrento" приглашает вас окунуться в атмосферу Италии, насладиться традиционными блюдами, приготовленными на итальянском оборудовании под руководством шеф-повара, который входит в национальную 20-ку лучших пиццайол из Неаполя. </p>
    <p>У нашего ресторана воистину "теплое сердце" с настоящей каменной печью, которая нагревается до 400 градусов и позволяет приготовить до 8 пицц одновременно за 2-4 минуты.</p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pages/About.aspx" style="color: #000000">Читать дальше ></asp:HyperLink>
        
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <h1 style="font-size: medium">
        Новости</h1>
    <h2 class="auto-style2" style="text-decoration: underline">
        <em>ЛАНЧ-ТАЙМ</em></h2>
    <p>
        <span style="color: rgb(96, 94, 94); font-family: din-next-w01-light, din-next-w02-light, din-next-w10-light, sans-serif; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">Ланч-тайм - с 11:00 до 16:00 скидка 15% на все меню!</span>&nbsp;</p>
    
    <asp:ImageButton ID="ImageButton1" runat="server" Height="505px" ImageUrl="~/Images/main2.jpg" PostBackUrl="~/Index.aspx" Width="743px" />

    <br />
    <br />
    <br />

    <blockquote class="auto-style3">
        <em>«Кто самый лучший повар в Италии? Это бабушки, мамы. Потому что они сохраняют старые традиции итальянской кухни» </em>
    </blockquote>
    <blockquote class="auto-style3">
    </blockquote>
    <blockquote class="auto-style3">
    </blockquote>
    <blockquote class="auto-style3">
    </blockquote>
    <blockquote class="auto-style3">
    </blockquote>
    <blockquote class="auto-style3">
    </blockquote>

    <p style="clear: both"></p>
    

</asp:Content>

