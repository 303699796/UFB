using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UFB.Web.setting
{
    public partial class CategorySetting : System.Web.UI.Page
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

            //Model.Question question1 = new Model.Question();
            //BLL.QuestionManager question2 = new BLL.QuestionManager();
            //GridView1.DataSource = question2.GetAllList();
            //GridView1.DataBind();
            Model.Category category1 = new Model.Category();
            BLL.CategoryManager category2 = new BLL.CategoryManager();
            GridView1.DataSource = category2.GetAllList();
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Model.Question question3 = new Model.Question();
            //BLL.QuestionManager question4 = new BLL.QuestionManager();
            //int QuestionID = Convert.ToInt32((GridView1.Rows[e.RowIndex].FindControl("LabelquestionID") as Label).Text);
            //bool bo = question4.Delete(QuestionID);
            //if (bo == true)
            //{
            //    Bind();
            //}
            Model.Category category3 = new Model.Category();
            BLL.CategoryManager category4 = new BLL.CategoryManager();
            string categoryID=Convert .ToString((GridView1.Rows[e.RowIndex].FindControl("txbCategory") as TextBox).Text);
            bool bo = category4.Delete(categoryID);
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

        }
    }
}