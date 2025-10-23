<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="TallerMecanico.Views.Autos.Eliminar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" 
runat="server"> 
    <!-- Contenido que se inyecta en el placeholder de la Master --> 
 
    <h2>Eliminar Auto</h2> <!-- Encabezado de la vista --> 
 
    <!-- Campos de entrada para registrar un auto --> 
     <asp:Label ID="lblPlaca" runat="server" Text="Placa:" AssociatedControlID="txtPlaca" />
     <asp:TextBox ID="txtPlaca" runat="server" />
     <br /><br />
     <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
     <br /><br />
     <asp:Label ID="lblMensaje" runat="server" /> 
    <!-- Etiqueta para mostrar mensajes de éxito o error --> 
</asp:Content>
