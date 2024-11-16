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
   
    public partial class product : System.Web.UI.Page
    {
SqlConnection con=new SqlConnection(@"server=DESKTOP-656UNUD\SQLEXPRESS;database=projectarya;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                gridbind_fun();
            }
            string ss = "select categoryid,categoryname from categtb";
            SqlDataAdapter da = new SqlDataAdapter(ss, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "categoryname";
            DropDownList1.DataValueField= "categoryid";
            DropDownList1.DataBind();

          
            
        }
        public void gridbind_fun()
        {
            string c = "select *from prtb";
            SqlDataAdapter da = new SqlDataAdapter(c, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Label15.Text = DropDownList4.SelectedItem.Text;

            Label16.Text =DropDownList4.SelectedItem.Value;
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

            Label13.Visible = true;
            
            Label14.Visible = true;
           


            string ins = "insert into prtb values(" + DropDownList4.Text + ",'" + p + "','" + TextBox2.Text + "'," + TextBox4.Text + ",'" + TextBox3.Text + "'," + TextBox7.Text + ",'" + ch + "','" + TextBox8.Text + "','" + TextBox6.Text + "')";
            SqlCommand cmd = new SqlCommand(ins, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i==1)
            {
                Label10.Visible = true;
                Label10.Text = "inserted";
            }

        }

      
        protected void GridView2_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

            GridViewRow rw = GridView2.Rows[e.NewSelectedIndex];
            Label22.Visible = true;
            Label23.Visible = true;
            Label24.Visible = true;
            Label25.Visible = true;
            Label22.Text = rw.Cells[4].Text;
            Label23.Text = rw.Cells[5].Text;
            Label24.Text = rw.Cells[6].Text;
            Label25.Text = rw.Cells[7].Text;
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
            int j = e.RowIndex;
            int id1 = Convert.ToInt32(GridView2.DataKeys[j].Value);
            TextBox txtim = (TextBox)GridView2.Rows[j].Cells[5].Controls[0];
            TextBox txtpri = (TextBox)GridView2.Rows[j].Cells[6].Controls[0];
            TextBox txtdesc = (TextBox)GridView2.Rows[j].Cells[7].Controls[0];
            TextBox txtstoc = (TextBox)GridView2.Rows[j].Cells[8].Controls[0];
            string upd = "update prtb set productimage='" + txtim.Text + "',productprice='" + txtpri.Text + "',productdescription='" + txtdesc.Text + "',productstock='" + txtstoc.Text + "'     where productid=" + id1 + "";
            SqlCommand cmd = new SqlCommand(upd, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            gridbind_fun();
            GridView2.EditIndex = -1;
            gridbind_fun();
        }

       
    }
}