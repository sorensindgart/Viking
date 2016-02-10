using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Delete : System.Web.UI.Page
{
    SubjectsFac objSub = new SubjectsFac();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["delid"]))
        {
            DeleteSubject();
        }
        DataTable dt = new DataTable();
        dt = objSub.GetAllSubjects();

        foreach (DataRow sub in dt.Rows)
        {
            litSubject.Text += "<a href='Delete.aspx?delid=" + sub["fldSubID"] + "' onclick='return confirm (\"Are you sure you want to delete this subject?\")'>" + sub["fldTitle"] + "</a><br />";
        }
    }

    protected void DeleteSubject()
    {
        objSub._id = Convert.ToInt32(Request.QueryString["delid"]);
        objSub.DelSubject(); // from SQL FAC
        Response.Redirect("Delete.aspx");
    }
}