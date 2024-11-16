using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

namespace WebApplication10
{
    public partial class viewfeedback : System.Web.UI.Page
    {
        concls con = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                gridbindfun();
            }
        }

        public void gridbindfun()
        {
            string feed = "select * from feedbk where fstatus = 0";
            DataSet ds = con.Fn_dataset(feed);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            GridView1.DataBind();
              
            }




        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            Session["uid"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("replyfeedback.aspx");
        }
        
        }
    }
        
    