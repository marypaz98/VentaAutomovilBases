<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="venderCarro.aspx.cs" Inherits="Autos.venderCarro" %>

  <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <br />
        <div>
            Ingrese el id del cliente:<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="248px"></asp:TextBox>
            <br />
            <br />
            Ingrese el id de la sucursal:<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="246px"></asp:TextBox>
            <br />
            <br />
            Ingrese el id del automovil:<br />
            <asp:TextBox ID="TextBox3" runat="server" Width="246px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Vender" />
        </div>
</asp:Content>
