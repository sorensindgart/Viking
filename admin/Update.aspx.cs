using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Update : System.Web.UI.Page
{
    SubjectsFac objSub = new SubjectsFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        dt = objSub.GetAllSubjects();

        foreach (DataRow sub in dt.Rows)
	    {
            litResult.Text += "<a href='Update_edit.aspx?edit=" + sub["fldSubID"] + "'>" + sub["fldTitle"] + "</a></br />";
	    }
    }
}