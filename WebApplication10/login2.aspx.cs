using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class login2 : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
            
        //    string a = "select count (regid) from logtb where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
        //    string cid = obj.Fun_scalar(a);
        //    int cid1 = Convert.ToInt32(cid);
        //    if (cid1 ==1)
        //    {
           
        //    string b = "select regid from logtb where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
        //    string regid = obj.Fun_scalar(b);
        //    Session["userid"] = regid;
              
        //        string c = "select logintype from logtb where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
        //    string logintype = obj.Fun_scalar(c);
        //    if (logintype == "admin")
        //    {
        //        Label1.Text = "admin";
        //            Response.Redirect("adminhome.aspx");

        //        }
        //        else if (logintype == "user")
        //    {
        //        Label1.Text = "user";
        //            Response.Redirect("userhomenew.aspx");

        //        }
        //        else
        //        {
        //            Label3.Text = "invalid username and password";
        //        }


        //    }
        //}

        protected void Button1_Click1(object sender, EventArgs e)
        {

            string a = "select count (regid) from logtb where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            string cid = obj.Fun_scalar(a);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {

                string b = "select regid from logtb where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string regid2 = obj.Fun_scalar(b);
                Session["uid"] = regid2;

                string c = "select logintype from logtb where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string logintype = obj.Fun_scalar(c);
                if (logintype == "admin")
                {
                    Label1.Text = "admin";
                    Response.Redirect("adminhome.aspx");

                }
                else if (logintype == "user")
                {
                    Label1.Text = "user";
                    Response.Redirect("userhomenew.aspx");

                }
                else
                {
                    Label3.Text = "invalid username and password";
                }


            }
        }

    }
}
