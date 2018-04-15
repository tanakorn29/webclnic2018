using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        String Username = txtusername.Text;

        String Password = txtpassword.Text;

        employee_ru ru = employee_ru.Login_employee_ru(Username, Password);

     doctor doc = doctor.Login_doctor(Username, Password);

        if (ru != null)
        {
            string user = ru.username;
            employee_ru show_name = employee_ru.show_employees(user);

     if(show_name != null)
            {
                if (show_name.status == "อนุญาติ")
                {
                    Session["staff_name"] = show_name.emp_ru_name;
                    if (show_name.pos_name == "เจ้าหน้าที่")
                    {
                        Response.Redirect("../Page/index_opd.aspx");
                    }
                    else if (show_name.pos_name == "เวชระเบียน")
                    {
                        Response.Redirect("../Page/index_opd.aspx");
                    }
                    else if (show_name.pos_name == "พยาบาล")
                    {
                        Response.Redirect("../Page/nurse_index_opd.aspx");
                    }
                    else if (show_name.pos_name == "เภสัชกรณ์")
                    {
                        Response.Redirect("../Page/index_opd.aspx");
                    }
                    else
                    {
                        Response.Redirect("../Page/index_student.aspx");
                    }
                }
                else
                {
                    Session["staff_name"] = show_name.emp_ru_name;
                    if (show_name.pos_name == "พยาบาล")
                    {
                        Response.Redirect("../Page/appointment_management_index.aspx");
                    }else
                    {
                        ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ไม่ถูกยืนยันสิทธิการรักษา');", true);
                    }
               
                }


            }






        }
        else if (doc != null)
        {
            Session["doc_name"] = doc.emp_doc_name;
            Response.Redirect("../Page/index_doctor.aspx");
        }
        
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ไม่พบข้อมูลในระบบ');", true);
        }
    }
}