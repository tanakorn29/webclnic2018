using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
public partial class patient_appointment_next_doctor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbldoctor.Text = "" + Session["doctor_name"];
        lbldateadd.Text = "" + Session["date"];
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        CultureInfo culture = new CultureInfo("th-TH");
        string date = txtdate.Text;
        string time = DropDownList1.SelectedItem.ToString();
        string name = "" + Session["staff_name"];
        string remark = "" + Session["remark"];
        string name_doc = "" + Session["doctor_name"];
        doctor doc_name = doctor.doc_idshow(name_doc);

        DateTime day = Convert.ToDateTime(date, culture);

        string date_app = day.ToString("yyyy-MM-dd", culture);
        string app_day = day.ToString("dddd", culture);
        double time_zone = Convert.ToDouble(time);
        string date_work = day.ToString("yyyy-MM-dd", culture);

        DateTime today_th = DateTime.Today;
        string today = today_th.ToString("yyyy-MM-dd", new CultureInfo("th-TH"));

        int today_day = today_th.Day;
        int day_select = day.Day;
        if (time_zone <= 12.00)
        {
            if (day_select > today_day)
            {
                if (doc_name != null)
                {
                    int doc_id = doc_name.emp_doc_id;
                    appointment app = new appointment(doc_id, "เช้า", app_day, date_app, time, remark, name, date_work);

                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + appointment.update_app_doctor(app) + "');", true);

                    //  Response.Redirect("../page/appointment.aspx");
                }

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ไม่สามารถเลื่อนนัดได้');", true);
            }




        }
        else if (time_zone >= 12.01)
        {
            if (day_select > today_day)
            {
                if (doc_name != null)
                {
                    int doc_id = doc_name.emp_doc_id;
                    appointment app = new appointment(doc_id, "บ่าย", app_day, date_app, time, remark, name, date_work);

                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + appointment.update_app_doctor(app) + "');", true);

                    //  Response.Redirect("../page/appointment.aspx");
                }

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ไม่สามารถเลื่อนนัดได้');", true);
            }


        }


    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        txtdate.Text = row.Cells[2].Text;
    }
}