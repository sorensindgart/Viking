using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Create : System.Web.UI.Page
{
    SubjectsFac objSub = new SubjectsFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        string imagename = "test.jpg";

        if (fuImage.HasFile)
        {
            imagename = PictureSave.SavePicture(fuImage.PostedFile, "img/", 300);
        }

        objSub._img = imagename;
        objSub._title = txtTitle.Text;
        objSub._text = txtText.Text;

        int addedsubject = objSub.AddSubject();

        if (addedsubject > 0)
        {
            txtTitle.Text = "";
            txtText.Text = "";

            litResult.Text = "<h4>Subject submitted!";
        }
        else
	    {
            litResult.Text = "<h4>Error!";
	    }
    }
}