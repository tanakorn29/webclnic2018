﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_appointment_nurse : System.Web.UI.Page
{
    private void status_approve()
    {



        string name = "" + Session["staff_name"];

        int status_app = 1;
        appointment app = appointment.show_app(status_app, name);
        if (app != null)
        {
            CultureInfo culture = new CultureInfo("en-US");
            DateTime date_app = Convert.ToDateTime(app.date_app, culture);
            string app_date = String.Format("{0:yyyy-MM-dd}", date_app, culture);
            string date_th = date_app.ToString("yyyy-MM-dd", culture);
            lbldate.Text = "" + date_th;

            Session["date"] = date_th;
            lbltime.Text = app.app_time;
            lblremark.Text = app.app_remark;
            Session["remark"] = app.app_remark;
            lbldoctor.Text = app.doc_name;
            Session["doctor_name"] = app.doc_name;

            int status_app1 = app.status_app;
            if (app.status_approve == 2)
            {
                lblstatus.Text = "นัดหมายการรักษาปกติ";
                Session["status1"] = "นัดหมายการรักษาปกติ";

            }
            else if (app.status_approve == 3)
            {

                lblstatus.Text = "แพทย์ขอเลื่อนนัด";
                Session["status1"] = "แพทย์ขอเลื่อนนัด";








            }
            else if (app.status_approve == 4)
            {
                lblstatus.Text = "รออนุมัติการนัดหมาย";
                Session["status1"] = "รออนุมัติการนัดหมาย";
            }
            else if (app.status_approve == 5)
            {
                lblstatus.Text = "อนุมัติการเลื่อนนัดหมาย";
                Session["status1"] = "อนุมัติการเลื่อนนัดหมาย";
            }
            else if (app.status_approve == 6)
            {
                lblstatus.Text = "แพทย์ขอเลื่อนนัดด่วน";
                Session["status1"] = "แพทย์ขอเลื่อนนัดด่วน";
            }


        }








    }
    protected void Page_Load(object sender, EventArgs e)
    {
        status_approve();
    }

    protected void btnapp_Click(object sender, EventArgs e)
    {
        string status_approve = "" + Session["status1"];
        if (status_approve == "นัดหมายการรักษาปกติ")
        {
            Response.Redirect("../page/nurse_appointment_next.aspx");
        }
        else if (status_approve == "แพทย์ขอเลื่อนนัด")
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('รอข้อมูลนัดหมายจากพยาบาล');", true);
            //  Response.Redirect("../page/next_app.aspx");
            //  string opd = "" + Session["staff_name"];
            //   appointment update = new appointment(opd);

            //     System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //     sb.Append("<script src='http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js'></script>");
            //       sb.Append("<script type = 'text/javascript'>");

            //       sb.Append("if (!confirm('ยืนยันการเลื่อนนัดหมายจากแพทย์ ?')){");

            //    string update1 = appointment.update_status(update);

            //    sb.Append(update1);
            /*     sb.Append("$.ajax({");
                 sb.Append("    type: 'POST',");
                 sb.Append("   url: 'appointment.aspx / GetData',");
                 sb.Append("       contentType: 'application / json; charset = utf - 8',");
                 sb.Append("      dataType: 'json',");
                 sb.Append("      success: function (response) {");
                 sb.Append("      var names = response.d;");
                 sb.Append("    alert(names);");
                 sb.Append("      },");
                 sb.Append("     failure: function (response) {");
                 sb.Append("       alert(response.d);");
                 sb.Append("        }");
                 sb.Append("          });");*/
            //       ScriptManager.RegisterStartupScript(this, this.GetType(), "updatejson", "updatejson();", true);
            //    sb.Append("}else{ ");

            //        sb.Append("window.location.assign('../page/patient_appointment_next.aspx') }");
            //        sb.Append("</script>");

            //        ClientScript.RegisterClientScriptBlock(this.GetType(), "showPopup", sb.ToString());



            //    ScriptManager.RegisterStartupScript(this, this.GetType(), "showPopup", "if (!confirm('ยืนยันการเลื่อนนัดหมายจากแพทย์ ?')){ alert('ยกเลิกการนัดหมาย')  }else{  window.location.assign('../page/patient_appointment_next.aspx')}", true);
            //   ScriptManager.RegisterStartupScript(this, this.GetType(), "CallConfirmBox", "CallConfirmBox();", true);
            // Response.Redirect("../page/patient_appointment_next.aspx");



        }
        else if (status_approve == "รออนุมัติการนัดหมาย")
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('รอการอนุมัติจากแพทย์');", true);
        }
        else if (status_approve == "อนุมัติการเลื่อนนัดหมาย")
        {
            Response.Redirect("../page/next_app_nurse.aspx");
        }
        else if (status_approve == "แพทย์ขอเลื่อนนัดด่วน")
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('รอข้อมูลการนัดหมายจากพยาบาล');", true);
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ยังไม่มีการนัดหมาย');", true);
        }

    }

    protected void btnhistory_Click(object sender, EventArgs e)
    {
        Response.Redirect("../page/appointment_history_nurse.aspx");
    }
}