using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspExercice1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //autre façon de faire

            //try
            //{
            //    if (System.Web.HttpContext.Current.Session["NomClient"].ToString() != null)
            //    {


            //        LB_Titre.Text = "Bienvenue " + (String)Session["NomClient"];

            //    }
               
            //}
            //catch (Exception)
            //{

            //    Response.Redirect("Login.aspx");
            //}
            if (Session["NomClient"]==null)
            {
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                LB_Titre.Text = "Bienvenue " + (String)Session["NomClient"];
            }

            
            LB_Titre.Attributes.Add("date-attribute", "2020");
            LB_Titre.CssClass = "titre";
            HPL_Learn.NavigateUrl = "http://www.youtube.com/";
            HPL_Learn.CssClass = "titre";
            BtnTitre.CssClass = "btn btn-primary";
            BtnTitre.Text = "ok";
            
        }
        string cnx = @"Data Source=STA6018699\SQLEXPRESS; Initial Catalog = vpc; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        protected void DDLStart_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            DropDownList dropDownList = (DropDownList)sender;
            string valeur = dropDownList.SelectedValue;
            SqlConnection connection = new SqlConnection(cnx);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select NomClient,PrenomClient from dbo.Client where IdClient = @IdClient",connection);
            sqlCommand.Parameters.AddWithValue("@IdClient",Int32.Parse(valeur));
            
            SqlDataReader reader= sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                String NomClient = reader["NomClient"].ToString();
                String PrenomClient = reader["PrenomClient"].ToString();
                Lb_NomClient.Text = "Bienvenue " + NomClient + " " + PrenomClient;

            }


            reader.Close();
            connection.Close();
        }

        protected void BtnDeconnection_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("HomePage.aspx");
        }
    }
}