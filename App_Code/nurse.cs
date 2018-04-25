using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for nurse
/// </summary>
public class nurse
{
    private static SqlConnection conn;
    private static SqlCommand command;
    public int emp_id { get; set; }
    public string emp_ru_name { get; set; }
    public string emp_ru_idcard { get; set; }
    public string emp_ru_birthday { get; set; }
    public string emp_ru_age { get; set; }
    public string emp_ru_telwork { get; set; }
    public string emp_ru_telmobile { get; set; }
    public string emp_ru_telhome { get; set; }
    public string emp_ru_telparent { get; set; }
    public string emp_ru_nameparent { get; set; }
    public string emp_ru_addressparent { get; set; }
    public string emp_ru_namedad { get; set; }
    public string emp_ru_namemom { get; set; }
    public string emp_ru_namehusband_and_wife { get; set; }
    public string emp_ru_address { get; set; }
    public string emp_ru_occupation_id { get; set; }
    public string emp_ru_status { get; set; }
    public string pos_id { get; set; }
    public string pos_name { get; set; }
    public string workplace_id { get; set; }

    public string status { get; set; }
    public string username { get; set; }


    static nurse()
    {
        //   string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        // conn = new MySqlConnection(strConnString);
        //  command = new MySqlCommand("", conn);
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }

    public nurse(int emp_id, string emp_ru_name,
 string emp_ru_idcard, string emp_ru_birthday, string emp_ru_age, string emp_ru_telwork,
string emp_ru_telmobile, string emp_ru_telhome, string emp_ru_telparent, string emp_ru_nameparent,
string emp_ru_addressparent,
string emp_ru_namedad, string emp_ru_namemom, string emp_ru_namehusband_and_wife,
string emp_ru_address, string emp_ru_occupation_id, string emp_ru_status,
string pos_id, string pos_name,
string workplace_id, string status, string username)
    {
        //
        // TODO: Add constructor logic here
        //

        this.emp_id = emp_id;
        this.emp_ru_name = emp_ru_name;
        this.emp_ru_idcard = emp_ru_idcard;
        this.emp_ru_birthday = emp_ru_birthday;
        this.emp_ru_age = emp_ru_age;
        this.emp_ru_telwork = emp_ru_telwork;
        this.emp_ru_telmobile = emp_ru_telmobile;
        this.emp_ru_telhome = emp_ru_telhome;
        this.emp_ru_telparent = emp_ru_telparent;
        this.emp_ru_nameparent = emp_ru_nameparent;
        this.emp_ru_addressparent = emp_ru_addressparent;
        this.emp_ru_namedad = emp_ru_namedad;
        this.emp_ru_namemom = emp_ru_namemom;
        this.emp_ru_namehusband_and_wife = emp_ru_namehusband_and_wife;
        this.emp_ru_address = emp_ru_address;
        this.emp_ru_occupation_id = emp_ru_occupation_id;
        this.emp_ru_status = emp_ru_status;
        this.pos_id = pos_id;
        this.pos_name = pos_name;
        this.workplace_id = workplace_id;
        this.status = status;
        this.username = username;
    }
    public nurse(string emp_ru_name,
string emp_ru_idcard, string emp_ru_birthday, string pos_name)
    {
        //
        // TODO: Add constructor logic here
        //

        this.emp_ru_name = emp_ru_name;
        this.emp_ru_idcard = emp_ru_idcard;
        this.emp_ru_birthday = emp_ru_birthday;
        this.pos_name = pos_name;
  
    }

    public static nurse Login_nurse(string username, string password)
    {
        string query = String.Format("select count(*)  from employee_ru inner join user_control on user_control.emp_ru_id = employee_ru.emp_ru_id inner join position on position.pos_id = employee_ru.pos_id where user_control.uct_user ='{0}'", username);
        command.CommandText = query;
        try
        {
            conn.Open();
            int countuser = (int)command.ExecuteScalar();
            if (countuser == 1)
            {
                query = String.Format("select user_control.uct_password from employee_ru inner join user_control on user_control.emp_ru_id = employee_ru.emp_ru_id inner join position on position.pos_id = employee_ru.pos_id where user_control.uct_user ='{0}'", username);
                command.CommandText = query;
                string dbpassword = command.ExecuteScalar().ToString();
                if (dbpassword == password)
                {
                    query = String.Format("select employee_ru.emp_ru_name , position.pos_name  from employee_ru inner join user_control on user_control.emp_ru_id = employee_ru.emp_ru_id inner join position on position.pos_id = employee_ru.pos_id where user_control.uct_user = '{0}' ", username);
                    command.CommandText = query;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        string emp_name = reader.GetString(0);

                        string position_name = reader.GetString(1);


                        nurse ru = new nurse(emp_name,username, password, position_name);
                        return ru;

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