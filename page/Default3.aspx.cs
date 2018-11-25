using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime d1 = Convert.ToDateTime(Label1.Text);
        DateTime Today = DateTime.Now;

        if(d1.Date >= Today.Date)
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ทดสอบ');", true);
        }
    }
}