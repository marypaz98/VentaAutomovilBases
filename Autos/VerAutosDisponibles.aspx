<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerAutosDisponibles.aspx.cs" Inherits="Autos.VerAutosDisponibles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="placa" HeaderText="placa" SortExpression="placa" />
                <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
                <asp:BoundField DataField="año" HeaderText="año" SortExpression="año" />
                <asp:BoundField DataField="color" HeaderText="color" SortExpression="color" />
                <asp:BoundField DataField="marca" HeaderText="marca" SortExpression="marca" />
                <asp:BoundField DataField="cantidadPasajeros" HeaderText="cantidadPasajeros" SortExpression="cantidadPasajeros" />
                <asp:BoundField DataField="nPuertas" HeaderText="nPuertas" SortExpression="nPuertas" />
                <asp:BoundField DataField="tipo" HeaderText="tipo" SortExpression="tipo" />
                <asp:BoundField DataField="combustible" HeaderText="combustible" SortExpression="combustible" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Autos.Properties.Settings.Conexion %>" SelectCommand="verAutosDisponibles" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:Parameter Name="idSucursal" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Ingrese la placa del automovil del que desea obtener mayor información:"></asp:Label>
        </p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" Width="300px"></asp:TextBox>
        <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
        </p>
    </form>
    <p id="ButonAceptar">
        <input id="Aceptar" type="button" value="Aceptar" onclick="ButtonAceptar_Click"/></p>
    <p>
        &nbsp;</p>
</body>
</html>
