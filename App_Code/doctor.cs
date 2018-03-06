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
    public int emp_id { get; set; }
    public string emp_username { get; set; }
    public string emp_password { get; set; }
    public string emp_fname { get; set; }
    public string emp_sname { get; set; }
    public string emp_birth { get; set; }
    public string emp_addr { get; set; }
    public string emp_telhome { get; set; }
    public string emp_tel { get; set; }
    public string emp_email { get; set; }
    public string emp_occupation_id { get; set; }
    public string emp_position { get; set; }
    static doctor()
    {
        //   string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        // conn = new MySqlConnection(strConnString);
        //  command = new MySqlCommand("", conn);
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }
    public doctor(int emp_id, string emp_username,
     string emp_password, string emp_fname, string emp_sname, string emp_birth,
    string emp_addr, string emp_telhome,string emp_tel,string emp_email,string emp_occupation_id,
    string emp_position)
    {
        //
        // TODO: Add constructor logic here
        //

        this.emp_id = emp_id;
        this.emp_username = emp_username;
        this.emp_password = emp_password;
        this.emp_fname = emp_fname;
        this.emp_sname = emp_sname;
        this.emp_birth = emp_birth;
        this.emp_addr = emp_addr;
        this.emp_telhome = emp_telhome;
        this.emp_tel = emp_tel;
        this.emp_email = emp_email;
        this.emp_occupation_id = emp_occupation_id;
        this.emp_position = emp_position;
    }
    public doctor(string emp_username,
     string emp_password,string emp_fname)
    {
        //
        // TODO: Add constructor logic here
        //


        this.emp_username = emp_username;
        this.emp_password = emp_password;
        this.emp_fname = emp_fname;

    }

    public static doctor Login_doctor(string username, string password)
    {
        string query = String.Format("SELECT COUNT(*) FROM employee WHERE emp_username = '{0}'", username);
        command.CommandText = query;
        try
        {
            conn.Open();
            int countuser = (int)command.ExecuteScalar();
            if (countuser == 1)
            {
                query = String.Format("select emp_password from employee WHERE emp_username  = '{0}'", username);
                command.CommandText = query;
                string dbpassword = command.ExecuteScalar().ToString();
                if (dbpassword == password)
                {
                    query = String.Format("select emp_fName from employee WHERE emp_username = '{0}' ", username);
                    command.CommandText = query;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        string Doctor_Name = reader.GetString(0);




                        doctor staff = new doctor(username, password,Doctor_Name);
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

}