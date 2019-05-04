using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UFB.Web.List
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Model.Feedback feedback1 = new Model.Feedback();
            BLL.FeedbackManager feedback2 = new BLL.FeedbackManager();
          

        }
    }
}