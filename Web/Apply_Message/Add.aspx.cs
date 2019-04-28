using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace UFB.Web.Apply_Message
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtdepartment.Text.Trim().Length==0)
			{
				strErr+="department不能为空！\\n";	
			}
			if(this.txtjob.Text.Trim().Length==0)
			{
				strErr+="job不能为空！\\n";	
			}
			if(this.txtpermission.Text.Trim().Length==0)
			{
				strErr+="permission不能为空！\\n";	
			}
			if(this.txtapplyState.Text.Trim().Length==0)
			{
				strErr+="applyState不能为空！\\n";	
			}
			if(this.txtisRead.Text.Trim().Length==0)
			{
				strErr+="isRead不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string name=this.txtname.Text;
			string department=this.txtdepartment.Text;
			string job=this.txtjob.Text;
			string permission=this.txtpermission.Text;
			string applyState=this.txtapplyState.Text;
			string isRead=this.txtisRead.Text;

			UFB.Model.Apply_Message model=new UFB.Model.Apply_Message();
			model.name=name;
			model.department=department;
			model.job=job;
			model.permission=permission;
			model.applyState=applyState;
			model.isRead=isRead;

			UFB.BLL.Apply_MessageManager bll=new UFB.BLL.Apply_MessageManager();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
