using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page5 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["staff_name"] != null)
        {
            lblLogin.Text = "" + Session["staff_name"];

        }
    }

    protected void lblLogin_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("../page/login_opd.aspx");
    }
}
