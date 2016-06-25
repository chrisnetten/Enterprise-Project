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
    public partial class HockeyDetails : System.Web.UI.Page
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
                Hockey newHockey = new Hockey();
                int anInteger, anInteger2, anInteger3, anInteger4;
                anInteger = Convert.ToInt32(ScoreOneTextBox.Text);
                anInteger2 = Convert.ToInt32(ScoreTwoTextBox.Text);
                anInteger3 = Convert.ToInt32(AsistsOneTextBox.Text);
                anInteger4 = Convert.ToInt32(AsistsTwoTextBox.Text);

                newHockey.teamName1 = TeamOneTextBox.Text;
                newHockey.teamName2 = TeamTwoTextBox.Text;
                newHockey.score1 = anInteger;
                newHockey.score2 = anInteger2;
                newHockey.asists1 = anInteger3;
                newHockey.asists2 = anInteger4;

                //Linq to ADO.Net
                db.Hockeys.Add(newHockey);

                // save changes
                db.SaveChanges();

                //Redirect 
                Response.Redirect("~/Default.aspx");

            }
        }


    }
}