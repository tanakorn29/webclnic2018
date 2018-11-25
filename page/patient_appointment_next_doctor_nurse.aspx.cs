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

        string doc_name = Convert.ToString(Session["doctor_name"]);
        doctor doc_ru = doctor.doc_specialist(doc_name);
        if(doc_ru != null)
        {
            int spc_id = doc_ru.emp_doc_spec_id;
            doctor spc_name = doctor.doc_specialist_id(spc_id);
            if(spc_name != null)
            {
                lblspc.Text = spc_name.emp_doc_specialist;
            }
        }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        CultureInfo culture = new CultureInfo("th-TH");
        string date = txtdate.Text;
        string time = txttimeapp.Text;
        string name = "" + Session["staff_name"];
        string remark = "" + Session["remark"];
        string name_doc = "" + Session["doctor_name"];
        doctor doc_name = doctor.doc_idshow(name_doc);

        DateTime day = Convert.ToDateTime(date, culture);

        string date_app = day.ToString("yyyy-MM-dd", culture);
        string app_day = txtday.Text;
        double time_zone = Convert.ToDouble(time);
        string date_work = day.ToString("yyyy-MM-dd", culture);

        DateTime today_th = DateTime.Today;
        string today = today_th.ToString("yyyy-MM-dd", new CultureInfo("th-TH"));

        int today_day = today_th.Day;
        int day_select = day.Day;
        if (time_zone <= 12.00)
        {
            if (day.Date >= today_th.Date)
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
            if (day.Date >= today_th.Date)
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
        txtday.Text = row.Cells[1].Text;
        txtdate.Text = row.Cells[2].Text;
        txttimeapp.Text = row.Cells[3].Text;
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string doc_name = DropDownList2.SelectedItem.ToString();
        doctor id_show = doctor.doc_idshow(doc_name);
        CultureInfo culture = new CultureInfo("th-TH");
        string date = txtdate.Text;
        string time = txttimeapp.Text;
        string name = "" + Session["staff_name"];
        string remark = "" + Session["remark"];
        string name_doc = "" + Session["doctor_name"];

        if (id_show != null)
        {
            int doc_id = id_show.emp_doc_id;
            appointment app = new appointment(doc_id,remark, name);
            lbldoctor.Text = doc_name;
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + appointment.update_app_doctor_name(app) + "');", true);
        }
    }
}