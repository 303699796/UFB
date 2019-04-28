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
namespace UFB.Web.Feedback
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int feedbackID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(feedbackID);
				}
			}
		}
			
	private void ShowInfo(int feedbackID)
	{
		UFB.BLL.FeedbackManager bll=new UFB.BLL.FeedbackManager();
		UFB.Model.Feedback model=bll.GetModel(feedbackID);
		this.lblfeedbackID.Text=model.feedbackID.ToString();
		this.txtUserID.Text=model.UserID.ToString();
		this.txtfeedbackTime.Text=model.feedbackTime.ToString();
		this.txtcategory.Text=model.category;
		this.txtInfo.Text=model.Info;
		this.txtcontact.Text=model.contact;
		this.txtimage.Text=model.image;
		this.txtisInvalid.Text=model.isInvalid;
		this.txtsolutionState.Text=model.solutionState;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUserID.Text))
			{
				strErr+="UserID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtfeedbackTime.Text))
			{
				strErr+="feedbackTime格式错误！\\n";	
			}
			if(this.txtcategory.Text.Trim().Length==0)
			{
				strErr+="category不能为空！\\n";	
			}
			if(this.txtInfo.Text.Trim().Length==0)
			{
				strErr+="Info不能为空！\\n";	
			}
			if(this.txtcontact.Text.Trim().Length==0)
			{
				strErr+="contact不能为空！\\n";	
			}
			if(this.txtimage.Text.Trim().Length==0)
			{
				strErr+="image不能为空！\\n";	
			}
			if(this.txtisInvalid.Text.Trim().Length==0)
			{
				strErr+="isInvalid不能为空！\\n";	
			}
			if(this.txtsolutionState.Text.Trim().Length==0)
			{
				strErr+="solutionState不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int feedbackID=int.Parse(this.lblfeedbackID.Text);
			int UserID=int.Parse(this.txtUserID.Text);
			DateTime feedbackTime=DateTime.Parse(this.txtfeedbackTime.Text);
			string category=this.txtcategory.Text;
			string Info=this.txtInfo.Text;
			string contact=this.txtcontact.Text;
			string image=this.txtimage.Text;
			string isInvalid=this.txtisInvalid.Text;
			string solutionState=this.txtsolutionState.Text;


			UFB.Model.Feedback model=new UFB.Model.Feedback();
			model.feedbackID=feedbackID;
			model.UserID=UserID;
			model.feedbackTime=feedbackTime;
			model.category=category;
			model.Info=Info;
			model.contact=contact;
			model.image=image;
			model.isInvalid=isInvalid;
			model.solutionState=solutionState;

			UFB.BLL.FeedbackManager bll=new UFB.BLL.FeedbackManager();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
