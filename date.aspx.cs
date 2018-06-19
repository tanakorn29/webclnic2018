using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class date : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DateTime day = Convert.ToDateTime(TextBox1.Text);
        string app_day = String.Format("{0:dddd}", day);
        ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('"+app_day+"');", true);
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        Label1.Text = "" + TextBox2.Text;
    }
}