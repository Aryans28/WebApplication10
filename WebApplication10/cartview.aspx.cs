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
    public partial class cartview : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-656UNUD\SQLEXPRESS;database=projectarya;integrated security=true");
        //concls ob2 = new concls();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gridbind_fn();
            }

        }

        protected void gridbind_fn()
        {
            string i = "select sum(totalprice) from ctbbb";
            SqlCommand cmd = new SqlCommand(i, con);
           
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {

                    Label2.Text = "Total Price: " + result.ToString();
                }
                else
                {
                    Label2.Text = "Total Price: 0";
                }



            //string si= " SELECT dbo.prtb.productimage, dbo.prtb.productname, dbo.carttabb.productquanity, dbo.carttabb.totalprice FROM     dbo.prtb INNER JOIN  dbo.carttabb ON dbo.prtb.productid where dbo.carttabb.userid=" + Session["uid"] + "";

            string s = "select * from  ctbbb c left join prtb p on c.productid=p.productid where c.userid=" + Session["uid"] + "";

            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
      
    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow rw = GridView1.Rows[e.NewSelectedIndex];
            Label1.Visible = true;
           
            Label1.Text = rw.Cells[5].Text;
           
           
        }

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string ci = "delete from ctbbb where productid=" + getid + "";

            SqlCommand cmd = new SqlCommand(ci, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            gridbind_fn();
        }

        protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridbind_fn();
        }

        protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gridbind_fn();
        }

        protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            int j = e.RowIndex;
            int id1 = Convert.ToInt32(GridView1.DataKeys[j].Value);
            TextBox txt = (TextBox)GridView1.Rows[j].Cells[5].Controls[0];

            string upd = "update ctbbb set productquantity='" + txt.Text + "'";
            SqlCommand cmd = new SqlCommand(upd, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            gridbind_fn();
            GridView1.EditIndex = -1;
            gridbind_fn();

        }
    }
}

