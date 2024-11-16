using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class log : System.Web.UI.Page
    {
        concls con = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string a = "select count (regid) from logtb where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            string cid = con.Fun_scalar(a);
            if (cid == "1")
            {

                string b = "select regid from logtb where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string regid = con.Fun_scalar(b);
                Session["userid"] = regid;

                string c = "select logintype from logtb where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string logintype = con.Fun_scalar(c);
                if (logintype == "admin")
                {
                    Label3.Text = "admin";
                    Response.Redirect("adminhome.aspx");

                }
                else if (logintype == "user")
                {
                    Label3.Text = "user";
                    Response.Redirect("userhome.aspx");

                }
                else
                {
                    Label3.Text = "invalid username and password";
                }


            }
        }
    }
}