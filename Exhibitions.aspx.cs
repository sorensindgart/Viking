using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Exhibitions : System.Web.UI.Page
{
    SubjectsFac objSub = new SubjectsFac();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt = objSub.GetAllSubjects();

        foreach (DataRow sub in dt.Rows)
        {
            litResult.Text += "<a href='Subject.aspx?subid=" + sub["fldSubID"] + "'><img src='img/" + sub["fldImage"] + "'/></a><br />" + sub["fldTitle"] + "<br /><br />";
        }
    }
}