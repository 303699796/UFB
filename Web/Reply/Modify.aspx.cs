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
namespace UFB.Web.Reply
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int replyID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(replyID);
				}
			}
		}
			
	private void ShowInfo(int replyID)
	{
		UFB.BLL.ReplyManager bll=new UFB.BLL.ReplyManager();
		UFB.Model.Reply model=bll.GetModel(replyID);
		this.lblreplyID.Text=model.replyID.ToString();
		this.txtfeedbackID.Text=model.feedbackID.ToString();
		this.txtreplier.Text=model.replier;
		this.txtreplyText.Text=model.replyText;
		this.txtreplyTime.Text=model.replyTime.ToString();
		this.txtnumber.Text=model.number.ToString();
		this.txtisRead.Text=model.isRead;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtfeedbackID.Text))
			{
				strErr+="feedbackID格式错误！\\n";	
			}
			if(this.txtreplier.Text.Trim().Length==0)
			{
				strErr+="replier不能为空！\\n";	
			}
			if(this.txtreplyText.Text.Trim().Length==0)
			{
				strErr+="replyText不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtreplyTime.Text))
			{
				strErr+="replyTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtnumber.Text))
			{
				strErr+="number格式错误！\\n";	
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
			int replyID=int.Parse(this.lblreplyID.Text);
			int feedbackID=int.Parse(this.txtfeedbackID.Text);
			string replier=this.txtreplier.Text;
			string replyText=this.txtreplyText.Text;
			DateTime replyTime=DateTime.Parse(this.txtreplyTime.Text);
			int number=int.Parse(this.txtnumber.Text);
			string isRead=this.txtisRead.Text;


			UFB.Model.Reply model=new UFB.Model.Reply();
			model.replyID=replyID;
			model.feedbackID=feedbackID;
			model.replier=replier;
			model.replyText=replyText;
			model.replyTime=replyTime;
			model.number=number;
			model.isRead=isRead;

			UFB.BLL.ReplyManager bll=new UFB.BLL.ReplyManager();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
