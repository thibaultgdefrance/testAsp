using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["NomClient"] != null)
        {
            TestSession.Text = (String)Session["NomClient"];
        }
        else
        {
           TestSession.Text = "ok";
        }
    }

    public void verifLogin()
    {
        String Login = TxbLogin.Text;
        String Password = TxbPassword.Text;
        try
        {
            SqlConnection cnx = new SqlConnection(@"Data Source=STA6018699\SQLEXPRESS;Initial Catalog=vpc;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            cnx.Open();
            SqlCommand cmdLogin = new SqlCommand("Select count(IdClient)  From Client where PrenomClient=@PrenomClient AND Password=@Password",cnx);

            cmdLogin.Parameters.AddWithValue("@PrenomClient", Login);
            cmdLogin.Parameters.AddWithValue("@Password", Password);
            
            if (cmdLogin.ExecuteScalar().ToString() != "0")
            {
                Session["NomClient"]=TxbLogin.Text;
                LbLogin.Text = "Bienvenue";
                Response.Redirect("Default.aspx");
                Session["NomClient"] = TxbLogin.Text; ;
                Session["Password"] = TxbPassword.Text;
            }
            else
            {
                LbLogin.Text = "veillez entrer un login et un mot de passe correcte";
            }

            cnx.Close();
        }
        catch (Exception ex)
        {
            throw;
            
        }
            
        
    }


    protected void TxbLogin_TextChanged(object sender, EventArgs e)
    {
        verifLogin();

    }

    protected void TxbPassword_TextChanged(object sender, EventArgs e)
    {
        verifLogin();
    }

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        verifLogin();
    }
}