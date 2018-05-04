using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_next_worksxhedule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //  txtroom.Text = "" + Session["doc_name"];
        txtdocname.Text = "" + Session["doc_name"]; 
    }
    /*
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string name = "" + Session["doc_name"];
        //  int s = 1;
        doctor doc = doctor.doc_idshow(name);
        if (doc != null)
        {
            schedule_work_doctor swd = new schedule_work_doctor(DropDownList2.SelectedIndex.ToString(), DropDownList3.SelectedIndex.ToString(), Convert.ToInt32(DropDownList1.SelectedIndex.ToString()), doc.emp_doc_id);

            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);
        }
    }
    */
    protected void btnsummit_Click(object sender, EventArgs e)
    {
        string name = "" + Session["doc_name"];
        //  int s = 1;
        doctor doc = doctor.doc_idshow(name);
        if (doc != null)
        {
            schedule_work_doctor swd = new schedule_work_doctor(txtday.Text, txttime.Text, Convert.ToInt32(txtroom.Text), doc.emp_doc_id);

            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.update_next_swd(swd) + "');", true);
        }
    }

    protected void ddlroom_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtroom.Text = ddlroom.SelectedItem.ToString();
    }

    protected void ddlday_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtday.Text = ddlday.SelectedItem.ToString();
    }



    protected void ddltime_SelectedIndexChanged(object sender, EventArgs e)
    {
        txttime.Text = ddltime.SelectedItem.ToString();
    }
}