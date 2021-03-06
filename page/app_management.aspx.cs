﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_app_management : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //  Fillapp();
         int count_people = appointment.count_app();
        lblnumber.Text = " " + count_people;
        GridView1.Visible = true;
    
       // txtdate.Enabled = true;
      //  txttime.Enabled = true;
    }
    /*
    private void Fillapp()
    {
        ArrayList app = new ArrayList();

        if (!IsPostBack)
        {
            app = appointment.sent_app_nurse();
        }
        else
        {
            app = appointment.sent_app_doctor(Convert.ToInt32(DropDownList1.SelectedValue));
        }
        StringBuilder sb = new StringBuilder();

        foreach (appointment app1 in app)
        {
            sb.Append(String.Format(@"

            <table class='wearableTable'>
  <tr class='active'>
   <td class='active' style='width: 230px'>
      วันนัดหมาย</td>
        <td class='active' style='width: 342px'>
          
 {0}
          
      </td>
        
  </tr>
                 <tr class='active'>
   <td class='active' style='width: 230px'>
         เวลานัดหมาย</td>
        <td class='active' style='width: 342px'>
          
 {1}
          
      </td>
        
  </tr>
              <tr class='active'>
      <td class='active' style='width: 230px'>
         หมายเหตุ</td>
        <td class='active' style='width: 342px'>
            
     {2}
            
      </td>
        
  </tr>
                <tr class='active'>
      <td class='active' style='width: 230px'>
         ชื่อคนไข้</td>
        <td class='active' style='width: 342px'>
            
           {3}
            
      </td>
        
  </tr>
           <tr class='active'>
      <td class='active' style='width: 230px'>
        แพทย์ผู้ทำการรักษา</td>
        <td class='active' style='width: 342px'>
            
             {4}
            
      </td>
        
  </tr>
            </table>

            ", app1.app_date,app1.app_time,app1.app_remark,app1.opd_name,app1.doc_name));

        }
       lbloutput.Text = sb.ToString();
    }

    */
    protected void btnapp_Click(object sender, EventArgs e)
    {
        try
        {
            int id_num = Convert.ToInt16(txtnum.Text);
            string opdname = txtopd.Text;
            appointment status = appointment.check_status(opdname);
            if (status != null)
            {
                int status_app = status.status_approve;
                if(status_app == 3)
                {
                  appointment_ms app = new appointment_ms(id_num);

                  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + appointment_ms.update_app_opd_ms(app) + "');", true);
                }
                else if(status_app == 6)
                {
                    Session["opd_name_app"] = txtopd.Text;
                    Session["doctor_app"] = txtdoctor.Text;
                    Session["remark_app"] = txtremark.Text;
                    Response.Redirect("../page/app_management_now.aspx");
                }
          
            }

    

        }
        catch (Exception)
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ไม่มีข้อมูลการนัดหมาย');", true);
        }

    //    int num = Convert.ToInt16(Session["app_ID"]);
  
        //  string ID = Convert.ToString(Session["ID"]);
        /*      int num = Convert.ToInt16(Session["app_ID"]);

              if (num != 4)
              {
                  int app_id = Convert.ToInt16(txtnum.Text);
                  System.Globalization.CultureInfo _cultureTHInfo = new System.Globalization.CultureInfo("th-TH");

                  System.Globalization.CultureInfo thday = new System.Globalization.CultureInfo("th-TH");

                  //  DateTime date = Convert.ToDateTime(txtdate.Text);
                  string date = txtdate.Text;
                //  DateTime date = DateTime.ParseExact(txtdate.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                  string time = txttime.Text;
                  //  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + date + "');", true);
                  string doc_name = txtdoctor.Text;
                  doctor doc_name1 = doctor.doc_idshow(doc_name);
                  double time_zone = Convert.ToDouble(time);
                  DateTime day = Convert.ToDateTime(date);
                  string app_day = txtday.Text;
                  string date_app_pp = day.ToString("yyyy-MM-dd");


                  DateTime today_th = DateTime.Today;
                  string today = today_th.ToString("yyyy-MM-dd", new CultureInfo("th-TH"));

                  int today_day = today_th.Day;
                  int day_select = day.Day;


                  if (time_zone <= 12.00)
                  {
                      if (day_select > today_day)
                      {
                          if (doc_name1 != null)
                          {

                              //   ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + date_app_pp + "  ,  "+ app_day + "');", true);
                              int doc_id = doc_name1.emp_doc_id;
                              appointment app = new appointment(app_id, doc_id, "เช้า", app_day, date_app_pp, time, date_app_pp);

                              ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + appointment.update_app_opd(app) + "');", true);
                          }
                      }else
                      {
                          ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ไม่สามารถเลื่อนนัดได้');", true);
                      }



                  }
                  else if (time_zone >= 12.01)
                  {
                      if (day_select > today_day)
                      {
                          if (doc_name1 != null)
                          {

                              //    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + date_app_pp + "  ,  " + app_day + "');", true);
                              int doc_id = doc_name1.emp_doc_id;
                              appointment app = new appointment(app_id, doc_id, "บ่าย", app_day, date_app_pp, time, date_app_pp);

                              ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + appointment.update_app_opd(app) + "');", true);
                          }


                      }else
                      {
                          ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ไม่สามารถเลื่อนนัดได้');", true);
                      }

                  }

              }*/
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Fillapp();
        /*
        int num = Convert.ToInt32(DropDownList1.SelectedValue);
        if(num == 3)
        {
            Session["app_ID"] = num;
            txtdate.Enabled = true;
            txttime.Enabled = true;
        }else
        {
            txtdate.Enabled = false;
            txtdate.TextMode = TextBoxMode.SingleLine;
            txttime.Enabled = false;
        }

  
        */
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        txtnum.Text = row.Cells[1].Text;
     txtday.Text = row.Cells[2].Text;
        txtremark.Text = row.Cells[4].Text;
        txtdoctor.Text = row.Cells[5].Text;
        txtopd.Text = row.Cells[6].Text;
     

    }
/*
    protected void Button1_Click(object sender, EventArgs e)
    {
       
           Session["id_app"] = txtnum.Text;
            int app_id = Convert.ToInt16(txtnum.Text);
        //    DateTime date = Convert.ToDateTime(txtdate.Text);
          //  string time = txttime.Text;

            appointment_mg app = new appointment_mg(app_id);
            appointment_mg.cancel_app(app);
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ยกเลิกเรียบร้อยแล้ว');", true);
        
    }
*/
    protected void btndate_Click(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView2.SelectedRow;
        System.Globalization.CultureInfo _cultureTHInfo = new System.Globalization.CultureInfo("en-US");
        DateTime date = Convert.ToDateTime(row.Cells[1].Text);
        string d = date.ToString("yyyy-MM-dd");
        txtdate.Text = row.Cells[1].Text;
        txttime.Text = row.Cells[3].Text;
        txtday.Text = row.Cells[2].Text;
    }
}