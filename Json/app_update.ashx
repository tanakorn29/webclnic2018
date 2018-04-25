<%@ WebHandler Language="C#" Class="app_update" %>
using System.Web.Services;
using System;
using System.Web;
using System.Web.Script.Serialization;
       using System.Collections.Generic;
public class app_update : IHttpHandler {
         [WebMethod]
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
  //      string opd = ""+ context.Session["staff_name"];
    //    appointment update = new appointment(opd);
        JavaScriptSerializer serializer = new JavaScriptSerializer();

    //    context.Response.Write(serializer.Serialize(opd));

        /*
    string a = "นายธนากร ณ ระนอง";
    int aaa = 2;
    appointment aa = appointment.show_app(aaa, a);
    if(aa != null)
    {
        JavaScriptSerializer serializer = new JavaScriptSerializer();

        context.Response.Write(serializer.Serialize("ddddddddddddddd"));

    }
    */
    }
       
    public bool IsReusable {
        get {
            return false;
        }
    }

}