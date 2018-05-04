﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_Schedule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // GetData();
    }

    [WebMethod]

    public static string GetData()

    {

        Dictionary<string, string> name = new Dictionary<string, string>();
        string doc_name = "น.พ. A";

        schedule_work_doctor swd = schedule_work_doctor.swd_show(doc_name);

        if(swd != null)
        {
            name.Add(swd.swd_day_work,swd.swd_start_time);
            name.Add(Convert.ToString(swd.room_id),"");
        }


        string myJsonString = (new JavaScriptSerializer()).Serialize(name);
        /*
        string name = "นายธนากร ณ ระนอง";
      

        appointment app = new appointment(name);
        string name1 = appointment.update_status(app);
        string myJsonString = (new JavaScriptSerializer()).Serialize(name1);
        */
        return myJsonString;

    }

    protected void btnregister_Click(object sender, EventArgs e)
    {
        Response.Redirect("../page/next_worksxhedule.aspx");
    }
}