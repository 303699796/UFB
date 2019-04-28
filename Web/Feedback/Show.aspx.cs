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
namespace UFB.Web.Feedback
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
					int feedbackID=(Convert.ToInt32(strid));
					ShowInfo(feedbackID);
				}
			}
		}
		
	private void ShowInfo(int feedbackID)
	{
		UFB.BLL.FeedbackManager bll=new UFB.BLL.FeedbackManager();
		UFB.Model.Feedback model=bll.GetModel(feedbackID);
		this.lblfeedbackID.Text=model.feedbackID.ToString();
		this.lblUserID.Text=model.UserID.ToString();
		this.lblfeedbackTime.Text=model.feedbackTime.ToString();
		this.lblcategory.Text=model.category;
		this.lblInfo.Text=model.Info;
		this.lblcontact.Text=model.contact;
		this.lblimage.Text=model.image;
		this.lblisInvalid.Text=model.isInvalid;
		this.lblsolutionState.Text=model.solutionState;

	}


    }
}
