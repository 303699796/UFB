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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			int feedbackID=int.Parse(this.txtfeedbackID.Text);
			string replier=this.txtreplier.Text;
			string replyText=this.txtreplyText.Text;
			DateTime replyTime=DateTime.Parse(this.txtreplyTime.Text);
			int number=int.Parse(this.txtnumber.Text);
			string isRead=this.txtisRead.Text;

			UFB.Model.Reply model=new UFB.Model.Reply();
			model.feedbackID=feedbackID;
			model.replier=replier;
			model.replyText=replyText;
			model.replyTime=replyTime;
			model.number=number;
			model.isRead=isRead;

			UFB.BLL.ReplyManager bll=new UFB.BLL.ReplyManager();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
