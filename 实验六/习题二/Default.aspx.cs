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
            HttpCookie cookie = Request.Cookies["Name"];
            if (cookie == null)
            {
                Label2.Text = "欢迎,登录网站";
            }
            else
            {
                Label2.Text = "欢迎"+cookie.Values["Name"]+"登录网站";
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["Name"];
        if (cookie == null)
        {
            cookie = new HttpCookie("Name");
        }
        cookie.Values["Name"] = this.TextBox1.Text.ToString();
        cookie.Expires = DateTime.Now.AddMinutes(1);
        Response.Cookies.Add(cookie);
    }
}