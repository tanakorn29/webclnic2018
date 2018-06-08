using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_test1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtdate_TextChanged(object sender, EventArgs e)
    {
       

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        CultureInfo culture = new CultureInfo("th-TH");
        DateTime day = Convert.ToDateTime(txtdate.Text, culture);
        string date_app = day.ToString("yyyy-MM-dd dddd", culture);
        lbltest.Text = date_app;
    }
}