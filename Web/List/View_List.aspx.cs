using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UFB.Web.List
{
    public partial class View_List : System.Web.UI.Page
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

            Model.Feedback feedback1 = new Model.Feedback();
            BLL.FeedbackManager feedback2 = new BLL.FeedbackManager();
            GridView1.DataSource = feedback2.GetAllList();
            GridView1.DataBind();


        }

        protected void btn_Dealwith_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Invalid_Click(object sender, EventArgs e)
        {

        }

       

       

        protected void btn_End_Click(object sender, EventArgs e)
        {
            Calendar_End.Visible = true;
        }

        protected void btn_Star_Click(object sender, EventArgs e)
        {
            Calendar_Star.Visible = true;
            
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            string DateTime = this.Calendar_Star.SelectedDate.ToString();
            this.txbStar.Text = DateTime;
            this.Calendar_Star.Visible = false;
        }

        protected void Calendar_End_SelectionChanged(object sender, EventArgs e)
        {
            string DateTime = this.Calendar_End.SelectedDate.ToString();
            this.txbEnd.Text = DateTime;
            this.Calendar_End.Visible = false;
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

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
    }
}