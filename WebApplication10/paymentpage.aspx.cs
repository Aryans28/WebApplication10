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
    public partial class paymentpage : System.Web.UI.Page
    {

        concls objj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string ss = "select sum(totalprice) from billtab where userid=" + Session["uid"] + "";
                Session["tt"] = objj.Fun_scalar(ss);
                Label2.Text = Session["tt"].ToString();
                //string sel1 = "select totalprice from billtab where userid=" + Session["uid"] + "and billstatus ='ordered'";
                //Session["tot"] = obb.Fun_scalar(sel1);

                //Label2.Text = Session["tot"].ToString();
            }








            string su_m = "select   sum (totalprice) from otb";
            Session["tt"] = objj.Fun_scalar(su_m);
            Label2.Text = Session["tt"].ToString();
            string totalPriceResult = objj.Fun_scalar(su_m);


            int totalPrice = 0;
            if (!string.IsNullOrEmpty(totalPriceResult))
            {
                totalPrice = Convert.ToInt32(totalPriceResult);
            }

            Label2.Text = "Total Price: " + totalPrice.ToString();



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            balanceref.ServiceClient obj = new balanceref.ServiceClient();
            decimal acc_bal = obj.balancecheck(Convert.ToInt32(Session["uid"]));
            decimal gtotal = Convert.ToDecimal(Session["tt"]);
            if (acc_bal >= gtotal)
            {

                decimal newbalance = acc_bal - gtotal;
                string qry = "update account set balamount = " + newbalance + " where userid = " + Session["uid"] + "";
                int i = objj.Fun_Non_Query(qry);
                string ss = "update billtab set billstatus = 'Paid' where userid = " + Session["uid"] + "";
                int j = objj.Fun_Non_Query(ss);
                string s1 = "update otb set orderstatus = 'Paid' where userid = " + Session["uid"] + " ";

                int j1 = objj.Fun_Non_Query(s1);

                List<int> productid = new List<int>();
                List<int> productquanity = new List<int>();
                string s3 = "select productid,productquanity from otb where userid = " + Session["uid"] + " and orderstatus = 'Paid'";
                SqlDataReader dr = objj.Fn_reader(s3);
                while (dr.Read())
                {
                    productid.Add(Convert.ToInt32(dr["productid"]));
                    productquanity.Add(Convert.ToInt32(dr["productquanity"]));


                    Response.Redirect("orderplace.aspx");
                }
            }
        }

    }
}
        

//                string sel = "select orderid from otb where userid=" + Session["uid"] + "and orderstatus='ordered'";

//                    List<int> oils = new List<int>();

//                    Label1.Visible = true;

//                    Label1.Text = "Successfully Paid";
//                    SqlDataReader dr2 = objj.Fn_reader(sel);
//                    while (dr2.Read())
//                    {
//                        oils.Add(Convert.ToInt32(dr2["orderid"]));
//                    }

//                    foreach (int k in oils)
//                    {
//                        string up1 = "update otb set orderstatus ='paid' where orderid=" + k + "";

//                        objj.Fun_Non_Query(up1);
//                    }

//                    string sel1 = "select max(billid) from billtab where userid=" + Session["uid"] + "";
//                    string bid = objj.Fun_scalar(sel1);
//                    string up2 = "update billtab set billstatus='Paid' where billid=" + bid + "";
//                    objj.Fun_Non_Query(up2);

//                    string sel2 = "select productid from otb where orderstatus='Paid' and userid=" + Session["uid"] + "";
//                    List<int> plis = new List<int>();
//                    SqlDataReader dr = objj.Fn_reader(sel2);
//                    while (dr.Read())
//                    {
//                        plis.Add(Convert.ToInt32(dr["productid"]));
//                    }

//                    foreach (int j in plis)
//                    {
//                        string sel3 = "SELECT dbo.prtb.productstock,dbo.otb.productquanity from dbo.prtb inner join dbo.otb on dbo.prtb .proudctid=dbo.otb .productid";

//                        SqlDataReader dr1 = objj.Fn_reader(sel3);
//                        decimal ps = 0;
//                        decimal qua = 0;
//                        while (dr1.Read())
//                        {
//                            ps = Convert.ToDecimal(dr1["productstock"]);
//                            qua = Convert.ToDecimal(dr1["productquanity"]);

//                        }
//                        qua = Convert.ToDecimal(dr1["productquanity"]);

//                        decimal newst = ps - qua;
//                        string newpst = newst.ToString();
//                        string up3 = "update prtb set productstock=" + newpst + " where productid=" + j + "";
//                        int k = objj.Fun_Non_Query(up3);
//                        if (k == 1)
//                        {
//                            Label1.Visible = true;

//                            Label1.Text = "Successfully Paid";
//                        }
//                    }

//                }
//            }
//            else
//            {
//                Label1.Visible = true;

//                Label1.Text = "insufficient balance";

//                string sel4 = "select max(accid) from account where userid=" + Session["uid"] + "";
//                string maid = objj.Fun_scalar(sel4);
//                int aid = Convert.ToInt32(maid);
//                decimal newbal = bal - gt;
//                string up = "update account set status='Deactive' where accid=" + aid + "";
//                int i = objj.Fun_Non_Query(up);

//                string sel = "select orderid from otb where userid=" + Session["uid"] + " and orderstatus='Ordered'";
//                List<int> oils = new List<int>();
//                SqlDataReader dr2 = objj.Fn_reader(sel);
//                while (dr2.Read())
//                {
//                    oils.Add(Convert.ToInt32(dr2["orderid"]));
//                }
//                foreach (int k in oils)
//                {
//                    string up1 = "update otb set orderstatus='Cancelled' where orderid=" + k + "";
//                    objj.Fun_Non_Query(up1);

//                }

//                string sel1 = "select max(billid) from billtab where userid=" + Session["uid"] + "";
//                string bi = objj.Fun_scalar(sel1);
//                string up2 = "update billtab set billstatus='Failed' where billid=" + bi + "";
//                objj.Fun_Non_Query(up2);
//            }

//        }
//    }
//}
    