using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GuestList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BTNSubmit_Click(object sender, EventArgs e)
    {
        string user = WebConfigurationManager.AppSettings["User"].ToString();
        string pass = WebConfigurationManager.AppSettings["pass"].ToString();
        if (user == TBUserName.Text && pass == TBPass.Text)
        {
            Session["login"] = "jessipass123";
            Response.Redirect("GuestListByUser.aspx", true);
        }
   
   
    }
}