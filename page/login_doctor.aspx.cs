using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_login_doctor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        String Username = txtusername.Text;

        String Password = txtpassword.Text;

        doctor doc = doctor.Login_doctor(Username, Password);

        if (doc != null)
        {
            Session["doctor_name"] = doc.emp_fname;
            Response.Redirect("ddd");
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('รหัสผิดพลาด');", true);
        }

    }
}