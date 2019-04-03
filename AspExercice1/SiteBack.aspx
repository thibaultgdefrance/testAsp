<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/SiteBack.Master" AutoEventWireup="true" CodeFile="SiteBack.aspx.cs" CodeBehind="SiteBack.aspx.cs" Inherits="AspExercice1.SiteBack" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
    <div class="jumbotron">
        <h1>
            <asp:Label ID="LB_Titre" runat="server" Text="Admin"></asp:Label>

        </h1>
        <asp:HyperLink ID="HPL_Learn" url="" runat="server">Learn more &raquo</asp:HyperLink>
        <asp:TextBox ID="lOGIN" runat="server"></asp:TextBox>
        
    </div>
    
    
    <asp:Label ID="Lb_NomClient" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="BtnTitre" runat="server" Text="Button" />
    
</asp:Content>
