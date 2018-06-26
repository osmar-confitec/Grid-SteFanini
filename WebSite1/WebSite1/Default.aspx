<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register TagPrefix="Acme" TagName="Userx" Src="~/ControlesUsuario/grid.ascx" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <Acme:Userx   id="MyLogisssn" runat="server"/>
    <p><%=clientFormat %></p>
    
</asp:Content>
