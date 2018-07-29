using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for appointment_ms
/// </summary>
public class appointment_ms
{

    private static SqlConnection conn;
    private static SqlCommand command;
    public int app_id { get; set; }
    public int emp_doc_id { get; set; }
    public string swd_timezone { get; set; }
    public string day_swd { get; set; }
    public string app_day { get; set; }

    public string app_date { get; set; }
    public DateTime date_app { get; set; }
    public string app_time { get; set; }
    public string app_remark { get; set; }
    public string doc_name { get; set; }
    public string opd_name { get; set; }
    public int status_approve { get; set; }
    public int status_app { get; set; }
    public string swd_date_work { get; set; }



    static appointment_ms()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }
    public appointment_ms(int app_id, int emp_doc_id, string swd_timezone, string day_swd, string app_day, string app_date, DateTime date_app, string app_time,
        string app_remark, string doc_name, string opd_name, int status_approve, int status_app, string swd_date_work
    )
    {
        //
        // TODO: Add constructor logic here
        //
        this.app_id = app_id;
        this.emp_doc_id = emp_doc_id;
        this.swd_timezone = swd_timezone;
        this.day_swd = day_swd;
        this.app_day = app_day;

        this.app_date = app_date;
        this.date_app = date_app;
        this.app_time = app_time;
        this.app_remark = app_remark;
        this.doc_name = doc_name;
        this.opd_name = opd_name;
        this.status_approve = status_approve;
        this.status_app = status_app;
        this.swd_date_work = swd_date_work;




    }


  




}