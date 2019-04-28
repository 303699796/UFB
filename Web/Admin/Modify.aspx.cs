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
namespace UFB.Web.Admin
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		UFB.BLL.AdminManager bll=new UFB.BLL.AdminManager();
		UFB.Model.Admin model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtadminName.Text=model.adminName;
		this.txtadminPassword.Text=model.adminPassword;
		this.txtdepartment.Text=model.department;
		this.txtjob.Text=model.job;
		this.txtpermission.Text=model.permission;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtadminName.Text.Trim().Length==0)
			{
				strErr+="adminName不能为空！\\n";	
			}
			if(this.txtadminPassword.Text.Trim().Length==0)
			{
				strErr+="adminPassword不能为空！\\n";	
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

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string adminName=this.txtadminName.Text;
			string adminPassword=this.txtadminPassword.Text;
			string department=this.txtdepartment.Text;
			string job=this.txtjob.Text;
			string permission=this.txtpermission.Text;


			UFB.Model.Admin model=new UFB.Model.Admin();
			model.ID=ID;
			model.adminName=adminName;
			model.adminPassword=adminPassword;
			model.department=department;
			model.job=job;
			model.permission=permission;

			UFB.BLL.AdminManager bll=new UFB.BLL.AdminManager();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
