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
namespace UFB.Web.Admin
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		UFB.BLL.AdminManager bll=new UFB.BLL.AdminManager();
		UFB.Model.Admin model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lbladminName.Text=model.adminName;
		this.lbladminPassword.Text=model.adminPassword;
		this.lbldepartment.Text=model.department;
		this.lbljob.Text=model.job;
		this.lblpermission.Text=model.permission;

	}


    }
}
