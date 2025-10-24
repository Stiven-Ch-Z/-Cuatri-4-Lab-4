<%@ Page Title="Registrar Auto" Language="C#" MasterPageFile="~/Views/Shared/Site.master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="TallerMecanico.Views.Autos.Registrar" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Contenido que se inyecta en el placeholder de la Master -->

    <h2>Registrar Auto</h2>
    <!-- Encabezado de la vista -->

    <!-- Campos de entrada para registrar un auto -->
    <asp:Label runat="server" AssociatedControlID="txtPlaca" Text="Placa:" />
    <asp:TextBox ID="txtPlaca" runat="server" />

    <asp:Label runat="server" AssociatedControlID="txtMarca" Text="Marca:" />
    <asp:TextBox ID="txtMarca" runat="server" />

    <asp:Label runat="server" AssociatedControlID="txtModelo" Text="Modelo:" />
    <asp:TextBox ID="txtModelo" runat="server" />

    <asp:Label runat="server" AssociatedControlID="txtDueno" Text="Nombre del dueño:" />
    <asp:TextBox ID="txtDueno" runat="server" />

    <asp:Label runat="server" AssociatedControlID="txtFecha" Text="Fecha ingreso (yyyy-mm-dd):" />
    <asp:TextBox ID="txtFecha" runat="server" />

    <asp:Label runat="server" AssociatedControlID="txtTrabajo" Text="Trabajo a realizar: " />
    <asp:TextBox ID="txtTrabajo" runat="server" />

    <br />
    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" CssClass="btn" />
    <!-- Botón que ejecuta la acción de registro -->

    <br />
    <br />
    <asp:Label ID="lblMensaje" runat="server" />
    <!-- Etiqueta para mostrar mensajes de éxito o error -->
</asp:Content>
