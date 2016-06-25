using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Project.Models;
using System.Web.ModelBinding;


namespace Project
{
    public partial class Default : System.Web.UI.Page
    {
    
            protected void Page_Load(object sender, EventArgs e)
            {
                // If first time loading page, populate the student grid
                if (!IsPostBack)
                {
                    //Get the Basketball Data
                    this.GetBasketball();
                    this.GetHockey();
                    this.GetSoccer();
                }
            }
            /**
            *<summary>
            *Method gets basketball data from db
            *</summary>
            *
            */


            protected void GetBasketball()
            {
                // connect to ef
                using (DefaultConnection db = new DefaultConnection())
                {
                    // Query basketball table using ef and linq
                    var Basketball = (from allBasketball in db.Basketballs
                                      select allBasketball);

                    //bind the results to the GridView
                    BasketballGridView.DataSource = Basketball.ToList();
                    BasketballGridView.DataBind();
                }
            }

            protected void GetHockey()
            {
                // connect to ef
                using (DefaultConnection db = new DefaultConnection())
                {
                    // Query basketball table using ef and linq
                    var Hockey = (from allHockey in db.Hockeys
                                  select allHockey);

                    //bind the results to the GridView
                    HockeyGridView.DataSource = Hockey.ToList();
                    HockeyGridView.DataBind();
                }
            }

            protected void GetSoccer()
            {
                // connect to ef
                using (DefaultConnection db = new DefaultConnection())
                {
                    // Query basketball table using ef and linq
                    var Soccer = (from allSoccer in db.Soccers
                                  select allSoccer);

                    //bind the results to the GridView
                    SoccerGridView.DataSource = Soccer.ToList();
                    SoccerGridView.DataBind();
                }
            }


        protected void GetPaintball()
        {
            // connect to ef
            using (DefaultConnection db = new DefaultConnection())
            {
                // Query basketball table using ef and linq
                var Paintball = (from allPaintball in db.Paintballs
                              select allPaintball);

                //bind the results to the GridView
                PaintballGridView.DataSource = Paintball.ToList();
                PaintballGridView.DataBind();
            }
        }







  
       



    }
}