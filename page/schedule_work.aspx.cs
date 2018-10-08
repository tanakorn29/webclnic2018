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
        lbliddoc.Text = "" + Session["doc_id"];
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        lblswdid.Text = row.Cells[1].Text;
        lbldoctorre.Text = row.Cells[5].Text;

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            string name = "" + Session["doc_name"];

            int id_swd_work_doctor = Convert.ToInt32(lblswdid.Text);
            doctor doc = doctor.doc_idshow(name);
            if (doc != null)
            {
                schedule_work_doctor swd = new schedule_work_doctor(id_swd_work_doctor);
                ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.update_chenge_note_work(swd) + "');", true);
                Response.Redirect("../Page/index_doctor.aspx");
            }
        }
        catch (Exception)
        {

        }

    }

    protected void btncencel_Click(object sender, EventArgs e)
    {
        try
        {

            int id_swd_work_doctor = Convert.ToInt32(lblswdid.Text);
            doctor doc_id = doctor.doc_idshow(lbldoctorre.Text);
            if (doc_id != null)
            {
                schedule_work_doctor swd_cencel = new schedule_work_doctor(doc_id.emp_doc_id, id_swd_work_doctor,doc_id.emp_doc_id);
           //   schedule_work_doctor swd_doc_cencel = new schedule_work_doctor(doc_id.emp_doc_id);
             //  schedule_work_doctor.centel_chenge_swd_doc_work(swd_doc_cencel);
              //  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.centel_chenge_swd_doc_work(swd_cencel) + "');", true);
                ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.centel_chenge_note_work(swd_cencel) + "');", true);
            }
        }
        catch (Exception)
        {

        }


    }


}