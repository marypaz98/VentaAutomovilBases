<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PagarMensualidad.aspx.cs" Inherits="Autos.PagarMensualidad" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
        </div>


        <br />
        <br />
        Ingrese la placla del carro al que desea pagar la mensualidad:<br />
        <asp:TextBox ID="TextBox2" runat="server" Width="244px"></asp:TextBox>
    <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Ingrese el monto a pagar"></asp:Label>
        :<br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="228px"></asp:TextBox>
    <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="LabelError" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonPagar" runat="server" OnClick="ButtonPagar_Click" Text="Pagar" />


</asp:Content>
