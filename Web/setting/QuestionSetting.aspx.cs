using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UFB.Web.setting
{
    public partial class QuestionSetting : System.Web.UI.Page
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
            //Model.Admin admin1 = new Model.Admin();
            //BLL.AdminManager admin2 = new BLL.AdminManager();
            //GridView1.DataSource = admin2.GetList();
            //GridView1.DataBind();
            Model.Question question1 = new Model.Question();
            BLL.QuestionManager question2 = new BLL.QuestionManager();
            GridView1.DataSource = question2.GetAllList();
            GridView1.DataBind();

        }
    

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Model.Admin admin1 = new Model.Admin();
            //BLL.AdminManager admin2 = new BLL.AdminManager();
            //int adminID = Convert.ToInt32((GridView1.Rows[e.RowIndex].FindControl("Label1") as Label).Text);

            //bool bo = admin2.Delete(adminID);
            //if (bo == true)
            //{
            //    Bind();
            //}
            Model.Question question3 = new Model.Question();
            BLL.QuestionManager question4 = new BLL.QuestionManager();
            int QuestionID = Convert.ToInt32((GridView1.Rows[e.RowIndex].FindControl("Label1") as Label).Text);
            bool bo = question4.Delete(QuestionID);
            if (bo==true)
            {
                Bind();
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}