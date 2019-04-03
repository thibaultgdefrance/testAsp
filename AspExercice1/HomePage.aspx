<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="AspExercice1.HomePage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <h1>
            <asp:Label ID="LB_Titre" runat="server" Text="Accueil"></asp:Label>

        </h1>
        <asp:HyperLink ID="HPL_Learn" url="" runat="server">Learn more &raquo</asp:HyperLink>
        <asp:TextBox ID="lOGIN" runat="server"></asp:TextBox>
        
    </div>
    
    <asp:Label ID="Lb_NomClient" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="BtnConnection" runat="server" OnClick="BtnConnection_Click" Text="Connection" />
    
</asp:Content>
