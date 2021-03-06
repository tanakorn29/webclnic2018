﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for appointment
/// </summary>
public class appointment
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
    public string  doc_name { get; set; }
    public string opd_name { get; set; }
    public int status_approve { get; set; }
    public int status_app { get; set; }
   public string swd_date_work { get; set; }
 public int swd_id { get; set; }


    static appointment()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }
    public appointment(int app_id, int emp_doc_id, string swd_timezone, string day_swd, string app_day, string app_date,DateTime date_app , string app_time,
        string app_remark,string doc_name,string opd_name,int status_approve,int status_app, string swd_date_work
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



    public appointment(DateTime date_app, string app_time,
    string app_remark, string doc_name, string opd_name, int status_approve, int status_app)
    {
        //
        // TODO: Add constructor logic here
        //
        
        this.date_app = date_app;
        this.app_time = app_time;
        this.app_remark = app_remark;
        this.doc_name = doc_name;
        this.opd_name = opd_name;
        this.status_approve = status_approve;
        this.status_app = status_app;

    }

    public appointment(string app_remark, string opd_name)
    {
        //
        // TODO: Add constructor logic here
        //

        this.app_remark = app_remark;
        this.opd_name = opd_name;
     

    }
    public appointment(string app_date, string app_time,
string app_remark, string doc_name, string opd_name, int status_approve)
    {
        //
        // TODO: Add constructor logic here
        //

        this.app_date = app_date;
        this.app_time = app_time;
        this.app_remark = app_remark;
        this.doc_name = doc_name;
        this.opd_name = opd_name;
        this.status_approve = status_approve;


    }
    public appointment(int emp_doc_id, string swd_timezone, string app_day, string app_date, string app_time,
string app_remark, string opd_name , string swd_date_work)
    {
        //
        // TODO: Add constructor logic here
        //
        this.emp_doc_id = emp_doc_id;
        this.swd_timezone = swd_timezone;
        this.app_day = app_day;

        this.app_date = app_date;
        this.app_time = app_time;
        this.app_remark = app_remark;
       
        this.opd_name = opd_name;
        this.swd_date_work = swd_date_work;

    }
    public appointment(int status_approve)
    {
        //
        // TODO: Add constructor logic here
        //

     
        this.status_approve = status_approve;

    }
    public appointment(int app_id, int emp_doc_id, string swd_timezone, string app_day, string app_date, string app_time, string swd_date_work)
    {
        //
        // TODO: Add constructor logic here
        //
        this.app_id = app_id;
        this.emp_doc_id = emp_doc_id;
        this.swd_timezone = swd_timezone;
        this.app_day = app_day;
        this.app_date = app_date;
        this.app_time = app_time;
        this.swd_date_work = swd_date_work;
    }


    public appointment(int emp_doc_id,
    string app_remark,  string opd_name
)
    {
        //
        // TODO: Add constructor logic here
        //

        this.emp_doc_id = emp_doc_id;
        this.app_remark = app_remark;
        this.opd_name = opd_name;





    }

    public appointment(int emp_doc_id, DateTime date_app,string app_time)
    {
        //
        // TODO: Add constructor logic here
        //
        this.emp_doc_id = emp_doc_id;


        this.date_app = date_app;

        this.app_time = app_time;


    }



    public static appointment show_app_next_opd(string opd_name)
    {
        string query = string.Format("select appointment.app_date,appointment.app_time,appointment.emp_doc_id from appointment inner join opd On opd.opd_id = appointment.opd_id where opd.opd_name = '{0}'", opd_name);
        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                DateTime date_app = reader.GetDateTime(0);
                string app_time = reader.GetString(1);
                int employee_doctor_id = reader.GetInt32(2);


                appointment app = new appointment(employee_doctor_id, date_app,app_time);
                return app;
            }


        }
        finally
        {
            conn.Close();
        }
        return null;
    }



    public static string update_app_opd(appointment app)
    {
        string query = String.Format("select count(*) from schedule_work_doctor where emp_doc_id = '{0}' AND swd_timezone = '{1}' AND swd_day_work = '{2}' AND swd_date_work = '{3}'", app.emp_doc_id, app.swd_timezone, app.app_day, app.swd_date_work);
        try
        {
            conn.Open();
            command.CommandText = query;
            int count_swd = (int)command.ExecuteScalar();
            if (count_swd == 1)
            {

                
             query = String.Format("Update appointment set app_date = '{0}', app_time = '{1}',status_approve = 5 where app_id = {2}", app.app_date, app.app_time,  app.app_id);
               // conn.Open();
                command.CommandText = query;
                command.ExecuteNonQuery();           
       

               
                return "อัพเดตข้อมูลเรียบร้อย";


                //  return "อัพเดตเรียบร้อย";


            }
            else
            {
                return "แพทย์ไม่ได้มาปฏิบัติงาน";

            }
             
            }
        finally
        {
            conn.Close();
        }

    }

    public static string update_app_doctor_next(appointment app)
    {

        try
        {
            string query = String.Format("Update appointment set app_date = '{0}', app_time = '{1}',status_approve = 2 where app_id = {2}", app.app_date, app.app_time, app.app_id);
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

    public static string cancel_app(appointment app)
    {

        try
        {
            string query = String.Format("Update appointment set status_app = 0 where app_id = {0}", app.app_id);
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

    public static ArrayList sent_app_nurse()
    {

        ArrayList list = new ArrayList();
        string query = string.Format("select appointment.app_date,appointment.app_time,appointment.app_remark,employee_doctor.emp_doc_name,opd.opd_name,appointment.status_approve from ((appointment inner join opd On opd.opd_id= appointment.opd_id) inner join employee_doctor on employee_doctor.emp_doc_id = appointment.emp_doc_id) where status_approve = 2 OR status_approve = 3");

        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string app_date = reader.GetString(0);
                string app_time = reader.GetString(1);
                string app_remark = reader.GetString(2);
                string employee_doctor = reader.GetString(3);
                string opd_name1 = reader.GetString(4);
                int status_approve1 = reader.GetInt32(5);
                appointment app1 = new appointment(app_date, app_time, app_remark, employee_doctor, opd_name1, status_approve1);
                list.Add(app1);
            }
        }
        finally
        {
            conn.Close();
        }

        return list;
    }
    public static string update_app_doctor(appointment app)
    {
    //    string query = String.Format("select count(*) from schedule_work_doctor where emp_doc_id = '{0}' AND swd_timezone = '{1}' AND swd_day_work = '{2}' AND swd_date_work = '{3}'", app.emp_doc_id, app.swd_timezone, app.app_day,app.swd_date_work);
        try
        {
          //  conn.Open();
          //  command.CommandText = query;
            //int count_swd = (int)command.ExecuteScalar();
          //  if (count_swd == 1)
          //  {

               
            string query = String.Format("Update appointment set emp_doc_id = '{0}' , day = '{1}' , app_date = '{2}',app_time = '{3}',status_approve = 2 from appointment inner join opd On opd.opd_id = appointment.opd_id where appointment.app_remark = '{4}' AND opd.opd_name = '{5}'",app.emp_doc_id, app.app_day, app.app_date, app.app_time, app.app_remark, app.opd_name);
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

    public appointment(string app_date, string app_time,
string app_remark, string doc_name, string opd_name, int status_approve,int swd_id)
    {
        //
        // TODO: Add constructor logic here
        //

        this.app_date = app_date;
        this.app_time = app_time;
        this.app_remark = app_remark;
        this.doc_name = doc_name;
        this.opd_name = opd_name;
        this.status_approve = status_approve;
        this.swd_id = swd_id;


    }
    public static string update_app_doctor_now(appointment app)
    {
        //    string query = String.Format("select count(*) from schedule_work_doctor where emp_doc_id = '{0}' AND swd_timezone = '{1}' AND swd_day_work = '{2}' AND swd_date_work = '{3}'", app.emp_doc_id, app.swd_timezone, app.app_day,app.swd_date_work);
        try
        {
            //  conn.Open();
            //  command.CommandText = query;
            //int count_swd = (int)command.ExecuteScalar();
            //  if (count_swd == 1)
            //  {


            string query = String.Format("Update appointment set emp_doc_id = '{0}' , day = '{1}' , app_date = '{2}',app_time = '{3}',status_approve = 2,appointment.swd_id = '{4}' from appointment inner join opd On opd.opd_id = appointment.opd_id where appointment.app_remark = '{5}' AND opd.opd_name = '{6}'", app.emp_doc_id, app.app_day, app.app_date, app.app_time, app.swd_id, app.app_remark, app.opd_name);
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

    public static string update_app_doctor_name(appointment app_doc)
    {
       
        try
        {
       


                string query = String.Format("Update appointment set emp_doc_id = '{0}', status_approve = 2 from appointment inner join opd On opd.opd_id = appointment.opd_id where appointment.app_remark = '{1}' AND opd.opd_name = '{2}'", app_doc.emp_doc_id, app_doc.app_remark, app_doc.opd_name);
                conn.Open();
                command.CommandText = query;
                command.ExecuteNonQuery();
                return "อัพเดทข้อมูลเรียบร้อย";


        }
        finally
        {
            conn.Close();
        }

    }
    public static string update_status (appointment app)
    {
      
        try
        {
               string  query = String.Format("Update appointment set status_approve = 0 , status_app = 0  from appointment inner join opd On opd.opd_id = appointment.opd_id where appointment.app_remark =  '{0}' AND opd.opd_name = '{1}'", app.app_remark,app.opd_name);
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

    public static string confirm_app(appointment app)
    {

        try
        {
            string query = String.Format("Update appointment set status_approve = 2 , status_app = 1  from appointment inner join opd On opd.opd_id = appointment.opd_id where appointment.app_remark =  '{0}' AND opd.opd_name = '{1}'", app.app_remark,app.opd_name);
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
    public static int count_app()
    {


        string query = string.Format("select count(*) from ((appointment inner join opd On opd.opd_id= appointment.opd_id) inner join employee_doctor on employee_doctor.emp_doc_id = appointment.emp_doc_id) where status_approve = 4 OR status_approve = 3 OR status_approve = 6");
        command.CommandText = query;
        try
        {
            conn.Open();
            int countapp = (int)command.ExecuteScalar();
            return countapp;
        }
        finally
        {
            conn.Close();
        }
        return 0;
    }



    public static ArrayList sent_app_doctor(int status_app)
    {

        ArrayList list = new ArrayList();
        string query = string.Format("select appointment.app_date,appointment.app_time,appointment.app_remark,employee_doctor.emp_doc_name,opd.opd_name,appointment.status_approve from ((appointment inner join opd On opd.opd_id= appointment.opd_id) inner join employee_doctor on employee_doctor.emp_doc_id = appointment.emp_doc_id) where  appointment.status_approve = '{0}'", status_app);

        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string app_date = reader.GetString(0);
                string app_time = reader.GetString(1);
                string app_remark = reader.GetString(2);
                string employee_doctor = reader.GetString(3);
                string opd_name1 = reader.GetString(4);
                int status_approve1 = reader.GetInt32(5);
                appointment app1 = new appointment(app_date, app_time, app_remark, employee_doctor, opd_name1, status_approve1);
                list.Add(app1);
            }
        }
        finally
        {
            conn.Close();
        }

        return list;
    }

    public static appointment check_status(string opd_name)
    {
        string query = string.Format("select appointment.status_approve from ((appointment inner join opd On opd.opd_id= appointment.opd_id) inner join employee_doctor on employee_doctor.emp_doc_id = appointment.emp_doc_id) where opd.opd_name = '{0}'", opd_name);
        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
             
                int status_approve1 = reader.GetInt32(0);
                appointment app = new appointment(status_approve1);
                return app;
            }


        }
        finally
        {
            conn.Close();
        }
        return null;
    }
    public static appointment show_app(int status_app, string opd_name)
    {
        string query = string.Format("select appointment.app_date,appointment.app_time,appointment.app_remark,employee_doctor.emp_doc_name,opd.opd_name,appointment.status_approve from ((appointment inner join opd On opd.opd_id= appointment.opd_id) inner join employee_doctor on employee_doctor.emp_doc_id = appointment.emp_doc_id) where  appointment.status_app = {0} AND opd.opd_name = '{1}'", status_app,opd_name);
        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
              
                DateTime app_date = reader.GetDateTime(0);
                string app_time = reader.GetString(1);
                string app_remark = reader.GetString(2);
                string employee_doctor = reader.GetString(3);
                string opd_name1 = reader.GetString(4);
                int status_approve1 = reader.GetInt32(5);

                appointment app = new appointment(app_date, app_time, app_remark, employee_doctor, opd_name1, status_approve1, status_app);
                return app;
            }


            }
        finally
        {
            conn.Close();
        }
            return null;
    }








    public static DataTable  show_app_history(string opd_name)
    {
        string query = string.Format("select appointment.app_date As วันที่นัดหมาย,appointment.app_time As เวลานัดหมาย,appointment.app_remark As หมายเหตุ,employee_doctor.emp_doc_name As แพทย์ที่เข้าพบ from ((appointment inner join opd On opd.opd_id= appointment.opd_id) inner join employee_doctor on employee_doctor.emp_doc_id = appointment.emp_doc_id) where appointment.status_app = 0 AND opd.opd_name = '{0}'", opd_name);
        DataTable dt = new DataTable();
        try
        {
            conn.Open();
            command.CommandText = query;
    
          
            SqlDataReader reader = command.ExecuteReader();
   
            dt.Load(reader);
         


        }
        finally
        {
            conn.Close();
        }
        return dt;
    }

    public static DataTable show_app_doctor(string doctor_name)
    {
        string query = string.Format("select appointment.app_date As วันที่นัดหมาย, appointment.app_time As เวลานัดหมาย,appointment.app_remark As หมายเหตุ from appointment inner join employee_doctor On employee_doctor.emp_doc_id = appointment.emp_doc_id where appointment.status_approve = 3 AND  employee_doctor.emp_doc_name =  '{0}'", doctor_name);
        DataTable dt = new DataTable();
        try
        {
            conn.Open();
            command.CommandText = query;


            SqlDataReader reader = command.ExecuteReader();

            dt.Load(reader);



        }
        finally
        {
            conn.Close();
        }
        return dt;
    }


}