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
    public partial class userview : System.Web.UI.Page
    {


        concls con = new concls();
        //SqlConnection con = new SqlConnection(@"server=DESKTOP-656UNUD\SQLEXPRESS;database=projectarya;integrated security=true");
        //        protected void Page_Load(object sender, EventArgs e)
        //        {
        //          if(Session["catid"]!=null)
        //            {
        //                Label3.Text = Session["catid"].ToString();
        //            }

        //                if (!IsPostBack)
        //                {
        //                    bindproducts();
        //                }



        //            }



        //        private void bindproducts()
        //        {



        //            SqlDataAdapter da = new SqlDataAdapter();
        //            DataTable dt = new DataTable();

        //            da.Fill(dt);
        //            DataList1.DataSource = dt;
        //            DataList1.DataBind();




        //        }

        //        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        //        {
        //            string ee = "select categoryimage, categoryname, categorydescription from categorytable where categoryid = " + Session["catid"] + "";
        //            Session["catid"] = ee;
        //            {
        //                Response.Redirect("product2.aspx");
        //            }
        //        }
        //    }
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["catid"] != null)
            {
                Label3.Text = Session["catid"].ToString();
            }
            if (!IsPostBack)
            {
                bindproducts();
            }


        }
        private void bindproducts()
        {
            try
            {
                string query = "SELECT * FROM producttableee WHERE categoryid = @CategoryID";
                using (SqlConnection connection = new SqlConnection(@"server=DESKTOP-656UNUD\SQLEXPRESS;database=projectarya;integrated security=true"))
                {
                    connection.Open(); // Open the connection
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CategoryID",Convert.ToInt32( Session["catid"]));
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        System.Diagnostics.Debug.WriteLine("datacount:" + dt.Rows.Count);
                        DataList1.DataSource = dt;
                        DataList1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                Label3.Text = "Error: " + ex.Message;
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["catid"] != null && int.TryParse(Session["catid"].ToString(), out int catId))
            {
                Response.Redirect("product2.aspx?catid=" + catId);
            }
            else
            {
                Label3.Text = "Category ID is not available.";
            }
        }
    }
}