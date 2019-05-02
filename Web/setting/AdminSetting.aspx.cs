using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UFB.Web.setting
{
    public partial class AdminSetting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }
        protected void Bind()
        {
            Model.Admin admin1 = new Model.Admin();
            BLL.AdminManager admin2 = new BLL.AdminManager();
            GridView1.DataSource = admin2.GetList();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Model.Admin admin1 = new Model.Admin();
            BLL.AdminManager admin2 = new BLL.AdminManager();
            int adminID = Convert.ToInt32((GridView1.Rows[e.RowIndex].FindControl("LabelID") as Label).Text);
            bool bo = admin2.Delete(adminID);
            if (bo == true)
            {
                Bind();
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Bind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Model.Question question1 = new Model.Question();
            //BLL.QuestionManager question2 = new BLL.QuestionManager();
            //question1.questionID = Convert.ToInt32((GridView1.Rows[e.RowIndex].FindControl("LabelquestionID") as Label).Text);
            //question1.question = (GridView1.Rows[e.RowIndex].FindControl("txbQuestion") as TextBox).Text.ToString();
            //question1.solution = (GridView1.Rows[e.RowIndex].FindControl("txbSolution") as TextBox).Text.ToString();
            //bool bo = question2.Update(question1);
            //GridView1.EditIndex = -1;
            //Bind();
            Model.Admin admin1 = new Model.Admin();
            BLL.AdminManager admin2 = new BLL.AdminManager();
            admin1.ID=Convert.ToInt32((GridView1.Rows[e.RowIndex].FindControl("LabelID") as Label).Text);
            // admin1.permission = (GridView1.DataKeys[e.RowIndex].Values[3].ToString());
           admin1.permission = (GridView1.Rows[e.RowIndex].FindControl("txbpermission") as TextBox).Text.ToString();
            bool bo = admin2.Update(admin1);
            GridView1.EditIndex = -1;
            Bind();
        }
    }
}