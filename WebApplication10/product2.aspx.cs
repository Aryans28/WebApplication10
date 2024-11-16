using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication10
{
    public partial class product2 : System.Web.UI.Page
    {
        concls con = new concls();




        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s = "select * from prtb where categoryid=" + Session["cateid"] + "";
                DataSet ds = con.Fn_dataset(s);
                DataList1.DataSource = ds; 
                DataList1.DataBind();
            }


        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int cid = Convert.ToInt32(e.CommandArgument);
            Session["proid"] = cid;
            Response.Redirect("productview.aspx");
        }
    }
    }