using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for appointment_mg
/// </summary>
public class appointment_mg
{
    private static SqlConnection conn;
    private static SqlCommand command;
    public int app_id { get; set; }
    public DateTime app_date { get; set; }
    public string app_time { get; set; }
    public string app_remark { get; set; }
    public string doc_name { get; set; }
    public string opd_name { get; set; }
    public int status_approve { get; set; }
    public int status_app { get; set; }
    public string emp_doc_name { get; set; }

    static appointment_mg()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }
    public appointment_mg(int app_id, DateTime app_date, string app_time,
        string app_remark, string doc_name, string opd_name, int status_approve, int status_app,string emp_doc_name)
    {
        //
        // TODO: Add constructor logic here
        //
        this.app_id = app_id;
        this.app_date = app_date;
        this.app_time = app_time;
        this.app_remark = app_remark;
        this.doc_name = doc_name;
        this.opd_name = opd_name;
        this.status_approve = status_approve;
        this.status_app = status_app;
        this.emp_doc_name = emp_doc_name;

    }

    public appointment_mg(int app_id)
    {
        //
        // TODO: Add constructor logic here
        //
        this.app_id = app_id;
    }

    public appointment_mg(string emp_doc_name)
    {
        //
        // TODO: Add constructor logic here
        //
        this.emp_doc_name = emp_doc_name;
    }

    public static string cancel_app(appointment_mg app)
    {

        try
        {
            string query = String.Format("Update appointment set status_approve = 0,status_app = 0 where app_id = {0}", app.app_id);
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            return "อัพเดตข้อมูลเรียบร้อย";

        }
        finally
        {
            conn.Close();
        }

    }

    public static string cancel_app1(appointment_mg name)
    {

        string query = string.Format("select app_id from appointment inner join employee_doctor on employee_doctor.emp_doc_id = appointment.emp_doc_id where employee_doctor.emp_doc_name = '{0}'", name.emp_doc_name);
        try
        {
            conn.Open();
            command.CommandText = query;
           // string app_id = command.ExecuteScalar().ToString();

            int app_id = (int)command.ExecuteScalar();


            query = String.Format("Update appointment set status_approve = 0,status_app = 0 where app_id = {0}", app_id);
          //  conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
             return "อัพเดตข้อมูลเรียบร้อย";

      

        }
        finally
        {
            conn.Close();
        }
     //   return null;

    }



    /*
    public static string update_app_doctor(appointment app)
    {

        try
        {
            string query = String.Format("Update appointment set app_date = '{0}',app_time = '{1}',status_approve = 3 from appointment inner join opd On opd.opd_id = appointment.opd_id where appointment.app_remark = '{2}' AND opd.opd_name = '{3}'", app.app_date, app.app_time, app.app_remark, app.opd_name);
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            return "อัพเดตข้อมูลเรียบร้อย";
        }
        finally
        {
            conn.Close();
        }

    }

    */

}