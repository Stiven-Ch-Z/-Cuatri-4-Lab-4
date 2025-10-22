<%@ Page Title="JS Básico" Language="C#" MasterPageFile="~/Views/Shared/Site.master" AutoEventWireup="true" CodeBehind="JSBasico.aspx.cs" Inherits="TallerMecanico.Views.Demo.JSBasico" ClientIDMode="Static" %> 
 
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server"> 
  <div id="demoJS"><%-- Marcador: JS solo corre si existe este div --%> 
 
    <h2>Demostración JS (Conceptos Básicos)</h2> 
 
    <!-- Área de salida sin consola --> 
    <div id="log" style="border:1px solid #e2e8f0;padding:10px;border-radius:8px;margin-bottom:16px;"></div> 
 
    <!-- 1) DOM + eventos: suma --> 
    <h3>Suma rápida</h3> 
    <input id="n1" type="text" placeholder="Número 1" /> 
    <input id="n2" type="text" placeholder="Número 2" /> 
    <button type="button" id="btnSumar" class="btn">Sumar</button> 
    <span id="resultadoSuma"></span> 
 
    <hr /> 
 
    <!-- 2) Arreglos y bucles --> 
    <h3>Arreglo → Lista</h3> 
    <button type="button" id="btnListar" class="btn">Mostrar marcas</button> 
    <ul id="listaMarcas"></ul> 
 
    <hr /> 
 
    <!-- 3) Estado en memoria --> 
    <h3>Contador simple</h3> 
    <button type="button" id="btnContar" class="btn">Contar</button> 
    <span id="lblContador">0</span> 
 
  </div> 
</asp:Content> 