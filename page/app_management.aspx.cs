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
        Fillapp();
       int count_people = appointment.count_app();
        lblnumber.Text = " " + count_people;
    }
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
    protected void btnapp_Click(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fillapp();
    }
}