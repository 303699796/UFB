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
namespace UFB.Web.Reply
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
					int replyID=(Convert.ToInt32(strid));
					ShowInfo(replyID);
				}
			}
		}
		
	private void ShowInfo(int replyID)
	{
		UFB.BLL.ReplyManager bll=new UFB.BLL.ReplyManager();
		UFB.Model.Reply model=bll.GetModel(replyID);
		this.lblreplyID.Text=model.replyID.ToString();
		this.lblfeedbackID.Text=model.feedbackID.ToString();
		this.lblreplier.Text=model.replier;
		this.lblreplyText.Text=model.replyText;
		this.lblreplyTime.Text=model.replyTime.ToString();
		this.lblnumber.Text=model.number.ToString();
		this.lblisRead.Text=model.isRead;

	}


    }
}
