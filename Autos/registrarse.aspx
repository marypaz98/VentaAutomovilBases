<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="registrarse.aspx.cs" Inherits="Autos.registrarse" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <br />
            <br />
            Ingrese su nombre:<br />
            <asp:TextBox ID="TextBoxNombre" runat="server" Width="264px"></asp:TextBox>
                <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxNombre" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
            <br />
            <br />
            Ingrese su primer apellido:<br />
            <asp:TextBox ID="TextBoxApellido1" runat="server" Width="259px"></asp:TextBox>
                <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxApellido1" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
            <br />
            <br />
            Ingrese su segundo apellido:<br />
            <asp:TextBox ID="TextBoxApellido2" runat="server" Width="256px"></asp:TextBox>
                <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxApellido2" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
            <br />
            <br />
            Ingrese su edad:<br />
            <asp:TextBox ID="TextBoxEdad" runat="server" Width="253px"></asp:TextBox>
                <asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxEdad" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
            <br />
            <br />
            Ingrese su cedula:<br />
            <asp:TextBox ID="TextBoxCedula" runat="server" Width="254px"></asp:TextBox>
                <asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxCedula" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
            <br />
            <br />
            Ingrese su nombre de usuario:<br />
            <asp:TextBox ID="TextBoxUsuario" runat="server" Width="253px"></asp:TextBox>
                <asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxUsuario" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
            <br />
            <br />
            Ingrese su contraseña:<br />
            <asp:TextBox ID="TextBoxContrasenna" runat="server" Width="248px"></asp:TextBox>
                <asp:RequiredFieldValidator id="RequiredFieldValidator7" runat="server" ControlToValidate="TextBoxContrasenna" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
            <br />
            <br />
            Ingrese las latitudes de su ubicación:<br />
            <asp:TextBox ID="TextBoxUbicacion" runat="server" Width="253px"></asp:TextBox>
                <asp:RequiredFieldValidator id="RequiredFieldValidator8" runat="server" ControlToValidate="TextBoxUbicacion" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="ButtonRegistrarse" runat="server" OnClick="ButtonRegistrarse_Click" Text="Registrarse" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
        </div>

</asp:Content>