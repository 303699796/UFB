using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UFB.Web.Login
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_submit_Click(object sender, EventArgs e)
        {

            //string AdminName = txbUserName.Text.Trim();
            //string   AdminPassword =txbPassword.Text;
            //BLL.AdminManager adminManager = new BLL.AdminManager();
            //Model.Admin admin = adminManager.Exists(AdminName,ID);


            //BLL.AdminManager blladminManager = new BLL.AdminManager();
            //string strWhere = "adminname'" + txbUserName.Text.Trim() + "'and adminpassword='" + txbPassword.Text + "'";
            //DataSet da = blladminManager.GetList(strWhere);
            //if (da.Tables[0].Rows.Count > 0)
            //{
            //    Session["adminname"] = txbUserName.Text.Trim();
            //    Session["adminpassword"] = da.Tables[0].Rows[0]["id"].ToString(); ;
            //    Response.Redirect("~/Default.aspx");
            //    return;
            //}
            //else
            //{
            //    Response.Write("<script language=javascript>alert('用户名不存在或密码错误！');location.href='Login.aspx'</script>");
            //    Response.End();
            //}

            BLL.AdminManager adminManager = new BLL.AdminManager();
            string Str = "adminname'" + txbUserName.Text.Trim() + "'and adminpassword='" + txbPassword.Text.Trim() + "'";
            DataSet ds = adminManager.GetList(Str);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["adminname"] = txbUserName.Text.Trim();
                Session["adminpassword"] = ds.Tables[0].Rows[0]["id"].ToString();
                Response.Redirect("~/Default.aspx");
                return;
            }
            else
            {
                Response.Write("<script language=javascript>alert('用户名不存在或密码错误！');location.href='Login.aspx'</script>");
                Response.End();
            }
        }
    }
}