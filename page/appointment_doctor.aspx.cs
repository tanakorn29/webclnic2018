﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_appointment_doctor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


         lblnamedoc.Text = "" + Session["doc_name"];
      //  lblnamedoc.Text = "dddd";


    }
}