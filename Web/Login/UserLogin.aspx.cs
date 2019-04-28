using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UFB.Web.Login
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_submit_Click(object sender, EventArgs e)
        {
            BLL.UsersManager bllusersManager = new BLL.UsersManager();
           // string strWhere "username ='" + txbUserName.Text.Trim() + "'and password='" + txbPassword.Text "'";
            string strWhere = "username='" + txbUserName.Text.Trim() + "'and password='" + txbPassword.Text + "'";
            DataSet ds = bllusersManager.GetList(strWhere);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["username"] = txbUserName.Text.Trim();
                Session["password"] = ds.Tables[0].Rows[0]["userid"].ToString();
                Response.Redirect("~/Default.aspx");
                   return;
            }
            else
            {
                Response.Write("<script language=javascript>alert('用户名不存在或密码错误！');location.href='UserLogin.aspx'</script>");
                Response.End();
            }


            //BLL.AdminManager blladminManager = new BLL.AdminManager();
            //string strWhere = "adminName='" + txbUserName.Text.Trim() + "' and adminPassword='" + txbPassword.Text + "'";
            //DataSet ds = blladminManager.GetList(strWhere);
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    Session["adminName"] = txbUserName.Text.Trim();
            //    Session["adminPassword"] = ds.Tables[0].Rows[0]["ID"].ToString();
            //    Response.Redirect("~/Default.aspx");
            //    return;
            //}
            //else
            //{
            //    Response.Write("<script language=javascript>alert('用户名不存在或密码错误！');location.href='Login.aspx'</script>");
            //    Response.End();
            //}
        }
    }
}