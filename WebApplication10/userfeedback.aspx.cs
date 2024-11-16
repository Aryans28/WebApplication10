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
    public partial class userfeedback : System.Web.UI.Page
    {
        concls ob = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ii = "insert into feedbk values(" + Session["uid"] + ",'" + TextBox1.Text + "','',0)";
            int i = ob.Fun_Non_Query(ii);
            if(i==1)
            {
                Label1.Visible = true;
                Label1.Text = "succesfully inserted";
            }


























            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "sp_feedbck";

            //cmd.Parameters.AddWithValue("@uid", Session["uid"]);
            //cmd.Parameters.AddWithValue("@feedbkmsg", TextBox1.Text);
            //cmd.Parameters.AddWithValue("@reply","");
            //cmd.Parameters.AddWithValue("@feedst", 0);



            //SqlParameter sp = new SqlParameter();
            //sp.DbType = DbType.Int32;
            //sp.ParameterName = "@status";
            //sp.Direction = ParameterDirection.Output;
            //cmd.Parameters.Add(sp);

            //ob.Fun_Non_Querywithsp(cmd);

            //int status = Convert.ToInt32(sp.Value);

            //if (status == 1)
            //{
            //    Label1.Visible = true;
            //    Label1.Text = "your feedback sent";

            //}
            //else
            //{
            //    Label1.Visible = true;
            //    Label1.Text = "something went wrong";
            //}


        }
    }
}