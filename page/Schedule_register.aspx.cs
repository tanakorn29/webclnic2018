using System;
using System.Collections.Generic;
using System.Globalization;
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
        DateTime day = Convert.ToDateTime(TextBox2.Text);
        DateTime today = DateTime.Today;
        string time1 = DropDownList3.SelectedValue.ToString();
        schedule_work_doctor swd1 = schedule_work_doctor.check_room(day,time1);
   
        doctor doc = doctor.doc_idshow(name);
        int today_num = today.Day;

        if(today_num == 20)
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('หมดเวลาในการลงทะเบียน');", true);
        }else
        {
            if (swd1 != null)
            {
                int room_id = swd1.room_id;
                int status_room = swd1.swd_status_room;
                string time = swd1.swd_start_time;




                if (doc != null)

                {
                    int doc_id = doc.emp_doc_id;
                    /*        schedule_work_doctor swd2 = schedule_work_doctor.check_room_1(day,room_id);
                            schedule_work_doctor swd3 = schedule_work_doctor.check_room_2(day, room_id,doc_id);
                            if(swd3 != null)
                            {
                                if (swd2 != null)
                                {
                                    int room_id1 = swd2.room_id;
                                    int status_room1 = swd2.swd_status_room;
                                    string time2 = swd2.swd_start_time;
                                    int emp_id = swd2.emp_doc_id;
                                    int emp_doc_id = swd3.emp_doc_id;
                                    if (emp_id == emp_doc_id)
                                    {
                                        ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('มีแพทย์มาปฏิบัติงานแล้ว');", true);
                                    }
                                    else
                                    {
                            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ไม่เวลา111111111 " +emp_doc_id+" , "+emp_id+"');", true);
                              //     schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, TextBox2.Text, DropDownList3.SelectedValue.ToString(), room_id, doc.emp_doc_id);

                              //     ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);

                                    }


                                }




                            }*/

                    schedule_work_doctor swd2 = schedule_work_doctor.check_room_3(day, time, room_id);





                    schedule_work_doctor swd4 = schedule_work_doctor.check_room_5(day, doc_id);

                    if (swd2 != null)
                    {
                        int emp_doctor_id = swd2.emp_doc_id;

                        if (swd4 != null)
                        {
                            int roomiddoc = swd4.room_id;
                            int docid = swd4.emp_doc_id;
                            int swd3 = schedule_work_doctor.check_room_4(roomiddoc, day);
                            if (swd3 == 0)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('มีแพทย์ทำงานห้องตรวจแล้ว');", true);
                            }
                            else
                            {
                                schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, TextBox2.Text, DropDownList3.SelectedValue.ToString(), roomiddoc, doc.emp_doc_id);
                                ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);
                            }
                            /*
                            if (room_id == 1 && time1 == time)
                            {

                                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + room_id + "   " + time1 + "     " + time + "');", true);


                            }
                            else if (room_id == 2 && time1 == time)
                            {


                                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + room_id + "   " + time1 + "     " + time + "');", true);

                            }
                            else if (room_id == 3 && time1 == time)
                            {


                                    ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + room_id + "   " + time1 + "     " + time + "');", true);

                            }

                */



                        }
                        else
                        {
                            schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, TextBox2.Text, DropDownList3.SelectedValue.ToString(), room_id, doc.emp_doc_id);
                            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);
                        }



                    }





                    //     if (room_id == 1 || time1 == time)
                    //   {

                    //              schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, TextBox2.Text, DropDownList3.SelectedValue.ToString(), room_id, doc.emp_doc_id);

                    //           ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);
                    //      ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('มีแพทย์อยู่ห้องตรวจแล้ว12');", true);



                    //}
                    //else
                    // {


                    //   schedule_work_doctor swd = new schedule_work_doctor(txtdate.Text, TextBox2.Text, DropDownList3.SelectedValue.ToString(), room_id, doc.emp_doc_id);

                    //          ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('" + schedule_work_doctor.updateswd(swd) + "');", true);

                    //   ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('มีแพทย์อยู่ห้องตรวจแล้ว12');", true);



                    // }

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












            }else
            {
                ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ห้องตรวจซ้ำกรุณาลงใหม่');", true);
            }





        }





    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
    //   txtdate.Text = DropDownList2.SelectedValue.ToString();
    }

    protected void txtdate_TextChanged(object sender, EventArgs e)
    {
        CultureInfo ThaiCulture = new CultureInfo("th-TH");
        DateTime date_t = Convert.ToDateTime(TextBox1.Text);
        string date_th = date_t.ToString("dddd", ThaiCulture);
        txtdate.Text = date_th;
    }

    protected void txtdate0_TextChanged(object sender, EventArgs e)
    {
    }


    protected void btnselect_Click(object sender, EventArgs e)
    {
        try
        {
            CultureInfo ThaiCulture = new CultureInfo("th-TH");
            DateTime date_t = Convert.ToDateTime(TextBox1.Text);
            string date_th = date_t.ToString("yyyy-MM-dd", ThaiCulture);
            TextBox2.Text = date_th;
            string swd1 = schedule_work_doctor.check_register_work(date_th);
            if (swd1 == "1")
            {
                ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ห้องตรวจเต็ม');", true);
            }

            string day = date_t.ToString("dddd", ThaiCulture);
            txtdate.Text = day;

        }
        catch (Exception)
        {

        }
  
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
     
    }
}