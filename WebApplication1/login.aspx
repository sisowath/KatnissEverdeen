<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%
        if (Session["isConnected"] != null)
            Response.Redirect("accueil.aspx");        
     %>
     <asp:Label ID="lblMessage" runat="server">
     
     </asp:Label>
    <h1>Authentification</h1>
    <h3>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server" 
            ErrorMessage="Vous avez oublié de saisir votre nom d'utilisateur" 
            ControlToValidate="txtUsername" Display="Dynamic" ForeColor="#FF9933"></asp:RequiredFieldValidator>
    
    </h3>
    <h3>
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" 
            ErrorMessage="Vous avez oublié de saisir votre mot de passe." 
            ControlToValidate="txtPassword" Display="Dynamic" ForeColor="#FF9933"></asp:RequiredFieldValidator>
    </h3>
    <table border="1px solid black">
        <tr>
            <td>Nom d'utilisateur : </td>            
            <td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>            
        </tr>
        <tr>
            <td>Mot de passe : </td>
            <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2"><asp:Button ID="btnMeConnecter" Text="Me Connecter" runat="server" 
                    width="100%" onclick="btnMeConnecter_Click" /></td>            
        </tr>
    </table>
</asp:Content>