using System;
using System.Collections.Generic;
using System.Globalization;
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
    
     
       
       schedule_work_doctor swd = new schedule_work_doctor(Convert.ToInt32(txtswd.Text));

        schedule_work_doctor.update_chenge_note(swd);



    //ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.update_chenge_note(swd) + "');", true);



        Response.Redirect("../page/next_swd.aspx");


        // ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + doc.emp_doc_id + "');", true);

        //     schedule_work_doctor swd = new schedule_work_doctor(DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), Convert.ToInt32(txtroom.Text), doc.emp_doc_id);

        //   ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.update_next_swd(swd) + "');", true);






        //  int s = 1;


        // ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + DropDownList1.SelectedValue.ToString()+ "');", true);
    }
    /*
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

    */

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
     txtswd.Text = row.Cells[1].Text;
    }

    protected void txtdocname_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnselect_Click(object sender, EventArgs e)
    {
        CultureInfo ThaiCulture = new CultureInfo("th-TH");
        DateTime date_t = Convert.ToDateTime(txtdate.Text);
        DateTime today_th = DateTime.Today;
        string today = today_th.ToString("yyyy-MM-dd", new CultureInfo("th-TH"));

        string date_th = date_t.ToString("yyyy-MM-dd", ThaiCulture);
        int day = today_th.Day;
        int day_tt = date_t.Day;
        int plus = day + 2;

        if (plus >= day_tt)
        {


            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ไม่สามารถเลื่อนปฏิบัติงานได้');", true);
        }
        else
        {

            txtswdwork.Text = date_th;
        }
 


    }

    protected void txtswdwork_TextChanged(object sender, EventArgs e)
    {

    }
}