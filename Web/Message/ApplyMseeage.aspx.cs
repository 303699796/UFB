using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UFB.Web.Message
{
    public partial class ApplyMseeage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgree_Click(object sender, EventArgs e)
        {
  
            Model.Apply_Message apply_Message = new Model.Apply_Message();
            apply_Message.applyState = "已同意";
            BLL.Apply_MessageManager apply_Message1 = new BLL.Apply_MessageManager();
            bool bo = apply_Message1.Update(apply_Message);
            if(bo==true)
            {
                Response.Write("<script language=javascript>alert('申请成功！请耐心等待管理员同意')</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('申请失败！请重试')");
            }

            


        }

        protected void btnRefuse_Click(object sender, EventArgs e)
        {
            //Response.Write("<script language=javascript>alert('用户名不存在或密码错误！');location.href='UserLogin.aspx'</script>");
            //Response.End();
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<script language=javascript>alert('你已拒绝！')</script>");
        }
    }
}