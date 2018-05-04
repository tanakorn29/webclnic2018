using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_joson : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GetData();
    }

    [WebMethod]

    public static string GetData()

    {
      
        Dictionary<string, string> name = new Dictionary<string, string>();

        name.Add("1", "Sourav Kayal");

        name.Add("2", "Ram mishra");
        string myJsonString = (new JavaScriptSerializer()).Serialize(name);
        /*
        string name = "นายธนากร ณ ระนอง";
      

        appointment app = new appointment(name);
        string name1 = appointment.update_status(app);
        string myJsonString = (new JavaScriptSerializer()).Serialize(name1);
        */
        return myJsonString;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "rrrrr";
      //  ScriptManager.RegisterStartupScript(this, this.GetType(), "updatejson", "updatejson();", true);
    }
}