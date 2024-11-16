using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication10
{
    public partial class admin1 : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(regid) from logtb";
            string regid = obj.Fun_scalar(sel);
            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;
            }
            string inse = "insert into admintable values(" + regid + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + ")";
            int i = obj.Fun_Non_Query(inse);
            if (i == 1)
            {
                string inslog = "insert into logtb values(" + regid + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','admin','active')";
                int j = obj.Fun_Non_Query(inslog);
            }
        }
    }
}