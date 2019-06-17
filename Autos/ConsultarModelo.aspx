<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultarModelo.aspx.cs" Inherits="Autos.ConsultarModelo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <br />
            <br />
            <br />
            Ingrese la marca del automovil a consultar:<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="260px"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
            <br />
            <br />
            Ingrese el año del automovil a consultar:<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="260px"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar" />
        </div>

</asp:Content>
