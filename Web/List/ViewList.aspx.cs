using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UFB.Web.List
{
    public partial class ViewList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Dealwith_Click(object sender, EventArgs e)
        {
            BLL.FeedbackManager feedbackManager = new BLL.FeedbackManager();
            Model.Feedback modelFeedback = new Model.Feedback();
        
            modelFeedback.solutionState = "已解决";
            if(feedbackManager.Update(modelFeedback))
            {
                Response.Write("~/Index.aspx");
            }

          
        }

        protected void btn_Invalid_Click(object sender, EventArgs e)
        {
    
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}