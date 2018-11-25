using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for appointment_swd
/// </summary>
public class appointment_swd
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
    public int swd_id { get; set; }

    static appointment_swd()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }


    public appointment_swd(int app_id, int emp_doc_id, string swd_timezone, string day_swd, string app_day, string app_date, DateTime date_app, string app_time,
        string app_remark, string doc_name, string opd_name, int status_approve, int status_app, string swd_date_work,int swd_id
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
        this.swd_id = swd_id;



    }

    public appointment_swd(int emp_doc_id)
    {
        //
        // TODO: Add constructor logic here
        //
 
        this.emp_doc_id = emp_doc_id;





    }

    public appointment_swd(int emp_doc_id,string app_remark,string opd_name)
    {
        //
        // TODO: Add constructor logic here
        //
        this.emp_doc_id = emp_doc_id;
        this.app_remark = app_remark;

        this.opd_name = opd_name;
 



    }

    public appointment_swd(string opd_name
)
    {
        //
        // TODO: Add constructor logic here
        //

        this.opd_name = opd_name;




    }


    public appointment_swd(int emp_doc_id, string app_day, string app_date, string app_time,
        string app_remark, string opd_name, int swd_id
    )
    {
        //
        // TODO: Add constructor logic here
        //

        this.emp_doc_id = emp_doc_id;


        this.app_day = app_day;

        this.app_date = app_date;

        this.app_time = app_time;
        this.app_remark = app_remark;

        this.opd_name = opd_name;

        this.swd_id = swd_id;



    }
    public static string update_app_doctor_swd(appointment_swd app)
    {
        //    string query = String.Format("select count(*) from schedule_work_doctor where emp_doc_id = '{0}' AND swd_timezone = '{1}' AND swd_day_work = '{2}' AND swd_date_work = '{3}'", app.emp_doc_id, app.swd_timezone, app.app_day,app.swd_date_work);
        try
        {
            //  conn.Open();
            //  command.CommandText = query;
            //int count_swd = (int)command.ExecuteScalar();
            //  if (count_swd == 1)
            //  {


            string query = String.Format("Update appointment set emp_doc_id = '{0}' , day = '{1}' , app_date = '{2}',app_time = '{3}',status_approve = 2,swd_id = '{4}' from appointment inner join opd On opd.opd_id = appointment.opd_id where appointment.app_remark = '{5}' AND opd.opd_name = '{6}'", app.emp_doc_id, app.app_day, app.app_date, app.app_time,app.swd_id, app.app_remark, app.opd_name);
            //    conn.Open();
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            return "เลื่อนนัดหมายเรียบร้อยแล้ว";

            // }else
            //  {
            //    return "แพทย์ไม่ได้มาปฏิบัติงาน";
            //   }

        }
        finally
        {
            conn.Close();
        }

    }
    public static appointment_swd show_app(string name)
    {
        string query = string.Format("select opd.opd_name from appointment inner join employee_doctor on employee_doctor.emp_doc_id = appointment.emp_doc_id inner join opd on appointment.opd_id = opd.opd_id where  opd.opd_name LIKE '%{0}%' AND appointment.status_app = 1", name);
        //     string query = string.Format("select schedule_work_doctor.emp_doc_id from schedule_work_doctor where swd_date_work = '{0}'  AND schedule_work_doctor.swd_start_time LIKE '%{1}%'", app_date, time);
        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {


                string name_1 = reader.GetString(0);


                appointment_swd app = new appointment_swd(name_1);
                return app;
            }


        }
        finally
        {
            conn.Close();
        }
        return null;
    }





    public static appointment_swd show_swd_app_doctor_id(string app_date, string time)
    {
        string query = string.Format("select schedule_work_doctor.emp_doc_id from schedule_work_doctor where swd_date_work = '{0}' AND swd_note = 'ทำงานแทน' AND schedule_work_doctor.swd_start_time LIKE '%{1}%'", app_date, time);
   //     string query = string.Format("select schedule_work_doctor.emp_doc_id from schedule_work_doctor where swd_date_work = '{0}'  AND schedule_work_doctor.swd_start_time LIKE '%{1}%'", app_date, time);
        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {


                int employee_doctor_id = reader.GetInt32(0);


                appointment_swd app = new appointment_swd(employee_doctor_id);
                return app;
            }


        }
        finally
        {
            conn.Close();
        }
        return null;
    }






    public static string confirm_app(appointment_swd app)
    {

        try
        {
            string query = String.Format("Update appointment set status_approve = 2 , status_app = 1 ,emp_doc_id = {0} from appointment inner join opd On opd.opd_id = appointment.opd_id where appointment.app_remark =  '{1}' AND opd.opd_name = '{2}'", app.emp_doc_id,app.app_remark, app.opd_name);
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            return null;
        }
        finally
        {
            conn.Close();
        }

    }



}