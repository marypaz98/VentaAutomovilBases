<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComprarCarro.aspx.cs" Inherits="Autos.ComprarCarro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 142px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
            Escoja el tipo pago que desea realizar:</div>
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" DataSourceID="SqlDataSource1" DataTextField="tipo" DataValueField="tipo">
            <asp:ListItem>Efectivo</asp:ListItem>
            <asp:ListItem>Tarjeta</asp:ListItem>
            <asp:ListItem Selected="True">Cheque</asp:ListItem>
        </asp:ListBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Sucursal_1ConnectionString %>" SelectCommand="SELECT [tipo] FROM [TipoPago]"></asp:SqlDataSource>
        <br />
        <br />
        Escoja el tipo de financiamiento que desea realizar:<br />
        <br />
        <asp:ListBox ID="ListBox2" runat="server" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged">
            <asp:ListItem Selected="True">Sin financiamiento</asp:ListItem>
            <asp:ListItem>Con financiamiento</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Ingrese el plazo en meses del financiamiento:" Visible="False"></asp:Label>
        <br />
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Visible="False" Width="197px"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
        </p>
        <asp:Button ID="ButtonComprar" runat="server" Text="Comprar" OnClick="ButtonComprar_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Ha ocurrido un error, verifique que los datos ingresados sean correctos" Visible="False"></asp:Label>
    </form>
</body>
</html>
