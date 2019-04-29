using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UFB.Web.Login
{
    public partial class AdminRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            Model.Apply_Message apply_Message = new Model.Apply_Message();
            apply_Message.name = txbUserName.Text;
            apply_Message.department = txbDepartment.Text;
            apply_Message.job = txbJob.Text;
            apply_Message.permission = DropDownListPermission.SelectedItem.Text;
            apply_Message.isRead = "0";

            BLL.Apply_MessageManager apply_Message1 = new BLL.Apply_MessageManager();
            bool bo = apply_Message1.Add(apply_Message);
            if (bo == true)
            {
                Response.Write("<script language=javascript>alert('申请成功！请耐心等待管理员同意')</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('申请失败！请重试')");
            }
            
            //Model.Users users = new Model.Users();
            //users.userName = txbUserName.Text;
            //users.password = txbPassword1.Text;
            //users.gender = DropDownList1.SelectedItem.Text;
            //string date = DropDownListYear.SelectedItem.Text.Trim().ToString() + "/" + DropDownListMonth.SelectedItem.Text.Trim().ToString() + "/" + DropDownListDay.SelectedItem.Text.Trim().ToString();
            //DateTime time = Convert.ToDateTime(date);
            //users.birthDate = time;
            //BLL.UsersManager users1 = new UsersManager();
            //bool bo = users1.Add(users);
            //if (bo == true)
            //{
            //    Response.Redirect("~/Default.aspx");
            //}
            //else
            //{
            //    Response.Write("<script language=javascript>alert('注册失败！')");
            //}

        }
    }
}