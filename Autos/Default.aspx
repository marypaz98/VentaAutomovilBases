<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Autos.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <br />
    <span style="color: #FFFFFF; font-size: xx-large">
    <asp:Label ID="Label1" runat="server" style="font-size: xx-large; color: #000000" Text="Ingrese su usuario y contraseña:" Font-Names="Arial" Font-Size="XX-Large"></asp:Label>
    <br />
    </span>
    <br />
    &nbsp;
<table style="width: 55%; border: 1px solid #808080">
    <tr>
        <td style="width: 175px; color: #000000;">Usuario:</td>
        <td style="width: 198px">
            <asp:TextBox ID="TextUsuario" runat="server" Width="201px" OnTextChanged="TextUsuario_TextChanged"></asp:TextBox>
        </td>
        <td style="width: 598px">
        <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="TextUsuario" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
        </td>
    </tr>
    </table>
    <br />
    &nbsp;&nbsp;&nbsp;
<table style="width: 55%; border: 1px solid #808080">
    <tr>
        <td style="width: 175px; color: #000000;">Contraseña:</td>
        <td style="width: 198px">
            <asp:TextBox ID="TextContrasenna" runat="server" Width="201px"></asp:TextBox>
        </td>
        <td style="width: 598px">
        <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="TextUsuario" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
        </td>
    </tr>
    </table>
    <br />
    <br />
<br />
<asp:Button ID="ButtonAceptar" runat="server" Text="Aceptar" OnClick="ButtonAceptar_Click" />
<br />
<br />
<asp:Label ID="LabelError" runat="server" ForeColor="Red" Text="Usuario incorrecto" Visible="False"></asp:Label>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />



</asp:Content>