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
    public partial class billview : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            if (!IsPostBack)
            {
                string ins = "select username,useraddress,userphone from utab where userid=" + Session["uid"] + "";
                SqlDataReader dr = obj.Fn_reader(ins);
                while (dr.Read())
                {
                    Label7.Text = dr["username"].ToString();
                    Label8.Text = dr["useraddress"].ToString();

                    Label9.Text = dr["userphone"].ToString();


                }


                string pr = "select p.productimage, p.productname,p.productprice, o.productquanity,o.productsize, o.totalprice from prtb p join otb o on o.productid=p.productid where o.userid=" + Session["uid"] + "";
                DataList1.DataSource = obj.Fn_reader(pr);
                DataList1.DataBind();


                string su_m = "select   sum (totalprice) from otb";

                string totalPriceResult = obj.Fun_scalar(su_m);


                int totalPrice = 0;
                if (!string.IsNullOrEmpty(totalPriceResult))
                {
                    totalPrice = Convert.ToInt32(totalPriceResult);
                }

                Label4.Text = "Total Price: " + totalPrice.ToString();
            }
        }
        



        protected void Button3_Click(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_aaaa";
            cmd.Parameters.AddWithValue("@uid", Session["uid"]);

            cmd.Parameters.AddWithValue("@accno", TextBox2.Text);
            cmd.Parameters.AddWithValue("@acctyp", TextBox1.Text);
            cmd.Parameters.AddWithValue("@accbal", TextBox3.Text);
            cmd.Parameters.AddWithValue("@acst", "active");




            SqlParameter sp = new SqlParameter();
            sp.DbType = DbType.Int32;
            sp.ParameterName = "@st";
            sp.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(sp);
            obj.Fun_Non_Querywithsp(cmd);
            int outpu = Convert.ToInt32(sp.Value);
            if (outpu == 1)
            {
                Response.Redirect("paymentpage.aspx");
            }
        }
    }
}

//    string su_m = "select   sum (totalprice) from otb";

//    string totalPriceResult = obj.Fun_scalar(su_m);


//    int totalPrice = 0;
//    if (!string.IsNullOrEmpty(totalPriceResult))
//    {
//        totalPrice = Convert.ToInt32(totalPriceResult);
//    }

//    Label4.Text = "Total Price: " + totalPrice.ToString();
//}