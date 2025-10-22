<%@ Page Title="Consultar Autos" Language="C#" MasterPageFile="~/Views/Shared/Site.master" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="TallerMecanico.Views.Autos.Consultar" %> 
 
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server"> 
    <h2>Consultar Autos</h2> <!-- Encabezado --> 
 
    <!-- Campo de filtro por placa --> 
    <asp:Label runat="server" AssociatedControlID="txtFiltro" Text="Filtrar por placa (parcial):" /> 
    <asp:TextBox ID="txtFiltro" runat="server" /> 
 
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" CssClass="btn" /> 
    <asp:Button ID="btnRefrescar" runat="server" Text="Ver todos" OnClick="btnRefrescar_Click" CssClass="btn" /> 
 
    <br /><br /> 
 
    <!-- GridView para mostrar los autos --> 
    <asp:GridView ID="gvAutos" runat="server" AutoGenerateColumns="false"> 
        <Columns> 
            <asp:BoundField DataField="Placa" HeaderText="Placa" /> 
            <asp:BoundField DataField="Marca" HeaderText="Marca" /> 
            <asp:BoundField DataField="Modelo" HeaderText="Modelo" /> 
            <asp:BoundField DataField="NombreDueno" HeaderText="Dueño" /> 
            <asp:BoundField DataField="FechaIngreso" HeaderText="Fecha Ingreso" DataFormatString="{0:yyyy-MM-dd}" /> 
        </Columns> 
    </asp:GridView> 
</asp:Content> 