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
    public partial class userhomenew : System.Web.UI.Page
    {
       
        concls con=new concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)

            {

                DataList1.DataSource = con.categories();
                DataList1.DataBind();
            }
        }
          

        protected void ImageButton1_Command1(object sender, CommandEventArgs e)
        {
            int cid = Convert.ToInt32(e.CommandArgument);
        
            Session["cateid"] = cid;
            Response.Redirect("product2.aspx");
        }
    }
}