using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_search_app_student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtname_TextChanged(object sender, EventArgs e)
    {
        try
        {

            appointment_swd doc = appointment_swd.show_app(txtname.Text);

            if (doc != null)
            {
                string opd_name = doc.opd_name;
                lblname.Text = opd_name;
                //  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + doc.opd_name + "');", true);
            }





        }
        catch (Exception)
        {

        }
    }
}