<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="profileView.aspx.cs" Inherits="WebApplication1.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server">
    
    </asp:Label>
    <table border="1px solid black">
        <tr>
            <td><asp:Image ID="pbxImage" runat="server" Height="150px" Width="250px" /></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnLike" runat="server" Text="Like" width="100%" 
                    BackColor="#66FFFF" Font-Names="Century" ForeColor="Black" 
                    onclick="btnLike_Click"/></td>
        </tr>
    </table>
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
                <asp:Label ID="lblMusicGenres" runat="server">
                </asp:Label>
            </td>
        </tr>
        <tr>
            <td>Style de livre</td>
            <td>
                <asp:Label ID="lblBookGenres" runat="server">
                </asp:Label>
            </td>
        </tr>
        <tr>
            <td>Type de film</td>
            <td>
                <asp:Label ID="lblMovieGenres" runat="server">
                </asp:Label>
            </td>
        </tr>
        <tr>
            <td>Marque </td>
            <td>
                <asp:Label ID="lblBrand" runat="server">
                </asp:Label>
            </td>
        </tr>
        <tr>
            <td>Loisir</td>
            <td>
                <asp:Label ID="lblHobbies" runat="server">
                </asp:Label>
            </td>
        </tr>
        <tr>
            <td>Sports</td>
            <td>
                <asp:Label Id="lblSports" runat="server">
                </asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>