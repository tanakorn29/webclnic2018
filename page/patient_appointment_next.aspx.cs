using System;
using System.Collections.Generic;
using System.Globalization;
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

        //   DateTime date = DateTime.ParseExact(txtdate.Text, "MM/yy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
        CultureInfo culture = new CultureInfo("th-TH");
        //  DateTime date = Convert.ToDateTime(txtdate.Text);
        //    DateTime day = Convert.ToDateTime(time1.ToString("yyyy-MM-dd"));
        //   ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('"+ date + "');", true);
        //  DateTime date_month_year = Convert.ToDateTime(date.ToString("yyyy-MM-dd"));
        string date = txtdate.Text;
        string time = txttime.Text;
        string name = "" + Session["staff_name"];
        string remark = "" + Session["remark"];
        appointment app = new appointment(date, time, remark, name);
        appointment.update_app_doctor(app);
        Response.Redirect("../page/appointment.aspx");
    
    }
}