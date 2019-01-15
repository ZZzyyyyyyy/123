using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _123
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { // first time page is visited
                ViewState["count"] = 0;
            }
            int count = (int)ViewState["count"];    // GET
            count++;
            Label1.Text = count.ToString();
            ViewState["count"] = count;              // SET
        }
    }
}