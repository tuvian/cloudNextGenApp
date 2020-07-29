using BusinessLayer;
using Entity;
using System;
using System.Data;
using System.Web.UI;

namespace NextGenCloudApp
{
    public partial class comments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DataTable dtTbl = new DataTable();
                dtTbl = (new BL()).searchComments();
                GridItems.PageSize = Convert.ToInt32(10);
                GridItems.DataSource = dtTbl;
                GridItems.DataBind();
            }
        }

        private void fillComments()
        {
            DataTable dtTbl = new DataTable();
            dtTbl = (new BL()).searchComments();
            GridItems.PageSize = Convert.ToInt32(10);
            GridItems.DataSource = dtTbl;
            GridItems.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                BL objBL = new BL();
                CommentsEntity objComments = new CommentsEntity();
                objComments.name = txtName.Text.Trim().Replace("'", "''");
                objComments.comment = txtComments.Text.Trim().Replace("'", "''");

                string result = objBL.InsertComment(objComments);
                //fillComments();
                if (result == "success")
                {
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert", string.Format("alert('{0}');",
                        "Thanks for your comments"), true);
                    Clearfields();
                    fillComments();
                }
                else
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert", string.Format("alert('{0}');",
                        "Error Occured, Please try Again"), true);
            }
        }

        private void Clearfields()
        {
            txtComments.Text = "";
            txtName.Text = "";
        }
    }
}
   