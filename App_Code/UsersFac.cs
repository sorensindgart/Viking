using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UsersFac
/// </summary>
public class UsersFac
{
    public int _id { get; set; }             //    fldID
    public string _name { get; set; }        //    fldName
    public string _user { get; set; }        //    fldUser
    public string _password { get; set; }    //    fldPassword

    DataAccess DA = new DataAccess();

    public DataTable UserLogin()
    {
        string SQL = "SELECT fldName FROM tblUser WHERE fldUser = @user AND fldPassword = @password";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@user", _user);
        CMD.Parameters.AddWithValue("@password", _password);
        return DA.GetData(CMD);
    }
}