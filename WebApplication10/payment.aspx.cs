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
    public partial class payment : System.Web.UI.Page
    {
        concls obb = new concls();

        protected void Page_Load(object sender, EventArgs e)
        {
        }//{
        //    if (!IsPostBack)
        //    {




        //        string ss = "select totalprice from billtab where userid=" + Session["uid"] + "";
        //        string tt = obb.Fun_scalar(ss);
        //        Label2.Text = tt;
        //        //string sel1 = "select totalprice from billtab where userid=" + Session["uid"] + "and billstatus ='ordered'";
        //        //Session["tot"] = obb.Fun_scalar(sel1);

        //        //Label2.Text = Session["tot"].ToString();
        //    }








        //    string su_m = "select   sum (totalprice) from otb";

        //    string totalPriceResult = obb.Fun_scalar(su_m);


        //    int totalPrice = 0;
        //    if (!string.IsNullOrEmpty(totalPriceResult))
        //    {
        //        totalPrice = Convert.ToInt32(totalPriceResult);
        //    }

        //    Label2.Text = "Total Price: " + totalPrice.ToString();



        //}




        ////protected void Button1_Click(object sender, EventArgs e)
        ////{
        ////    balanacereferences.ServiceClient obj = new balanacereferences.ServiceClient();
        ////    decimal bal = obj.balancecheck(Convert.ToInt32(Session["uid"]));
        ////    decimal gt = Convert.ToDecimal(TextBox1.Text);
        ////    if (bal >= gt)
        ////    {
        ////        string acc = "select max(accid) from account where userid=" + Session["uid"] + "";
        ////        string s = obb.Fun_scalar(acc);
        ////        int a = Convert.ToInt32(s);
        ////        decimal newbal = bal - gt;
        ////        string updte = "update account set balamount=" + newbal + ",status='Deactive' where accid=" + a + "";


        //        int i = obb.Fun_Non_Query(updte);
        //        if (i == 1)
        //        {

        //            string sel = "select orderid from otb where userid=" + Session["uid"] + "and orderstatus='ordered'";

        //            List<int> oils = new List<int>();

        //            Label3.Visible = true;

        //            Label3.Text = "Successfully Paid";
        //            SqlDataReader dr2 = obb.Fn_reader(sel);
        //            while (dr2.Read())
        //            {
        //                oils.Add(Convert.ToInt32(dr2["orderid"]));
        //            }

        //            foreach (int k in oils)
        //            {
        //                string up1 = "update otb set orderstatus ='paid' where orderid=" + k + "";

        //                obb.Fun_Non_Query(up1);
        //            }

        //            string sel1 = "select max(billid) from billtab where userid=" + Session["uid"] + "";
        //            string bid = obb.Fun_scalar(sel1);
        //            string up2 = "update billtab set billstatus='Paid' where billid=" + bid + "";
        //            obb.Fun_Non_Query(up2);

        //            string sel2 = "select productid from otb where orderstatus='Paid' and userid=" + Session["uid"] + "";
        //            List<int> plis = new List<int>();
        //            SqlDataReader dr = obb.Fn_reader(sel2);
        //            while (dr.Read())
        //            {
        //                plis.Add(Convert.ToInt32(dr["Product_Id"]));
        //            }

        //            foreach (int j in plis)
        //            {
        //                string sel3 = "SELECT dbo.prtb.productstock,dbo.otb.productquanity from dbo.prtb inner join dbo.otb on dbo.prtb .proudctid=dbo.otb .productid";

        //                SqlDataReader dr1 = obb.Fn_reader(sel3);
        //                decimal ps = 0;
        //                decimal qua = 0;
        //                while (dr1.Read())
        //                {
        //                    ps = Convert.ToDecimal(dr1["productstock"]);
        //                    qua = Convert.ToDecimal(dr1["productquanity"]);

        //                }
        //                qua = Convert.ToDecimal(dr1["productquanity"]);

        //                decimal newst = ps - qua;
        //                string newpst = newst.ToString();
        //                string up3 = "update prtb set productstock=" + newpst + " where productid=" + j + "";
        //                int k = obb.Fun_Non_Query(up3);
        //                if (k == 1)
        //                {
        //                    Label3.Visible = true;

        //                    Label3.Text = "Successfully Paid";
        //                }
        //            }

        //        }
        //    }
        //    else
        //    {
        //        Label3.Visible = true;

        //        Label3.Text = "insufficient balance";

        //        string sel4 = "select max(accid) from account where userid=" + Session["uid"] + "";
        //        string maid = obb.Fun_scalar(sel4);
        //        int aid = Convert.ToInt32(maid);
        //        decimal newbal = bal - gt;
        //        string up = "update account set status='Deactive' where aid=" + aid + "";
        //        int i = obb.Fun_Non_Query(up);

        //        string sel = "select orderid from otb where userid=" + Session["uid"] + " and orderstatus='Ordered'";
        //        List<int> oils = new List<int>();
        //        SqlDataReader dr2 = obb.Fn_reader(sel);
        //        while (dr2.Read())
        //        {
        //            oils.Add(Convert.ToInt32(dr2["orderid"]));
        //        }
        //        foreach (int k in oils)
        //        {
        //            string up1 = "update otb set orderstatus='Cancelled' where orderid=" + k + "";
        //            obb.Fun_Non_Query(up1);

        //        }

        //        string sel1 = "select max(billid) from billtab where userid=" + Session["uid"] + "";
        //        string bi = obb.Fun_scalar(sel1);
        //        string up2 = "update billtab set billstatus='Failed' where billid=" + bi + "";
        //        obb.Fun_Non_Query(up2);
        //    }

        //            }
        //        }
        //    }
        //        protected void Button1_Click(object sender, EventArgs e)
        //        {
        //            try
        //            {
        //                balanacereferencess.ServiceClient obj = new balanacereferencess.ServiceClient();
        //                decimal bal = obj.balancecheck(Convert.ToInt32(Session["uid"]));

        //                if (decimal.TryParse(TextBox1.Text, out decimal gt))
        //                {
        //                    if (bal >= gt)
        //                    {
        //                        string accQuery = "SELECT MAX(accid) FROM account WHERE userid=" + Session["uid"];
        //                        string s = obb.Fun_scalar(accQuery);
        //                        int accountId = Convert.ToInt32(s);

        //                        decimal newBalance = bal - gt;
        //                        string updateBalanceQuery = "UPDATE account SET balamount=" + newBalance + ", status='Deactive' WHERE accid=" + accountId;

        //                        int result = obb.Fun_Non_Query(updateBalanceQuery);

        //                        if (result == 1)
        //                        {
        //                            List<int> orderIds = new List<int>();
        //                            string orderQuery = "SELECT orderid FROM otb WHERE userid=" + Session["uid"] + " AND orderstatus='ordered'";
        //                            SqlDataReader drOrders = obb.Fn_reader(orderQuery);

        //                            while (drOrders.Read())
        //                            {
        //                                orderIds.Add(Convert.ToInt32(drOrders["orderid"]));
        //                            }

        //                            foreach (int orderId in orderIds)
        //                            {
        //                                string updateOrderStatusQuery = "UPDATE otb SET orderstatus='paid' WHERE orderid=" + orderId;
        //                                obb.Fun_Non_Query(updateOrderStatusQuery);
        //                            }

        //                            string billQuery = "SELECT MAX(billid) FROM billtab WHERE userid=" + Session["uid"];
        //                            string billId = obb.Fun_scalar(billQuery);

        //                            string updateBillStatusQuery = "UPDATE billtab SET billstatus='Paid' WHERE billid=" + billId;
        //                            obb.Fun_Non_Query(updateBillStatusQuery);

        //                            // Handle product stock update logic
        //                            UpdateProductStock(Session["uid"].ToString());

        //                            Label3.Visible = true;
        //                            Label3.Text = "Successfully Paid";
        //                        }
        //                    }
        //                    else
        //                    {
        //                        HandleInsufficientBalance(Session["uid"].ToString(), bal, gt);
        //                    }
        //                }
        //                else
        //                {
        //                    Label3.Visible = true;
        //                    Label3.Text = "Invalid amount entered.";
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                Label3.Visible = true;
        //                Label3.Text = "An error occurred: " + ex.Message;
        //            }
        //        }

        //        private void UpdateProductStock(string userId)
        //        {
        //            string productQuery = "SELECT productid FROM otb WHERE orderstatus='Paid' AND userid=" + userId;
        //            List<int> productIds = new List<int>();
        //            SqlDataReader drProducts = obb.Fn_reader(productQuery);

        //            while (drProducts.Read())
        //            {
        //                productIds.Add(Convert.ToInt32(drProducts["productid"]));
        //            }

        //            foreach (int productId in productIds)
        //            {
        //                string stockQuery = "SELECT productstock, productquanity FROM prtb INNER JOIN otb ON prtb.productid = otb.productid WHERE otb.productid=" + productId;
        //                SqlDataReader drStock = obb.Fn_reader(stockQuery);

        //                if (drStock.Read())
        //                {
        //                    decimal productStock = Convert.ToDecimal(drStock["productstock"]);
        //                    decimal productQuantity = Convert.ToDecimal(drStock["productquanity"]);

        //                    decimal newStock = productStock - productQuantity;

        //                    string updateStockQuery = "UPDATE prtb SET productstock=" + newStock + " WHERE productid=" + productId;
        //                    obb.Fun_Non_Query(updateStockQuery);
        //                }
        //            }
        //        }

        //        private void HandleInsufficientBalance(string userId, decimal balance, decimal amount)
        //        {
        //            Label3.Visible = true;
        //            Label3.Text = "Insufficient balance";

        //            string accQuery = "SELECT MAX(accid) FROM account WHERE userid=" + userId;
        //            string accountId = obb.Fun_scalar(accQuery);

        //            string updateAccountStatusQuery = "UPDATE account SET status='Deactive' WHERE accid=" + accountId;
        //            obb.Fun_Non_Query(updateAccountStatusQuery);

        //            List<int> orderIds = new List<int>();
        //            string orderQuery = "SELECT orderid FROM otb WHERE userid=" + userId + " AND orderstatus='Ordered'";
        //            SqlDataReader drOrders = obb.Fn_reader(orderQuery);

        //            while (drOrders.Read())
        //            {
        //                orderIds.Add(Convert.ToInt32(drOrders["orderid"]));
        //            }

        //            foreach (int orderId in orderIds)
        //            {
        //                string updateOrderStatusQuery = "UPDATE otb SET orderstatus='Cancelled' WHERE orderid=" + orderId;
        //                obb.Fun_Non_Query(updateOrderStatusQuery);
        //            }

        //            string billQuery = "SELECT MAX(billid) FROM billtab WHERE userid=" + userId;
        //            string billId = obb.Fun_scalar(billQuery);

        //            string updateBillStatusQuery = "UPDATE billtab SET billstatus='Failed' WHERE billid=" + billId;
        //            obb.Fun_Non_Query(updateBillStatusQuery);
        //        }
        //    }
        //}

    }
}














