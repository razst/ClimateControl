using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Cloud.Firestore;


namespace climate_IO
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //<button runat="server" onServerClick ="Button2_Click" >
        //Response.Redirect("HistoryPage.aspx");


        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HistoryPage.aspx");
        }


    }
}