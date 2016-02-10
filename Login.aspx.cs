﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    UsersFac objUser = new UsersFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        objUser._user = txtUser.Text;
        objUser._password = txtPassword.Text;
        dt = objUser.UserLogin();

        if (dt.Rows.Count > 0)
        {
            Session["login"] = dt.Rows[0]["fldName"].ToString();
            Response.Redirect("admin/Default.aspx");
        }
        else
        {
            litResult.Text = "Wrong Username or password!";
        }
    }
}