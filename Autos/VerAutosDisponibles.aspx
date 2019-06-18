<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerAutosDisponibles.aspx.cs" Inherits="Autos.VerAutosDisponibles" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div>
            <br />
            <br />
            Seleccione el automóvil que desee obtener mayor información:<br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChangin="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Autos.Properties.Settings.Conexion %>" SelectCommand="verAutosDisponibles" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:Parameter Name="idSucursal" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Ingrese la placa del vehiculo del que desea obtener mayor información:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Width="179px"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" 
ErrorMessage="Este campo es requerido"
ForeColor="Red">
</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Aceptar" />
        </p>
        <p>
            &nbsp;</p>
    <p>
        <asp:Label ID="LabelError" runat="server" ForeColor="Red" Text="Ha ocurrido un problema al intentar la conexion con la base de datos" Visible="False"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
</asp:Content>
