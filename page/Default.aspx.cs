using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

       

        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        sb.Append("<script type = 'text/javascript'>");

        sb.Append("if (!confirm('ยืนยันการเลื่อนนัดหมายจากแพทย์ ?')){");

   

        sb.Append("alert('ยกเลิกการนัดหมาย') ");
        sb.Append("}else{ ");

        sb.Append("alert('นัดหมาย') }");
        sb.Append("</script>");

        ClientScript.RegisterClientScriptBlock(this.GetType(), "showPopup", sb.ToString());
    }

    protected void Submit(object sender, EventArgs e)
    {
        string confirmValue = Request.Form["confirm_value"];
        if (confirmValue == "Yes")
        {
            Response.Redirect("~/AddData.aspx");
        }
        else
        {
            Response.Redirect("~/ViewData.aspx");
        }
    }
}