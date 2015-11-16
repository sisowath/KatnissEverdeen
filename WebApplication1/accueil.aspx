<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="accueil.aspx.cs" Inherits="WebApplication1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server">
    
    </asp:Label>
    <h1>Bienvenue sur Katniss Everdeen !</h1>
    <asp:PlaceHolder ID="leaderboard" runat="server">
    
    </asp:PlaceHolder>
</asp:Content>
