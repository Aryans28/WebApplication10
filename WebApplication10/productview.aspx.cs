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
    public partial class productview : System.Web.UI.Page
    {
        concls obj1 = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

            Label6.Visible = true;
            if (!IsPostBack)

            {
                string s = "select * from prtb  where productid=" + Session["proid"] + "";

                SqlDataReader dr = obj1.Fn_reader(s);
                while (dr.Read())
                {

                    Image1.ImageUrl = dr["productimage"].ToString();
                    Label1.Text = dr["productname"].ToString();
                    Label2.Text = dr["productdescription"].ToString();
                    Label3.Text = dr["productprice"].ToString();

                }

            }

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(cartid) from ctbbb";
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
            string c = "insert into ctbbb values ( " + regid3 + "," + Session["uid"] + "," + Session["proid"] + "," + DropDownList1.SelectedItem.Value + ",'" + RadioButtonList1.SelectedItem.Text + "'," + tprice + ")";

            int i = obj1.Fun_Non_Query(c);


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("cartview.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            //            string a = "select sum(totalprice) from ctbbb where userid=" + Session["uid"] + "";
            //            int gtotal = obj1.Fun_Non_Query(a);




            //            string inss = "insert into billtab values(" + Session["uid"] + "," + gtotal + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "','initiated')";
            //            int c = obj1.Fun_Non_Query(inss);
            //            if (c > 0)
            //            {





            //                string currentDate = DateTime.Now.ToString("yyyy-MM-dd"); 

            //                string ins = "INSERT INTO otb (userid, productid, productquanity,productsize, totalprice, date, orderstatus) " +
            //                             "SELECT c.userid, c.productid, c.productquanity,c.productsize, c.totalprice, '" + currentDate + "', 'ordered' " +
            //                             "FROM ctbbb c WHERE c.userid = " + Convert.ToInt32(Session["uid"]);





            //                int ii = obj1.Fun_Non_Query(ins); 


            //                if (ii > 0)
            //                {
            //                    string del = "delete from ctbbb where  userid=" + Session["uid"] + "";
            //                    int iii = obj1.Fun_Non_Query(del);
            //                    if (iii > 0)
            //                    {
            //                        Response.Redirect("billview.aspx");
            //                    }
            //                }
            //            }

            //        }
            //    }
            //}

            
            string a = "select sum(totalprice) from ctbbb where userid=" + Session["uid"] + "";
            object gtotalObj = obj1.Fun_scalar(a);  
            int gtotal = 0;

            if (gtotalObj != null && gtotalObj != DBNull.Value)
            {
                gtotal = Convert.ToInt32(gtotalObj);  
            }

           
            string inss = "insert into billtab values(" + Session["uid"] + "," + gtotal + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "','initiated')";
            int c = obj1.Fun_Non_Query(inss);

            if (c > 0)
            {
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

                string ins = "INSERT INTO otb (userid, productid, productquanity, productsize, totalprice, date, orderstatus) " +
                             "SELECT c.userid, c.productid, c.productquanity, c.productsize, c.totalprice, '" + currentDate + "', 'ordered' " +
                             "FROM ctbbb c WHERE c.userid = " + Convert.ToInt32(Session["uid"]);

                int ii = obj1.Fun_Non_Query(ins);

                if (ii > 0)
                {
                    string del = "delete from ctbbb where userid=" + Session["uid"] + "";
                    int iii = obj1.Fun_Non_Query(del);
                    if (iii > 0)
                    {
                        Response.Redirect("billview.aspx");
                    }
                }
            }
        }
    }
}



















//// Assuming you want to insert the current date in the 'date' column
//string s = "select * from ordertab where userid=" + Session["uid"] + "";
//SqlDataReader dr1 = obj1.Fn_reader(s);
//int pid = 0;
//int quanity = 0;
//int tprice = 0;
//while (dr1.Read())
//{
//    pid = (int)dr1["productid"];
//    quanity = (int)dr1["productquanity"];
//    tprice = (int)dr1["totalprice"];
//}
//dr1.Close();
//string dt = DateTime.Now.ToString("yyyy-MM-dd");
//string ins = "insert into ordertab values(" + Session["uid"] + "," + pid + "," + quanity + "," + tprice + ",'" + dt + "','ordered')";


//string ca = "select cartid from ctb where userid=" + Session["uid"] + "";
//List<int> listcart = new List<int>();
//SqlDataReader dr = obj1.Fn_reader(ca);
//while(dr.Read())
//{
//    listcart.Add ((int)dr["cartid"]);
//}



//foreach(int i  in listcart)
//{
//string s = "select * from ctb where cartid=" + i + "and userid=" + Session["uid"] + "";
//SqlDataReader dr1 = obj1.Fn_reader(s);
//int pid = 0;
//int quanity = 0;
//int tprice = 0;
//while (dr1.Read())
//{
//    pid = (int)dr1["productid"];
//    quanity = (int)dr1["productquanity"];
//    tprice = (int)dr1["totalprice"];
//}
//string dt = DateTime.Now.ToString("yyyy-MM-dd");
//string ins = "insert into ordertab values(" + Session["uid"] + "," + pid + "," + quanity + "," + tprice + ",'" + dt + "','order')";



//string tt = "select sum(totalprice) from ctb where userid=" + Session["uid"] + "";
//string gtotal = obj1.Fun_scalar(tt);





