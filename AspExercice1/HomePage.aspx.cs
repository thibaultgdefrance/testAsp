using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace AspExercice1
{
    public partial class HomePage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnTitre_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void BtnConnection_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
