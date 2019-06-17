<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OpcionesCliente.aspx.cs" Inherits="Autos.OpcionesCliente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <br />
            <br />
            <asp:Button ID="ButtonAutosDisponibles" runat="server" OnClick="ButtonAutosDisponibles_Click1" Text="Ver autos disponibles" />
            <br />
            <br />
            <br />
            <br />
        </div>
        <p>
            <asp:Button ID="ButtonConsultar" runat="server" OnClick="ButtonConsultar_Click" Text="Consultar modelo" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="ButtonConsignar" runat="server" OnClick="ButtonConsignar_Click" Text="Consignar automovil" />
        </p>
        <p>
            &nbsp;</p>

</asp:Content>
