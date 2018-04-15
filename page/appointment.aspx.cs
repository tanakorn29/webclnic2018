using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_appointment : System.Web.UI.Page
{
    private void status_approve()
    {
   


            string name = "" + Session["staff_name"];
 
            int status_app = 1;
            appointment app = appointment.show_app(status_app, name);
            if (app != null)
            {
                lbldate.Text = Convert.ToString(app.app_date);
                lbltime.Text = app.app_time;
                lbldoctor.Text = app.doc_name;
                
                if (app.status_approve == 1)
                {
                    lblstatus.Text = "นัดหมายการรักษาปกติ";
                    Session["status1"] = "นัดหมายการรักษาปกติ";

                }
                else if (app.status_approve == 2)
                {
                    lblstatus.Text = "แพทย์ขอเลื่อนนัด";
                    Session["status1"] = "แพทย์ขอเลื่อนนัด";
                } else if (app.status_approve == 3)
            {
                lblstatus.Text = "รออนุมัติการนัดหมาย";
                Session["status1"] = "รออนุมัติการนัดหมาย";
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
        if(status_approve == "นัดหมายการรักษาปกติ")
        {
            Response.Redirect("../page/patient_appointment_next.aspx");
        }else if (status_approve == "แพทย์ขอเลื่อนนัด")
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "showPopup", "if (!confirm('ยืนยันการเลื่อนนัดหมายจากแพทย์ ?')){ alert('ยกเลิกการนัดหมาย')  }else{  window.location.assign('../page/patient_appointment_next.aspx')}", true);

            // Response.Redirect("../page/patient_appointment_next.aspx");
        }else if(status_approve == "รอแพทย์อนุมัติการนัดหมาย")
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('รอการอนุมัติจากแพทย์');", true);
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ยังไม่มีการนัดหมาย');", true);
        }
         
     
        
    }

    protected void btnhistory_Click(object sender, EventArgs e)
    {
        Response.Redirect("../page/appointment_history.aspx");
    }
}