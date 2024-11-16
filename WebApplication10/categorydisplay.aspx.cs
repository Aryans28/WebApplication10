using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;



namespace WebApplication10
{
    public partial class categorydisplay : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-656UNUD\SQLEXPRESS;database=projectarya;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            gridbind_fun();

        }
        public void gridbind_fun()
        {
            string s = "select *from categorytable";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();
        }
     
       
        protected void GridView2_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow rw = GridView2.Rows[e.NewSelectedIndex];
            Label1.Visible = true;
            Label2.Visible = true;
            Label1.Text = rw.Cells[3].Text;
            Label2.Text = rw.Cells[4].Text;
        }
        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int id1 = Convert.ToInt32(GridView2.DataKeys[i].Value);
            string de = "delete from categorytable where categoryid=" + id1 + "";
            SqlCommand cmd = new SqlCommand(de, con);
            con.Open();
            int i1 = cmd.ExecuteNonQuery();
            con.Close();
            gridbind_fun();
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            gridbind_fun();
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            gridbind_fun();
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int id1 = Convert.ToInt32(GridView2.DataKeys[i].Value);
            TextBox txtdesc = (TextBox)GridView2.Rows[i].Cells[6].Controls[0];
            TextBox txtimage = (TextBox)GridView2.Rows[i].Cells[7].Controls[0];

            string up = "update categorytable set categorydescription='" + txtdesc.Text + "',categoryimage='" + txtimage.Text + "'where categoryid=" + id1 + "";
            SqlCommand cmd = new SqlCommand(up, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            gridbind_fun();
            GridView2.EditIndex = -1;
            gridbind_fun();
        }
    }
}