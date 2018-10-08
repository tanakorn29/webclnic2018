using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_index_doctor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime today = DateTime.Today;
      int id = Convert.ToInt32(Session["doc_id"]);
 
        int day = today.Day;
        if(day >= 17 && day < 20)
        {

            schedule_work_doctor2 month = schedule_work_doctor2.show_swd_doc();
            if(month != null)
            {
                string swd_month = month.swd_month_work;
                string check = schedule_work_doctor2.check_register_swd(swd_month,id);
                if(check == "1")
                {
                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('คุณยังไม่ลงเวลาปฏิบัติงาน');", true);
                }
                
              
            }


        }
    }
}