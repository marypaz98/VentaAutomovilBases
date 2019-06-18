<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="facturador.aspx.cs" Inherits="Autos.facturador" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="38px" OnClick="Button1_Click" Text="Vender carro" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Height="40px" OnClick="Button2_Click" Text="Facturar" Width="125px" />
        </div>
</asp:Content>
