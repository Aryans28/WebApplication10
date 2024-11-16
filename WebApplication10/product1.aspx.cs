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
    public partial class product1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-656UNUD\SQLEXPRESS;database=projectarya;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gridbind_fun();
            }
            string ss = "select categoryid,categoryname from categtb";
            SqlDataAdapter da = new SqlDataAdapter(ss, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "categoryname";
            DropDownList1.DataValueField = "categoryid";
            DropDownList1.DataBind();



        }
        public void gridbind_fun()
        {
            string c = "select *from prtb";
            SqlDataAdapter da = new SqlDataAdapter(c, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label11.Text = DropDownList1.SelectedItem.Text;

            Label12.Text = DropDownList1.SelectedItem.Value;
            string p = "~/cat/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string ch = "";
            for (int b = 0; b < CheckBoxList1.Items.Count; b++)
            {
                if (CheckBoxList1.Items[b].Selected)
                {
                    ch = ch + CheckBoxList1.Items[b].Text + ",";
                }
            }

           



            string ins = "insert into prtb values(" + DropDownList1.Text + ",'" + p + "','" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "'," + TextBox4.Text + ",'" + ch + "','" + TextBox6.Text + "')";
            SqlCommand cmd = new SqlCommand(ins, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                Label13.Visible = true;
                Label13.Text = "inserted";
            }
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow rw = GridView1.Rows[e.NewSelectedIndex];
            Label14.Visible = true;
            Label15.Visible = true;
            Label16.Visible = true;
            Label17.Visible = true;
            Label14.Text = rw.Cells[4].Text;
            Label15.Text = rw.Cells[5].Text;
            Label16.Text = rw.Cells[6].Text;
            Label17.Text = rw.Cells[7].Text;
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridbind_fun();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gridbind_fun();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int j = e.RowIndex;
            int id1 = Convert.ToInt32(GridView1.DataKeys[j].Value);
            TextBox txtim = (TextBox)GridView1.Rows[j].Cells[5].Controls[0];
            TextBox txtpri = (TextBox)GridView1.Rows[j].Cells[6].Controls[0];
            TextBox txtdesc = (TextBox)GridView1.Rows[j].Cells[7].Controls[0];
            TextBox txtstoc = (TextBox)GridView1.Rows[j].Cells[8].Controls[0];
            string upd = "update prtb set productimage='" + txtim.Text + "',productprice='" + txtpri.Text + "',productdescription='" + txtdesc.Text + "',productstock='" + txtstoc.Text + "'     where productid=" + id1 + "";
            SqlCommand cmd = new SqlCommand(upd, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            gridbind_fun();
            GridView1.EditIndex = -1;
            gridbind_fun();
        }
    }
}