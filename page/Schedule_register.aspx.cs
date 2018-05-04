using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_Schedule_register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
        Queue<int> collection = new Queue<int>();
        collection.Enqueue(1);
        collection.Enqueue(2);
        collection.Enqueue(3);*/
     //   collection.Dequeue();
    //    collection.Dequeue();
       /* foreach (int value in collection)
        {
     //       txtroom.Text = Convert.ToString(value);
        }*/
        // Response.Write("Hello world");
        btnsubmit.Visible = false;
    }

    protected void txtroom_TextChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        txtroom.Text = row.Cells[7].Text;
      txtdate.Text = row.Cells[2].Text;
        string time = row.Cells[3].Text;
     
        if(time == "0:00")
        {
            btnsubmit.Visible = false;
            txttime.Text = time;
        }
        else
        {
            txttime.Text = time;
            btnsubmit.Visible = true;
        }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string name = "" + Session["doc_name"];
      //  int s = 1;
        doctor doc = doctor.doc_idshow(name);
        if(doc != null)
        {
            schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, txttime.Text, Convert.ToInt32(txtroom.Text), doc.emp_doc_id);

            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('"+schedule_work_doctor.updateswd(swd)+"');", true);
        }
      
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
 
    }
}