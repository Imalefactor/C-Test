using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Application.Lock();
            Application["PageClick"] = (int)Application["PageClick"] + 1;
            Application.UnLock();
            Response.Write(string.Format("页面单击数:{0}<br/>", Application["PageClick"]));
            Response.Write(string.Format("用户访问数:{0}<br/>", Application["UserVisit"]));
        }
    }
}