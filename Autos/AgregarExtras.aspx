<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarExtras.aspx.cs" Inherits="Autos.AgregarExtras" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <br />
            <br />
            Ingrese las extras que desea obtener, en caso de no querer extras seleccione el botón sin extras:<br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Extra1: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="221px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Extra 2: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="212px"></asp:TextBox>
            <br />
            <br />
            Extra 3:
            <asp:TextBox ID="TextBox3" runat="server" Width="214px"></asp:TextBox>
            <br />
            <br />
            Extra 4:
            <asp:TextBox ID="TextBox4" runat="server" Width="216px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar extras" />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="#FF3300" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 25" Text="Sin extras" />
        </div>

 </asp:Content>
