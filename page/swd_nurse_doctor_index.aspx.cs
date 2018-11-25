using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class swd_nurse_doctor_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtname_TextChanged(object sender, EventArgs e)
    {
        try
        {

            schedule_work_doctor1 doc = schedule_work_doctor1.show_swd_doc(txtname.Text);

            if (doc != null)
            {
                string opd_name = doc.emp_doc_name;
                lblname.Text = opd_name;
                //  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + doc.opd_name + "');", true);
            }





        }
        catch (Exception)
        {

        }

    }
}