<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarExtras.aspx.cs" Inherits="Autos.AgregarExtras" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <br />
            <br />
            Seleccione las extras que desea obtener, en caso de no querer extras seleccione el botón sin extras:<br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="nombre" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
            </asp:CheckBoxList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Autos.Properties.Settings.Conexion %>" SelectCommand="SELECT [nombre], [precio] FROM [Extra]"></asp:SqlDataSource>
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
