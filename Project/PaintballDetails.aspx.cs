using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// using statements required for EF DB access
using Project.Models;
using System.Web.ModelBinding;

namespace Project
{
    public partial class PaintballDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // EF to connect to server
            using (DefaultConnection db = new DefaultConnection())
            {
                // Basketball Model to create new Basketball object 
                Paintball newPaintball = new Paintball();
                int  anInteger3, anInteger4;
                anInteger3 = Convert.ToInt32(AsistsOneTextBox.Text);
                anInteger4 = Convert.ToInt32(AsistsTwoTextBox.Text);

                newPaintball.teamName1 = TeamOneTextBox.Text;
                newPaintball.teamName2 = TeamTwoTextBox.Text;
                newPaintball.asists1 = anInteger3;
                newPaintball.asists2 = anInteger4;

                //Linq to ADO.Net
                db.Paintballs.Add(newPaintball);

                // save changes
                db.SaveChanges();

                //Redirect 
                Response.Redirect("~/Default.aspx");

            }
        }


    }
}