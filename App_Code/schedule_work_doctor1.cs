﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for schedule_work_doctor1
/// </summary>
public class schedule_work_doctor1
{
    private static SqlConnection conn;
    private static SqlCommand command;
    public int swd_id { get; set; }
    public string swd_month_work { get; set; }
    public string swd_day_work { get; set; }
    public string swd_date_work { get; set; }
    public string swd_start_time { get; set; }
    public string swd_end_time { get; set; }
    public string swd_note { get; set; }
    public string swd_timezone { get; set; }
    public string swd_status { get; set; }
    public int swd_status_room { get; set; }
    public string swd_work_place { get; set; }
    public string swd_emp_work_place { get; set; }
    public int emp_ru_id { get; set; }
    public int room_id { get; set; }
    public int emp_doc_id { get; set; }
    public string emp_doc_name { get; set; }
    static schedule_work_doctor1()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }
    public schedule_work_doctor1(int swd_id, string swd_month_work, string swd_day_work, string swd_date_work,
        string swd_start_time, string swd_end_time, string swd_note, string swd_timezone,
        string swd_status, int swd_status_room, string swd_work_place, string swd_emp_work_place, int emp_ru_id, int room_id,
        int emp_doc_id, string emp_doc_name)
    {
        //
        // TODO: Add constructor logic here
        //
        this.swd_id = swd_id;
        this.swd_month_work = swd_month_work;
        this.swd_day_work = swd_day_work;
        this.swd_date_work = swd_date_work;
        this.swd_start_time = swd_start_time;
        this.swd_end_time = swd_end_time;
        this.swd_note = swd_note;
        this.swd_timezone = swd_timezone;
        this.swd_status = swd_status;
        this.swd_status_room = swd_status_room;
        this.swd_work_place = swd_work_place;
        this.swd_emp_work_place = swd_emp_work_place;
        this.emp_ru_id = emp_ru_id;
        this.room_id = room_id;
        this.emp_doc_id = emp_doc_id;
        this.emp_doc_name = emp_doc_name;
    }

    public schedule_work_doctor1(string emp_doc_name)
    {
        //
        // TODO: Add constructor logic here
        //

        this.emp_doc_name = emp_doc_name;
    }



    public static schedule_work_doctor1 show_swd_doc(string name)
    {
        string query = string.Format("select employee_doctor.emp_doc_name from employee_doctor where employee_doctor.emp_doc_name LIKE '%{0}%'", name);
        //     string query = string.Format("select schedule_work_doctor.emp_doc_id from schedule_work_doctor where swd_date_work = '{0}'  AND schedule_work_doctor.swd_start_time LIKE '%{1}%'", app_date, time);
        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {


                string name_1 = reader.GetString(0);


               schedule_work_doctor1 app = new schedule_work_doctor1(name_1);
                return app;
            }


        }
        finally
        {
            conn.Close();
        }
        return null;
    }

}