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
    public partial class category : System.Web.UI.Page
    {
SqlConnection con=new SqlConnection(@"server=DESKTOP-656UNUD\SQLEXPRESS;database=projectarya;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                gridbind_fun();
            }
             

            }
            public void gridbind_fun()
            {
                string s = "select *from categtb";
                SqlDataAdapter da = new SqlDataAdapter(s, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridView2.DataSource = ds;
                GridView2.DataBind();
            }



        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/cat/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));


            string inse = "insert into categtb values('" + p + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            SqlCommand cmd = new SqlCommand(inse, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                Label4.Visible = true;
                Label4.Text = "inserted";
            }

            gridbind_fun();
        }
        protected void GridView2_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow rw = GridView2.Rows[e.NewSelectedIndex];
            Label9.Visible = true;
            Label10.Visible = true;
            Label9.Text = rw.Cells[3].Text;
            Label10.Text = rw.Cells[4].Text;
          

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
            TextBox txtimage = (TextBox)GridView2.Rows[i].Cells[5].Controls[0];
            TextBox txtdesc = (TextBox)GridView2.Rows[i].Cells[7].Controls[0];
       

            string up = "update categtb set categoryimage='" + txtimage.Text + "',categorydescription='" + txtdesc.Text + "',where categoryid=" + id1 + "";
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
       

     