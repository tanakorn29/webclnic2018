using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for opd
/// </summary>
public class opd
{
    private static SqlConnection conn;
    private static SqlCommand command;
    public int opd_id { get; set; }

    public string opd_name { get; set; }
    public string opd_idcard { get; set; }
    public string opd_birthday { get; set; }
    public string opd_age { get; set; }
    public string opd_telwork { get; set; }
    public string opd_telmobile { get; set; }
    public string opd_telhome { get; set; }
    public string opd_telparent { get; set; }
    public string opd_nameparent { get; set; }
    public string opd_addressparent { get; set; }
    public string opd_namedad { get; set; }
    public string opd_namemom { get; set; }
    public string opd_namehusband_and_wife { get; set; }
    public string opd_address { get; set; }
    public string pos_id { get; set; }
    public string status { get; set; }
    public string workplace_id { get; set; }
    public string pos_name { get; set; }
    static opd()
    {
        //   string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        // conn = new MySqlConnection(strConnString);
        //  command = new MySqlCommand("", conn);
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }
    public opd(int opd_id, string opd_name,
     string opd_idcard, string opd_birthday, string opd_age, string opd_telwork,
    string opd_telmobile, string opd_telhome, string opd_telparent, string opd_nameparent,
    string opd_addressparent,
    string opd_namedad, string opd_namemom, string opd_namehusband_and_wife,
    string opd_address,string pos_id,string status,
    string workplace_id , string pos_name)
    {
        //
        // TODO: Add constructor logic here
        //

        this.opd_id = opd_id;
        this.opd_name = opd_name;
        this.opd_idcard = opd_idcard;
        this.opd_birthday = opd_birthday;
        this.opd_age = opd_age;
        this.opd_telwork = opd_telwork;
        this.opd_telmobile = opd_telmobile;
        this.opd_telhome = opd_telhome;
        this.opd_telparent = opd_telparent;
        this.opd_nameparent = opd_nameparent;
        this.opd_addressparent = opd_addressparent;
        this.opd_namedad = opd_namedad;
        this.opd_namemom = opd_namemom;
        this.opd_namehusband_and_wife = opd_namehusband_and_wife;
        this.opd_address = opd_address;
  
        this.pos_id = pos_id;
        this.status = status;
        this.workplace_id = workplace_id;
        this.pos_name = pos_name;
    }

    public opd(string opd_name,
  string opd_idcard, string opd_birthday,string pos_name)
    {
        this.opd_name = opd_name;
        this.opd_idcard = opd_idcard;
        this.opd_birthday = opd_birthday;
        this.pos_name = pos_name;
    }
    
    public static opd Login(string username, string password)
    {
        string query = String.Format("select count(*) from ((opd inner JOIN position On opd.pos_id = position.pos_id) inner JOIN user_control On user_control.opd_id = opd.opd_id) where user_control.uct_user =  '{0}'", username);
        command.CommandText = query;
        try
        {
            conn.Open();
            int countuser = (int)command.ExecuteScalar();
            if (countuser == 1)
            {
                query = String.Format("select user_control.uct_password from ((opd inner JOIN position On opd.pos_id = position.pos_id) inner JOIN user_control On user_control.opd_id = opd.opd_id) where user_control.uct_user = '{0}'", username);
                command.CommandText = query;
                string dbpassword = command.ExecuteScalar().ToString();
                if (dbpassword == password)
                {
                   
                  

                        query = String.Format("select opd.opd_name,position.pos_name from ((opd FULL OUTER JOIN position On opd.pos_id = position.pos_id) FULL OUTER JOIN user_control On user_control.opd_id = opd.opd_id) FULL OUTER JOIN employee_doctor On employee_doctor.emp_doc_id = user_control.emp_doc_id where user_control.uct_user ='{0}' ", username);
                        command.CommandText = query;
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {

                        string emp_ru_name = reader.GetString(0);
                      string pos_name = reader.GetString(1);
                            opd ru = new opd( emp_ru_name, username, password,pos_name);
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