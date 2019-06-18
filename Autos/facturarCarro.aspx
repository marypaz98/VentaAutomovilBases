<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="facturarCarro.aspx.cs" Inherits="Autos.facturarCarro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <br />
        <div>
            Ingrese el id del cliente:<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="273px"></asp:TextBox>
            <br />
            <br />
            Ingrese el id de la sucursal:<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="271px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Facturar" />
        </div>
 </asp:Content>
