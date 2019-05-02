using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UFB.Web
{
    public partial class WebForm1 : System.Web.UI.Page
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


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("~/Index.aspx");
        }



        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Model.Admin admin1 = new Model.Admin();
            BLL.AdminManager admin2 = new BLL.AdminManager();
            int adminID = Convert.ToInt32((GridView1.Rows[e.RowIndex].FindControl("Label1") as Label).Text);

            bool bo = admin2.Delete(adminID);
            if (bo == true)
            {
                Bind();
            }
            //      Model.Users users = new Model.Users();
            //BLL.UsersManager users1 = new UsersManager();
            //bool bo = users1.Add(users);
            //if (bo == true)
            //{
            //    Response.Redirect("~/Default.aspx");
            //}
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[2].Visible = false;
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
            Model.Admin admin1 = new Model.Admin();
            BLL.AdminManager admin2 = new BLL.AdminManager();
            admin1.ID = Convert.ToInt32((GridView1.Rows[e.RowIndex].FindControl("Label1") as Label).Text);
            admin1.adminName = (GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox).Text.ToString();
            admin1.department = (GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox).Text.ToString();
      

            bool bo = admin2.Update(admin1);
            GridView1.EditIndex = -1;
            Bind();
        }
    }
}