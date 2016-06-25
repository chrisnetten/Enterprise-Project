using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // store session info
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

            // Sign out 
            authenticationManager.SignOut();

            //Redirect to Default page
            Response.Redirect("~/Default.aspx");
        }
    }
}