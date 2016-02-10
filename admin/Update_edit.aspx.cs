using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Update_edit : System.Web.UI.Page
{
    SubjectsFac objSub = new SubjectsFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["edit"]))
            {
                objSub._id = Convert.ToInt32(Request.QueryString["edit"]);

                dt = objSub.GetSubjectFromID();
                if (!IsPostBack)
                {
                    ShowSubject();
                }

                txtTitle.Text = dt.Rows[0]["fldTitle"].ToString();
                txtText.Text = dt.Rows[0]["fldText"].ToString();
            }
            else
            {
                Response.Redirect("Update.aspx");
            }
        }
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        objSub._id = Convert.ToInt32(Request.QueryString["edit"]);
        dt = objSub.GetSubjectFromID();

        string imagename;

        objSub._title = txtTitle.Text;
        objSub._text = txtText.Text;



        if ((chbImg.Checked || fuImage.HasFile) && !string.IsNullOrEmpty(dt.Rows[0]["fldImage"].ToString()))
        {
            IOFunctions.DeleteFile(Server.MapPath("../img/") + dt.Rows[0]["fldImage"]);
            imagename = ""; // Så img-navn bliver slettet i DB ved slet
        }

        else
        {
            imagename = dt.Rows[0]["fldImage"].ToString();
        }

        if (fuImage.HasFile)
        {
            imagename = PictureSave.SavePicture(fuImage.PostedFile, "img/", 300);
        }
        objSub._img = imagename;

        int updatedsubjects = objSub.EditSubject();

        if (updatedsubjects > 0)
        {
            
            litResult.Text = "<h4>Updated!</h4>";
        }
        else
	    {
            litResult.Text = "<h4>Failed!</h4>";
	    }
    }

    protected void ShowSubject()
    {
        if (!string.IsNullOrEmpty(dt.Rows[0]["fldImage"].ToString()))
        {
            imgImage.ImageUrl = "../img/" + dt.Rows[0]["fldImage"].ToString();
            imgImage.Visible = true; // Gør img synligt
            chbImg.Visible = true; // Gør slet-img-checkbox synlig
        }
        else
        {
        // Hvis der ikke er et billede i db...
        imgImage.Visible = false; // Skjul img-container/tomt image
        chbImg.Visible = false; // Skjul slet-img-checkbox
        }
    }
}