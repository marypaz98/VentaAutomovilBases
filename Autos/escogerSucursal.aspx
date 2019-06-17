<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="escogerSucursal.aspx.cs" Inherits="Autos.escogerSucursal" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div>
            <br />
        </div>
    <p>
        Seleccione la sucursal en la que desea realizar las transacciones:</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="ButtonSucursal1" runat="server" OnClick="ButtonSucursal1_Click1" Text="Sucursal 1" />
        </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="ButtonSucursal2" runat="server" OnClick="ButtonSucursal2_Click1" Text="Sucursal 2" />
        </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="ButtonSucursal3" runat="server" OnClick="ButtonSucursal3_Click1" Text="Sucursal 3" />
        </p>


</asp:Content>
