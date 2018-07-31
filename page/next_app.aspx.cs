using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_next_app : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbldate.Text = ""+Session["date"];
    }

    protected void btnnext_Click(object sender, EventArgs e)
    {
        string name = "" + Session["staff_name"];

        string remark = "" + Session["remark"];
        appointment app = new appointment(remark,name);
        appointment.confirm_app(app);
        Response.Redirect("../page/appointment.aspx");

    }
    /*
    protected void btncancel_Click(object sender, EventArgs e)
    {
        string name = "" + Session["staff_name"];

        string remark = "" + Session["remark"];
        appointment app = new appointment(remark, name);
        string cencel = appointment.update_status(app);
      //  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('"+cencel+"');", true);
        Response.Redirect("../page/appointment.aspx");
        
    
    }
    */


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("../page/patient_appointment_next_doctor.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        string doctor_name = Convert.ToString(Session["doctor_name"]);
        //    DateTime date = Convert.ToDateTime(txtdate.Text);
        //  string time = txttime.Text;

      appointment_mg app = new appointment_mg(doctor_name);
        appointment_mg.cancel_app1(app);
        ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('"+ doctor_name + "');", true);
    }

    
}