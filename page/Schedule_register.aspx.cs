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
       btnsubmit.Visible = true;
    }

    protected void txtroom_TextChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
    //    txtroom.Text = row.Cells[7].Text;
      txtdate.Text = row.Cells[2].Text;
        string time = row.Cells[3].Text;
    /* 
        if(time == "0:00")
        {
            //btnsubmit.Visible = false;
            txttime.Text = time;
        }
        else
        {
            txttime.Text = time;
            //btnsubmit.Visible = true;
        }
        */
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string name = "" + Session["doc_name"];
        //  int s = 1;
        string day = DropDownList2.SelectedValue.ToString();
        string time1 = DropDownList3.SelectedValue.ToString();
        schedule_work_doctor swd1 = schedule_work_doctor.check_room(day,time1);

        if(swd1 != null)
        {
            int room_id = swd1.room_id;
            int status_room = swd1.swd_status_room;
            string time = swd1.swd_start_time;
            doctor doc = doctor.doc_idshow(name);
            if (doc != null)

            {
                if (room_id == 1 || time1 == time)
                {
                    schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, DropDownList3.SelectedValue.ToString(), room_id , doc.emp_doc_id);

                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);
                    // ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + room_id + "');", true);


                } else
                {
                    schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, DropDownList3.SelectedValue.ToString(), room_id, doc.emp_doc_id);

                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);
                }

                /*
                if (room_id == 1 && status_room == 0)
                {
                    schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, DropDownList3.SelectedValue.ToString(),1, doc.emp_doc_id);

                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);
                }else if (room_id == 2 && status_room == 0)
                {
                    schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, DropDownList3.SelectedValue.ToString(), 2, doc.emp_doc_id);

                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);
                }
                else if (room_id == 3 && status_room == 0)
                {
                    schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, DropDownList3.SelectedValue.ToString(), 3, doc.emp_doc_id);

                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);
                }

    */



            }


         


        }

  
  


    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtdate.Text = DropDownList2.SelectedValue.ToString();
    }
}