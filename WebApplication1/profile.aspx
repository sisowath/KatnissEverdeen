<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="WebApplication1.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <% 
        if (Session["isConnected"] == null)
            Response.Redirect("login.aspx");
    %>
    <table border="1px soldi black">
        <tr>
            <th colspan="2">Mon profile</th>
        </tr>
        <tr>
            <td>ID : </td>
            <td><asp:TextBox ID="txtId" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Nom d'utilisateur : </td>
            <td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Mot de passe : </td>
            <td><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Adresse courriel : </td>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>    
        </tr>
        <tr>
            <td>Nombre de Likes : </td>
            <td><asp:TextBox ID="txtNumberOfLikes" runat="server"></asp:TextBox></td>    
        </tr>
    </table>
    <table border="1px solid black">
        <tr>
            <th colspan="2">Mes champs d'intérêts</th>
        </tr>
        <tr>
            <td>Style de musique</td>
            <td>
                <asp:PlaceHolder ID="musicGenres" runat="server">
                
                </asp:PlaceHolder>
            </td>
        </tr>
        <tr>
            <td>Style de livre</td>
            <td>
                <asp:PlaceHolder ID="bookGenres" runat="server">
                
                </asp:PlaceHolder>
            </td>
        </tr>
        <tr>
            <td>Type de film</td>
            <td>
                <asp:PlaceHolder ID="movieGenres" runat="server">
                
                </asp:PlaceHolder>
            </td>
        </tr>
        <tr>
            <td>Marque </td>
            <td>
                <asp:PlaceHolder ID="brands" runat="server">
                
                </asp:PlaceHolder>
            </td>
        </tr>
        <tr>
            <td>Loisir</td>
            <td>
                <asp:PlaceHolder ID="hobbies" runat="server">
                
                </asp:PlaceHolder>
            </td>
        </tr>
        <tr>
            <td>Sports</td>
            <td>
                <asp:PlaceHolder ID="sports" runat="server">
                
                </asp:PlaceHolder>
            </td>
        </tr>
    </table>
</asp:Content>