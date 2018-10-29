using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for schedule_work_doctor
/// </summary>
public class schedule_work_doctor
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
    public int emp_name_doc_id { get; set; }
    static schedule_work_doctor()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }
    public schedule_work_doctor(int swd_id,string swd_month_work, string swd_day_work, string swd_date_work,
        string swd_start_time, string swd_end_time, string swd_note, string swd_timezone,
        string swd_status, int swd_status_room, string swd_work_place, string swd_emp_work_place, int emp_ru_id, int room_id,
        int emp_doc_id,string emp_doc_name, int emp_name_doc_id)
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
        this.emp_name_doc_id = emp_name_doc_id;
    }
    public schedule_work_doctor(string swd_day_work, string swd_date_work,
     string swd_start_time,
    int room_id,
     int emp_doc_id)
    {
        //
        // TODO: Add constructor logic here
        //

        this.swd_day_work = swd_day_work;
        this.swd_date_work = swd_date_work;
        this.swd_start_time = swd_start_time;

        this.room_id = room_id;
        this.emp_doc_id = emp_doc_id;
    }

    public schedule_work_doctor(string swd_day_work,
 string swd_start_time,
int room_id,
 string emp_doc_name)
    {
        //
        // TODO: Add constructor logic here
        //

        this.swd_day_work = swd_day_work;
        this.swd_start_time = swd_start_time;

        this.room_id = room_id;
        this.emp_doc_name = emp_doc_name;
    }
    public schedule_work_doctor( string swd_start_time , int swd_status_room,  int room_id)
    {
        //
        // TODO: Add constructor logic here
        //
   
        this.swd_start_time = swd_start_time;
        this.swd_status_room = swd_status_room;

        this.room_id = room_id;

    }

    public schedule_work_doctor(int swd_id, int emp_doc_id)
    {
        //
        // TODO: Add constructor logic here
        //
        this.swd_id = swd_id;
        this.emp_doc_id = emp_doc_id;
   
    }

    public schedule_work_doctor(int swd_id, int emp_doc_id, int emp_name_doc_id)
    {
        //
        // TODO: Add constructor logic here
        //
        this.swd_id = swd_id;
        this.emp_doc_id = emp_doc_id;
        this.emp_name_doc_id = emp_name_doc_id;
    }
    public schedule_work_doctor(int swd_id)
    {
        //
        // TODO: Add constructor logic here
        //
        this.swd_id = swd_id;
    

    }

    public schedule_work_doctor(string swd_start_time, int swd_status_room, int room_id,int emp_doc_id)
    {
        //
        // TODO: Add constructor logic here
        //

        this.swd_start_time = swd_start_time;
        this.swd_status_room = swd_status_room;

        this.room_id = room_id;
        this.emp_doc_id = emp_doc_id;

    }
    public static schedule_work_doctor check_room(DateTime day,string time)
    {
        string query = string.Format("select swd_start_time,swd_status_room, room_id  from schedule_work_doctor where swd_date_work = '{0}' AND swd_status_room = 0 AND swd_start_time = '{1}' ", day,time);
        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string swd_start_time = reader.GetString(0);
                int swd_status_room = reader.GetInt32(1);
                int room_id = reader.GetInt32(2);
                schedule_work_doctor  swd = new schedule_work_doctor(swd_start_time, swd_status_room,room_id);
                return swd;


            }


        }
        finally
        {
            conn.Close();
        }
        return null;
    }

    public static schedule_work_doctor check_room_1(DateTime day,int room_id_1)
    {
        string query = string.Format("select swd_start_time,swd_status_room, room_id ,emp_doc_id from schedule_work_doctor where swd_date_work = '{0}' or room_id = {1}", day,room_id_1);
        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string swd_start_time = reader.GetString(0);
                int swd_status_room = reader.GetInt32(1);
                int room_id = reader.GetInt32(2);
                int emp_doc_id1 = reader.GetInt32(3);
                schedule_work_doctor swd = new schedule_work_doctor(swd_start_time, swd_status_room, room_id,emp_doc_id1);
                return swd;


            }


        }
        finally
        {
            conn.Close();
        }
        return null;
    }

    public static schedule_work_doctor check_room_2(DateTime day, int room_id_1,int doc_id)
    {
        string query = string.Format("select swd_start_time,swd_status_room, room_id ,emp_doc_id from schedule_work_doctor where swd_date_work = '{0}' AND room_id = {1} AND emp_doc_id = {2} order by room_id asc ", day, room_id_1,doc_id);
        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string swd_start_time = reader.GetString(0);
                int swd_status_room = reader.GetInt32(1);
                int room_id = reader.GetInt32(2);
                int emp_doc_id1 = reader.GetInt32(3);
                schedule_work_doctor swd = new schedule_work_doctor(swd_start_time, swd_status_room, room_id, emp_doc_id1);
                return swd;


            }


        }
        finally
        {
            conn.Close();
        }
        return null;
    }


    public static schedule_work_doctor check_room_3(DateTime day, string time , int roomid)
    {
        string query = string.Format("select swd_start_time,swd_status_room, room_id ,emp_doc_id from schedule_work_doctor where swd_date_work = '{0}' AND swd_start_time = '{1}' AND room_id <= {2}", day, time, roomid);
        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string swd_start_time = reader.GetString(0);
                int swd_status_room = reader.GetInt32(1);
                int room_id = reader.GetInt32(2);
                int emp_doc_id1 = reader.GetInt32(3);
                schedule_work_doctor swd = new schedule_work_doctor(swd_start_time, swd_status_room, room_id, emp_doc_id1);
                return swd;


            }


        }
        finally
        {
            conn.Close();
        }
        return null;
    }

    public static int check_room_4(int roomid,DateTime day)
    {
        string query = string.Format("SELECT COUNT(*) from schedule_work_doctor where swd_status_room = 1  AND room_id = {0} AND swd_date_work = '{1}'", roomid,day);
        try
        {
            conn.Open();
            command.CommandText = query;
            int count_room = (int)command.ExecuteScalar();
            if(count_room == 2)
            {
                return 0;
            }else
            {
                return 1;
            }

        }
        finally
        {
            conn.Close();
        }

    }
    public static schedule_work_doctor check_room_5(DateTime day,int empdoctorid)
    {
        string query = string.Format("select swd_start_time,swd_status_room, room_id ,emp_doc_id from schedule_work_doctor where swd_status_room = 1  AND  swd_date_work = '{0}' AND emp_doc_id = {1}", day,empdoctorid);
        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string swd_start_time = reader.GetString(0);
                int swd_status_room = reader.GetInt32(1);
                int room_id = reader.GetInt32(2);
                int emp_doc_id1 = reader.GetInt32(3);
                schedule_work_doctor swd = new schedule_work_doctor(swd_start_time, swd_status_room, room_id, emp_doc_id1);
                return swd;


            }


        }
        finally
        {
            conn.Close();
        }
        return null;
    }

    public schedule_work_doctor(int swd_status_room, string emp_doc_name)
    {
        //
        // TODO: Add constructor logic here
        //
        this.swd_status_room = swd_status_room;
        this.emp_doc_name = emp_doc_name;

    }

    public static schedule_work_doctor swd_work(int ID)
    {
        string query = String.Format("select schedule_work_doctor.swd_status_room,employee_doctor.emp_doc_name from employee_doctor inner join schedule_work_doctor on schedule_work_doctor.emp_doc_id = employee_doctor.emp_doc_id where employee_doctor.emp_doc_id = '{0}' AND swd_status_room = 4", ID);

        try
        {

            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                int swd_status_room1  = reader.GetInt32(0);
                string emp_name = reader.GetString(1);
        


                schedule_work_doctor swd = new schedule_work_doctor(swd_status_room1,emp_name);
                return swd;

            }


        }
        finally
        {
            conn.Close();
        }

        return null;
    }
    public static string updateswd(schedule_work_doctor swd)
    {
       string query = String.Format("SELECT COUNT(*) from schedule_work_doctor where swd_status_room = 1 AND emp_doc_id = {0}  AND swd_start_time = '{1}' AND swd_day_work = '{2}' AND swd_date_work = '{3}'", swd.emp_doc_id,  swd.swd_start_time, swd.swd_day_work,swd.swd_date_work);
     try
      {
          conn.Open();
         command.CommandText = query;
      /*     query = String.Format("SELECT COUNT(swd_status_room) from schedule_work_doctor where swd_status_room = 1  AND swd_start_time = '{0}' AND swd_day_work = '{1}' AND swd_date_work = '{2}'", swd.swd_start_time, swd.swd_day_work, swd.swd_date_work);
            command.CommandText = query;
            int count_enp_id = (int)command.ExecuteScalar();*/
            int amountOfUsers = (int)command.ExecuteScalar();
            if (amountOfUsers < 1)
            {
               query = String.Format("Update schedule_work_doctor set swd_status_room = 1,emp_doc_id = {0} where room_id = {1} AND swd_start_time = '{2}' AND swd_day_work = '{3}' AND swd_date_work = '{4}'", swd.emp_doc_id,swd.room_id,swd.swd_start_time,swd.swd_day_work, swd.swd_date_work);
           // conn.Open();
            command.CommandText = query;
                command.ExecuteNonQuery();
                return "ลงเวลาเรียบร้อย";
          }
          else
          {
            return "ห้องตรวจซ้ำ กรุณาเลือกใหม่";
          }
        }
        finally
        {
            conn.Close();
        }
    }


    public static string updateswd2(schedule_work_doctor swd)
    {
        string query = String.Format("SELECT COUNT(*) from schedule_work_doctor where swd_status_room = 1 AND emp_doc_id = {0}  AND swd_start_time = '{1}' AND swd_day_work = '{2}' AND swd_date_work = '{3}'", swd.emp_doc_id, swd.swd_start_time, swd.swd_day_work, swd.swd_date_work);
        try
        {
            conn.Open();
            command.CommandText = query;
            int amountOfUsers = (int)command.ExecuteScalar();
            if (amountOfUsers < 1)
            {
              query = String.Format("Update schedule_work_doctor set swd_status_room = 3,swd_note = 'รอการอนุมัติการเลื่อนปฏิบัติงาน',emp_doc_id = {0} where room_id = {1} AND swd_start_time = '{2}' AND swd_day_work = '{3}' AND swd_date_work = '{4}'", swd.emp_doc_id, swd.room_id, swd.swd_start_time, swd.swd_day_work, swd.swd_date_work);
          //  conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            return "รอการอนุมัติการเลื่อนปฏิบัติงาน";

            }
            else
            {
                return "ห้องตรวจซ้ำ กรุณาเลือกใหม่";
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static string update_chenge_note(schedule_work_doctor swd)
    {
        // string query = String.Format("SELECT COUNT(*) from schedule_work_doctor swd inner join room on room.room_id = swd.room_id where swd_day_work = '{0}' AND swd_start_time = '{1}'  AND swd_status_room = 1 ", swd.swd_day_work,swd.swd_start_time);
        try
        {
            //    conn.Open();
            //  command.CommandText = query;
            //  int amountOfUsers = (int)command.ExecuteScalar();
            //  if (amountOfUsers < 1)
            //  { 
            string query = String.Format("Update schedule_work_doctor set swd_note = 'รอการทำงานแทน',swd_status_room = 2 where swd_id = {0}", swd.swd_id);
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();

      
            return "อัพเดตเรียบร้อย";
            //  }
            // else
            //  {
            // return "ห้องตรวจซ้ำ กรุณาเลือกใหม่";
            //  }
        }
        finally
        {
            conn.Close();
        }
    }
    public static string update_chenge_note_work(schedule_work_doctor swd)
    {
        // string query = String.Format("SELECT COUNT(*) from schedule_work_doctor swd inner join room on room.room_id = swd.room_id where swd_day_work = '{0}' AND swd_start_time = '{1}'  AND swd_status_room = 1 ", swd.swd_day_work,swd.swd_start_time);
        try
        {
            //    conn.Open();
            //  command.CommandText = query;
            //  int amountOfUsers = (int)command.ExecuteScalar();
            //  if (amountOfUsers < 1)
            //  { 
            string query = String.Format("Update schedule_work_doctor set swd_note = 'ทำงานแทน',swd_status_room = 1 where swd_id = {0}", swd.swd_id);
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();


            return "อัพเดตเรียบร้อย";
            //  }
            // else
            //  {
            // return "ห้องตรวจซ้ำ กรุณาเลือกใหม่";
            //  }
        }
        finally
        {
            conn.Close();
        }
    }
    public static string centel_chenge_note_work(schedule_work_doctor swd)
    {
        // string query = String.Format("SELECT COUNT(*) from schedule_work_doctor swd inner join room on room.room_id = swd.room_id where swd_day_work = '{0}' AND swd_start_time = '{1}'  AND swd_status_room = 1 ", swd.swd_day_work,swd.swd_start_time);
        try
        {
            //    conn.Open();
            //  command.CommandText = query;
            //  int amountOfUsers = (int)command.ExecuteScalar();
            //  if (amountOfUsers < 1)
            //  { 
     string query = String.Format("Update schedule_work_doctor set swd_note = '',swd_status_room = 1,swd_emp_work_place = '',emp_doc_id = {0} where swd_id = {1}", swd.swd_id,swd.emp_doc_id);
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
       
         query = String.Format("Update schedule_work_doctor set swd_note = '',swd_status_room = 1 where  swd_note = 'รอการอนุมัติการเลื่อนปฏิบัติงาน' AND emp_doc_id = {0} ", swd.emp_name_doc_id);
        
            command.CommandText = query;
            command.ExecuteNonQuery();

            return "ยกเลิกการทำงานแทนเรียบร้อย";
            //  }
            // else
            //  {
            // return "ห้องตรวจซ้ำ กรุณาเลือกใหม่";
            //  }
        }
        finally
        {
            conn.Close();
        }
    }

    public static string centel_chenge_swd_doc_work(schedule_work_doctor swd)
    {
        // string query = String.Format("SELECT COUNT(*) from schedule_work_doctor swd inner join room on room.room_id = swd.room_id where swd_day_work = '{0}' AND swd_start_time = '{1}'  AND swd_status_room = 1 ", swd.swd_day_work,swd.swd_start_time);
        try
        {
            //    conn.Open();
            //  command.CommandText = query;
            //  int amountOfUsers = (int)command.ExecuteScalar();
            //  if (amountOfUsers < 1)
            //  { 
            string query = String.Format("Update schedule_work_doctor set swd_note = '',swd_status_room = 1 where swd_id = {0}", swd.swd_id);
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();


            return "ยกเลิกการทำงานแทนเรียบร้อย";
            //  }
            // else
            //  {
            // return "ห้องตรวจซ้ำ กรุณาเลือกใหม่";
            //  }
        }
        finally
        {
            conn.Close();
        }
    }


    public static schedule_work_doctor swd_show(string name)
    {
        string query = String.Format("select schedule_work_doctor.swd_day_work, schedule_work_doctor.swd_start_time, schedule_work_doctor.room_id, schedule_work_doctor.swd_note from schedule_work_doctor inner join employee_doctor on employee_doctor.emp_doc_id = schedule_work_doctor.emp_doc_id where emp_doc_name = '{0}'",name);

        try
        {

            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                string swd_day_work = reader.GetString(0);
                string swd_start_time = reader.GetString(1);
                int room_id = reader.GetInt32(2);
  



                schedule_work_doctor swd = new schedule_work_doctor(swd_day_work,swd_start_time,room_id,name);
                return swd;

            }


        }
        finally
        {
            conn.Close();
        }

        return null;
    }

    


}