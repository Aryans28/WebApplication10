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
    public partial class profilesingleview : System.Web.UI.Page
    {
        concls obj1 = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {
           
                if (!IsPostBack)

                {
                    string s = "select * from prtb  where productid=" + Session["proid"] + "";

                    SqlDataReader dr = obj1.Fn_reader(s);
                    while (dr.Read())
                    {

                        Image1.ImageUrl = dr["productimage"].ToString();
                        Label2.Text = dr["productname"].ToString();
                        Label4.Text = dr["productdescription"].ToString();
                        Label3.Text = dr["productprice"].ToString();

                    }

                }

            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(cartid) from carttabb";
            string reg_id = obj1.Fun_scalar(sel);
            int regid3 = 0;


            if (reg_id == "")
            {
                regid3 = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(reg_id);
                regid3 = newregid + 1;
            }
            int price = Convert.ToInt32(Label3.Text);

            int tprice = Convert.ToInt32(DropDownList1.SelectedItem.Value) * price;
            string c = "insert into carttabb values ( " + regid3 + "," + Session["uid"] + "," + Session["proid"] + "," + DropDownList1.SelectedItem.Value + "," + tprice + ")";

            int i = obj1.Fun_Non_Query(c);
            if (i == 1)
            {
                Response.Redirect("cart.aspx");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("cartview.aspx");

        }
    }
}

       