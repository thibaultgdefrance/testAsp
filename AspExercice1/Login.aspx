<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <webopt:bundlereference runat="server" path="~/Content/site.css" />
</head>
<body id="body">
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label ID="TestSession" runat="server" Text="Label"  CssClass="TestSession"></asp:Label>
            <div class=" login">
                    <div>
                        <asp:Image ID="Image1" runat="server" ImageURL="media/iconeProfil.png" CssClass="PhotoProfil  "/>
                    </div>
                    <div class="">
                        <asp:Label ID="LbLogin" runat="server" Text="Veillez vous identifier" CssClass="connexionTitre"></asp:Label>
                    </div>
                    <div>
                        <asp:TextBox ID="TxbLogin" runat="server" OnTextChanged="TxbLogin_TextChanged" CssClass="connexion"></asp:TextBox>


                    </div>
                    <div>
                        <asp:TextBox ID="TxbPassword" runat="server" OnTextChanged="TxbPassword_TextChanged" CssClass="connexion"></asp:TextBox>


                    </div>
                    <div>

                        <asp:Button ID="BtnLogin" runat="server" Text="Button" OnClick="BtnLogin_Click" CssClass="connexion "/>

                    </div>
                    
                    
                  

                    
            </div>
                    
                    
            
            
            
        </div>
    </form>
</body>
</html>
