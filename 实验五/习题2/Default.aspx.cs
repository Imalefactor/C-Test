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
        Session.Timeout = 1;    //设置Session对象保存数据的有效时间，默认单位为分钟
        if (Session["Number"] != null)
        {
            Session["Number"] = (int)Session["Number"] + 1;
        }
        else
        {
            Session["Number"] = 1;
        }
        string s = Session["Number"].ToString();
        Label1.Text = "这是你第" + s + "个访问网页的人";
    }
}