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
namespace UFB.Web.Category
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
					string category= strid;
					ShowInfo(category);
				}
			}
		}
		
	private void ShowInfo(string category)
	{
		UFB.BLL.CategoryManager bll=new UFB.BLL.CategoryManager();
		UFB.Model.Category model=bll.GetModel(category);
		this.lblcategory.Text=model.category;
		this.lbltime.Text=model.time.ToString();

	}


    }
}
