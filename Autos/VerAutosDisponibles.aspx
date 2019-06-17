<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerAutosDisponibles.aspx.cs" Inherits="Autos.VerAutosDisponibles" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

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
</asp:Content>
