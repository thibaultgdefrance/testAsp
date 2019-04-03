<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="AspExercice1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="BtnDeconnection" runat="server" Text="se deconnecter" OnClick="BtnDeconnection_Click" />
    <div class="jumbotron">
        <h1>
            <asp:Label ID="LB_Titre" runat="server" Text="Default Page"></asp:Label>

        </h1>
        <asp:HyperLink ID="HPL_Learn" url="" runat="server">Learn more &raquo</asp:HyperLink>
        <asp:TextBox ID="lOGIN" runat="server"></asp:TextBox>
        
    </div>
    
    <asp:DropDownList ID="DDLStart" AutoPostBack="true" OnSelectedIndexChanged="DDLStart_SelectedIndexChanged" runat="server">
        <asp:ListItem Value="2">2</asp:ListItem>
        <asp:ListItem Value="3">3</asp:ListItem>
        <asp:ListItem Value="5">5</asp:ListItem>
        <asp:ListItem Value="8">8</asp:ListItem>

    </asp:DropDownList>
    <asp:Label ID="Lb_NomClient" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="BtnTitre" runat="server" Text="Button" />
    
</asp:Content>
