using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_appointment_doctor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string name = "" + Session["doctor_name"];
        DataTable dt = new DataTable();


        dt = appointment.show_app_doctor(name);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}