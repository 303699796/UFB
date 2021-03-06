﻿using System;
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
namespace UFB.Web.Question
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
					int questionID=(Convert.ToInt32(strid));
					ShowInfo(questionID);
				}
			}
		}
		
	private void ShowInfo(int questionID)
	{
		UFB.BLL.QuestionManager bll=new UFB.BLL.QuestionManager();
		UFB.Model.Question model=bll.GetModel(questionID);
		this.lblquestionID.Text=model.questionID.ToString();
		this.lblcategory.Text=model.category;
		this.lblquestion.Text=model.question;
		this.lblsolution.Text=model.solution;
		this.lbltime.Text=model.time.ToString();

	}


    }
}
