using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class schedule_work : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbldoctor.Text = "" + Session["doc_name"];
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        lblswdid.Text = row.Cells[1].Text;
       
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string name = "" + Session["doc_name"];
 
        int id_swd_work_doctor = Convert.ToInt32(lblswdid.Text);
        doctor doc = doctor.doc_idshow(name);
        if(doc != null)
        {
           schedule_work_doctor swd = new schedule_work_doctor(id_swd_work_doctor);
           ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.update_chenge_note_work(swd)+ "');", true);
        }
    }
}