using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_patient_appointment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        DateTime date = Convert.ToDateTime(txtdate.Text);
        string time = txttime.Text;
        string name = "" + Session["staff_name"];
        string remark = "" + Session["remark"];
        appointment app = new appointment(date, time, remark, name);
        appointment.update_app_doctor(app);
        Response.Redirect("../page/appointment.aspx");
    }
}