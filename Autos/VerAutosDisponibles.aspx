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
            <br />
            <br />
            Seleccione el automóvil que desee obtener mayor información:<br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChangin="GridView1_SelectedIndexChangin">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
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
            &nbsp;</p>
    <p>
        &nbsp;</p>
    </form>
    <p id="ButonAceptar">
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
