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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ApplyID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ApplyID);
				}
			}
		}
			
	private void ShowInfo(int ApplyID)
	{
		UFB.BLL.Apply_MessageManager bll=new UFB.BLL.Apply_MessageManager();
		UFB.Model.Apply_Message model=bll.GetModel(ApplyID);
		this.lblApplyID.Text=model.ApplyID.ToString();
		this.txtname.Text=model.name;
		this.txtdepartment.Text=model.department;
		this.txtjob.Text=model.job;
		this.txtpermission.Text=model.permission;
		this.txtapplyState.Text=model.applyState;
		this.txtisRead.Text=model.isRead;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int ApplyID=int.Parse(this.lblApplyID.Text);
			string name=this.txtname.Text;
			string department=this.txtdepartment.Text;
			string job=this.txtjob.Text;
			string permission=this.txtpermission.Text;
			string applyState=this.txtapplyState.Text;
			string isRead=this.txtisRead.Text;


			UFB.Model.Apply_Message model=new UFB.Model.Apply_Message();
			model.ApplyID=ApplyID;
			model.name=name;
			model.department=department;
			model.job=job;
			model.permission=permission;
			model.applyState=applyState;
			model.isRead=isRead;

			UFB.BLL.Apply_MessageManager bll=new UFB.BLL.Apply_MessageManager();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
