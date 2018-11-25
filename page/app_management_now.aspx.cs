using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_app_management_now : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblopdname.Text =""+ Session["opd_name_app"];
        lbldoctor.Text = "" + Session["doctor_app"];
        doctor doc_s = doctor.check_spec_name(lbldoctor.Text);
        if(doc_s != null)
        {
            string name = doc_s.emp_doc_specialist;
            lblspc.Text = name;
        }

    
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        txtday.Text = row.Cells[1].Text;
        txtdate.Text = row.Cells[2].Text;
        txttimeapp.Text = row.Cells[3].Text;
    }

    protected void btnapp_Click(object sender, EventArgs e)
    {

    }


    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            CultureInfo culture = new CultureInfo("th-TH");
            string date = txtdate.Text;
            string time = txttimeapp.Text;
            string name = "" + Session["opd_name_app"];
            string remark = "" + Session["remark_app"];
            string name_doc = "" + Session["doctor_app"];
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
                        schedule_work_doctor ss = schedule_work_doctor.check_swdid_doctor(name_doc , date_app);
                        if(ss != null)
                        {
                            int swd_id_app = ss.swd_id;
                                appointment app = new appointment(doc_id, "เช้า", app_day, date_app, time, remark, name, date_work);

                                  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + appointment.update_app_doctor(app) + "');", true);

                        Response.Redirect("../page/appointment_management_index.aspx");
                        }else
                        {
                         //   ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('"+name_doc+"     "+date_app+"');", true);
                        }

                     //   ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + name_doc + "     " + date_app + "');", true);
                    }else
                    {
                      //  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ไม่อ่าน');", true);
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

                        schedule_work_doctor ss = schedule_work_doctor.check_swdid_doctor(name_doc, date_app);
                        if (ss != null)
                        {
                            int swd_id_app = ss.swd_id;
                              appointment app = new appointment(doc_id, "บ่าย", app_day, date_app, time, remark, name, date_work);

                            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + appointment.update_app_doctor(app) + "');", true);
                           Response.Redirect("../page/appointment_management_index.aspx");
                        }
                        else
                        {
                            //ClientScript.RegisterStartupScript(GetType(), "hwa", "alert(' " + name + "  +   " + date_app + "');", true);
                        }
    
                    }

                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ไม่สามารถเลื่อนนัดได้');", true);
                }


            }
        }
        catch (Exception)
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ไม่สามารถเลื่อนนัดได้');", true);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            string name = "" + Session["opd_name_app"];

            string remark = "" + Session["remark_app"];
            appointment app = appointment.show_app_next_opd(name);
            if (app != null)
            {
                DateTime date = app.date_app;
                string date_app = date.ToString("yyyy-MM-dd");
                int emp_doc_id = app.emp_doc_id;

                string time = app.app_time;
                double time_app = Convert.ToDouble(time);

                appointment_swd app1 = appointment_swd.show_swd_app_doctor_id(date_app, time);
                if (app1 != null)
                {
                    int id = app1.emp_doc_id;
                    appointment_swd app3 = new appointment_swd(id, remark, name);
                    appointment_swd.confirm_app(app3);
                    Response.Redirect("../page/appointment_management_index.aspx");

                }
               

            }
       


        }
        catch (Exception)
        {

        }


        /*  appointment app = appointment.show_app_next_opd(name);
          if (app != null)
          {
              DateTime date = app.date_app;
              string date_app = date.ToString("yyyy-MM-dd");
              int emp_doc_id = app.emp_doc_id;

              string time = app.app_time;
              double time_app = Convert.ToDouble(time);

              //   ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + time_app + "');", true);
              appointment_swd app1 = appointment_swd.show_swd_app_doctor_id(date_app, time);
              if (app1 != null)
              {
                  int id = app1.emp_doc_id;

                  appointment_swd app3 = new appointment_swd(id, remark, name);
                  appointment_swd.confirm_app(app3);
                  Response.Redirect("../page/appointment.aspx");

                  //       ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + id + "');", true);
              }

          }*/
    }
}