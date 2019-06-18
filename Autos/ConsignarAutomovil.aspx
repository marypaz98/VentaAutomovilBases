<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsignarAutomovil.aspx.cs" Inherits="Autos.ConsignarAutomovil" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <br />
            Ingrese el id del tipo de automovil:<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="249px"></asp:TextBox>
            <br />
            <br />
            Ingrese el id del tipo de combustible:<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="246px"></asp:TextBox>
            <br />
            <br />
            Ingrese la placa del automovil:<br />
            <asp:TextBox ID="TextBox3" runat="server" Width="244px"></asp:TextBox>
            <br />
            <br />
            Ingrese el precio base del automovil:<br />
            <asp:TextBox ID="TextBox4" runat="server" Width="239px"></asp:TextBox>
            <br />
            <br />
            Ingrese el año del automovil:<br />
            <asp:TextBox ID="TextBox5" runat="server" Width="241px"></asp:TextBox>
            <br />
            <br />
            Ingrese el color del automovil:<br />
            <asp:TextBox ID="TextBox6" runat="server" Width="243px"></asp:TextBox>
            <br />
            <br />
            Ingrese la marca del automovil:<br />
            <asp:TextBox ID="TextBox7" runat="server" Width="241px"></asp:TextBox>
            <br />
            <br />
            Ingrese la cantidad de pasajeros:<br />
            <asp:TextBox ID="TextBox8" runat="server" Width="242px"></asp:TextBox>
            <br />
            <br />
            Ingrese el número de puertas:<br />
            <asp:TextBox ID="TextBox9" runat="server" Width="235px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consignar" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
</asp:Content>
