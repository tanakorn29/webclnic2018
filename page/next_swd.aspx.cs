using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class next_swd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsummit_Click(object sender, EventArgs e)
    {
        string name = "" + Session["doc_name"];
        //  int s = 1;
        DateTime day = Convert.ToDateTime(txtswdwork.Text);
        string time1 = DropDownList1.SelectedValue.ToString();
        schedule_work_doctor swd1 = schedule_work_doctor.check_room(day, time1);

      if (swd1 != null)
        {
          int room_id = swd1.room_id;
          int status_room = swd1.swd_status_room;
        string time = swd1.swd_start_time;
         doctor doc = doctor.doc_idshow(name);
        if (doc != null)

           {

                //  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + room_id + "');", true);
                schedule_work_doctor swd = new schedule_work_doctor(txtday.Text, txtswdwork.Text, time1, room_id, doc.emp_doc_id);
                if (room_id == 1 || time1 == time)
                {
              

                ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd2(swd) + "');", true);
                 //   Response.Redirect("../Page/index_doctor.aspx");
                    //   ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + room_id + "');", true);


                }
                else
                {
       

               ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd2(swd) + "');", true);
                }
                
                /*
                if (room_id == 1 && status_room == 0)
                {
                    schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, DropDownList3.SelectedValue.ToString(),1, doc.emp_doc_id);

                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);
                }else if (room_id == 2 && status_room == 0)
                {
                    schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, DropDownList3.SelectedValue.ToString(), 2, doc.emp_doc_id);

                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);
                }
                else if (room_id == 3 && status_room == 0)
                {
                    schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, DropDownList3.SelectedValue.ToString(), 3, doc.emp_doc_id);

                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);
                }

    */



         }





       }
    }

    protected void btnselect_Click(object sender, EventArgs e)
    {
        CultureInfo ThaiCulture = new CultureInfo("th-TH");
        DateTime date_t = Convert.ToDateTime(txtdate.Text);
        string date_th = date_t.ToString("yyyy-MM-dd", ThaiCulture);
        txtswdwork.Text = date_th;

        string day = date_t.ToString("dddd", ThaiCulture);
        txtday.Text = day;
    }

    protected void txtswdwork_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtdate_TextChanged(object sender, EventArgs e)
    {

    }
}