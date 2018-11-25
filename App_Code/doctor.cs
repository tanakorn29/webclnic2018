using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for doctor
/// </summary>
public class doctor
{    //  private static MySqlConnection conn;
    //  private static MySqlCommand command;
    private static SqlConnection conn;
    private static SqlCommand command;
    public int emp_doc_id { get; set; }
    public string emp_doc_name { get; set; }
    public string emp_doc_idcard { get; set; }
    public string emp_doc_birth { get; set; }
    public string emp_doc_address { get; set; }
    public string emp_doc_tel { get; set; }
    public string emp_doc_email { get; set; }
    public int emp_doc_occupation_id { get; set; }
    public string emp_doc_specialist { get; set; }
    public int emp_doc_spec_id { get; set; }

    static doctor()
    {
        //   string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        // conn = new MySqlConnection(strConnString);
        //  command = new MySqlCommand("", conn);
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }

    public doctor(int emp_doc_id, string emp_doc_name,
     string emp_doc_idcard, string emp_doc_birth, string emp_doc_address, string emp_doc_tel,
    string emp_doc_email, int emp_doc_occupation_id, string emp_doc_specialist, int emp_doc_spec_id)
    {
        //
        // TODO: Add constructor logic here
        //
        this.emp_doc_id = emp_doc_id;
        this.emp_doc_name = emp_doc_name;
        this.emp_doc_idcard = emp_doc_idcard;
        this.emp_doc_birth = emp_doc_birth;
        this.emp_doc_address = emp_doc_address;
        this.emp_doc_tel = emp_doc_tel;
        this.emp_doc_email = emp_doc_email;
        this.emp_doc_occupation_id = emp_doc_occupation_id;
        this.emp_doc_specialist = emp_doc_specialist;
        this.emp_doc_spec_id = emp_doc_spec_id;
    }
    public doctor(int emp_doc_id, string emp_doc_name)
    {
        //
        // TODO: Add constructor logic here
        //
        this.emp_doc_id = emp_doc_id;
        this.emp_doc_name = emp_doc_name;

    }
    public doctor(int emp_doc_id,
     string emp_doc_idcard, string emp_doc_birth, string emp_doc_name, string emp_doc_specialist)
    {
        //
        // TODO: Add constructor logic here
        //

        this.emp_doc_id = emp_doc_id;
        this.emp_doc_idcard = emp_doc_idcard;
        this.emp_doc_birth = emp_doc_birth;

        this.emp_doc_name = emp_doc_name;
        this.emp_doc_specialist = emp_doc_specialist;
    }


    public doctor(int emp_doc_spec_id)
    {
        //
        // TODO: Add constructor logic here
        //

        this.emp_doc_spec_id = emp_doc_spec_id;
    }


    public doctor(string emp_doc_specialist)
    {
        //
        // TODO: Add constructor logic here
        //

        this.emp_doc_specialist = emp_doc_specialist;

    }

    public static doctor Login_doctor(string username, string password)
    {
        string query = String.Format("select count(*)  from employee_doctor inner join user_control On user_control.emp_doc_id = employee_doctor.emp_doc_id where user_control.uct_user ='{0}'", username);
        command.CommandText = query;
        try
        {
            conn.Open();
            int countuser = (int)command.ExecuteScalar();
            if (countuser == 1)
            {
                query = String.Format("select user_control.uct_password from employee_doctor inner join user_control On user_control.emp_doc_id = employee_doctor.emp_doc_id where user_control.uct_user ='{0}'", username);
                command.CommandText = query;
                string dbpassword = command.ExecuteScalar().ToString();
                if (dbpassword == password)
                {
                    query = String.Format("select employee_doctor.emp_doc_id,employee_doctor.emp_doc_name , specialist.emp_doc_specialist  from employee_doctor inner join user_control On user_control.emp_doc_id = employee_doctor.emp_doc_id inner join specialist On specialist.emp_doc_specialistid = employee_doctor.emp_doc_specialistid where user_control.uct_user ='{0}' ", username);
                    command.CommandText = query;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int doc_id = reader.GetInt32(0);
                        string Doctor_Name = reader.GetString(1);
                        string specialist = reader.GetString(2);



                        doctor staff = new doctor(doc_id,username, password,Doctor_Name,specialist);
                        return staff;

                    }
                    return null;
                }
                return null;

            }
            else
            {
                return null;
            }

        }
        finally
        {
            conn.Close();
        }

        return null;
    }
    public static doctor doc_idshow(string doc_name)
    {
        string query = String.Format("select emp_doc_id from employee_doctor where emp_doc_name = '{0}' ", doc_name);
        
        try
        {
          
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                int doc_id = reader.GetInt32(0);




                        doctor doc = new doctor(doc_id,doc_name);
                        return doc;

                    }
       

        }
        finally
        {
            conn.Close();
        }

        return null;
    }

    public static doctor doc_specialist(string name)
    {
        string query = String.Format("select emp_doc_specialistid from employee_doctor where emp_doc_name = '{0}'", name);

        try
        {

            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                int spec_id = reader.GetInt32(0);




                doctor doc = new doctor(spec_id);
                return doc;

            }


        }
        finally
        {
            conn.Close();
        }

        return null;
    }

    public static doctor doc_specialist_id(int spc_id)
    {
        string query = String.Format("select emp_doc_specialist from specialist where emp_doc_specialistid = {0}", spc_id);

        try
        {

            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

               string specname = reader.GetString(0);




                doctor doc = new doctor(specname);
                return doc;

            }


        }
        finally
        {
            conn.Close();
        }

        return null;
    }


    public static doctor check_spec_name(string doc_name)
    {
        string query = String.Format("select specialist.emp_doc_specialist from employee_doctor inner join specialist On specialist.emp_doc_specialistid = employee_doctor.emp_doc_specialistid where employee_doctor.emp_doc_name = '{0}'", doc_name);

        try
        {

            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                string specname = reader.GetString(0);




                doctor doc = new doctor(specname);
                return doc;

            }


        }
        finally
        {
            conn.Close();
        }

        return null;
    }
}