<%@ WebHandler Language="C#" Class="json_test" %>

using System;
using System.Web;
    using System.Collections.Generic;
    using System.Web.Script.Serialization;
public class json_test : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";

       
             context.Response.Write(GetData());
            /*
            Dictionary<string, string> name = new Dictionary<string, string>();

    name.Add("1", "Sourav Kayal");

    name.Add("2", "Ram mishra");

                JavaScriptSerializer serializer = new JavaScriptSerializer();

        context.Response.Write(serializer.Serialize(name));
        */
    }
 public static string GetData()

{

    Dictionary<string, string> name = new Dictionary<string, string>();

    name.Add("1", "Sourav Kayal");

    name.Add("2", "Ram mishra");

    string myJsonString = (new JavaScriptSerializer()).Serialize(name);

    return myJsonString;

}


    public bool IsReusable {
        get {
            return false;
        }
    }

}