﻿using System;
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
        lbldoctor.Text = ""+Session["doctor_name"];
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
        string time = DropDownList1.SelectedItem.ToString();
        string name = "" + Session["staff_name"];
        string remark = "" + Session["remark"];
        string name_doc = "" + Session["doctor_name"];
        doctor doc_name = doctor.doc_idshow(name_doc);

        DateTime day = Convert.ToDateTime(date , culture);
   
        string date_app = day.ToString("yyyy-MM-dd", culture);
        string app_day = day.ToString("dddd", culture);
        double time_zone = Convert.ToDouble(time);
        string date_work = day.ToString("yyyy-MM-dd", culture);
        if (time_zone <= 12.00)
        {

            if (doc_name != null)
            {
                int doc_id = doc_name.emp_doc_id;
                appointment app = new appointment(doc_id, "เช้า", app_day, date_app, time, remark, name, date_work);
                
                ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + appointment.update_app_doctor(app) + "');", true);

                //  Response.Redirect("../page/appointment.aspx");
            }



        }
        else if (time_zone >= 12.01)
        {
            if (doc_name != null)
            {
                
                int doc_id = doc_name.emp_doc_id;
                appointment app = new appointment(doc_id, "บ่าย", app_day, date_app, time, remark, name, date_work);
                ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + appointment.update_app_doctor(app) + "');", true);

                //  Response.Redirect("../page/appointment.aspx");
            }


        }
          


 
    
    }

    protected void btnapp_Click(object sender, EventArgs e)
    {
        CultureInfo ThaiCulture = new CultureInfo("th-TH");
        DateTime date_t = Convert.ToDateTime(txtdate.Text);
        string date_th = date_t.ToString("yyyy-MM-dd", ThaiCulture);
    lbldate.Text= date_th;

        string day = date_t.ToString("dddd", ThaiCulture);
   
    }
}