using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication10
{
    public partial class user : System.Web.UI.Page
    {
        concls objec = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string sel = "select max(regid) from logtb";
            string reg_id = objec.Fun_scalar(sel);
            int regid1 = 0;
            if (reg_id == "")
            {
                regid1 = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(reg_id);
                regid1 = newregid + 1;
            }
            string inse = "insert into utab values(" + regid1+" ,'" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + ",'" + TextBox4.Text + "'," + TextBox5.Text + ",'" + DropDownList3.Text + "','" + DropDownList4.Text + "','" + TextBox9.Text + "')";
            int i = objec.Fun_Non_Query(inse);
            if (i == 1)
            {
                string inslog = "insert into logtb values(" + regid1 + ",'" + TextBox7.Text + "','" + TextBox8.Text + "','user','active')";
                int j = objec.Fun_Non_Query(inslog);
            }
        }
    }
}