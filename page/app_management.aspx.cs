using System;
using System.Collections;
using System.Collections.Generic;
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
      //  string ID = Convert.ToString(Session["ID"]);
        int num = Convert.ToInt16(Session["app_ID"]);

        if (num == 2)
        {
            int app_id = Convert.ToInt16(txtnum.Text);
            DateTime date = Convert.ToDateTime(txtdate.Text);
            string time = txttime.Text;

            appointment app = new appointment(app_id, date, time);
            appointment.update_app_opd(app);
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('แจ้งคนไข้เรียบร้อยแล้ว');", true);
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Fillapp();
        int num = Convert.ToInt32(DropDownList1.SelectedValue);
        if(num == 2)
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
        GridView1.Visible = true;

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        txtnum.Text = row.Cells[1].Text;
        txtdate.Text=  row.Cells[2].Text;
        txttime.Text = row.Cells[3].Text;
        txtremark.Text = row.Cells[4].Text;
        txtdoctor.Text = row.Cells[5].Text;
        txtopd.Text = row.Cells[6].Text;
     

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int num = Convert.ToInt16(Session["app_ID"]);

        if (num == 2)
        {
            int app_id = Convert.ToInt16(txtnum.Text);
        //    DateTime date = Convert.ToDateTime(txtdate.Text);
          //  string time = txttime.Text;

            appointment_mg app = new appointment_mg(app_id);
            appointment_mg.cancel_app(app);
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ยกเลิกเรียบร้อยแล้ว');", true);
        }
    }
}