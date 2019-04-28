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
namespace UFB.Web.Category
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string category= Request.Params["id"];
					ShowInfo(category);
				}
			}
		}
			
	private void ShowInfo(string category)
	{
		UFB.BLL.CategoryManager bll=new UFB.BLL.CategoryManager();
		UFB.Model.Category model=bll.GetModel(category);
		this.lblcategory.Text=model.category;
		this.txttime.Text=model.time.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txttime.Text))
			{
				strErr+="time格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string category=this.lblcategory.Text;
			DateTime time=DateTime.Parse(this.txttime.Text);


			UFB.Model.Category model=new UFB.Model.Category();
			model.category=category;
			model.time=time;

			UFB.BLL.CategoryManager bll=new UFB.BLL.CategoryManager();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
