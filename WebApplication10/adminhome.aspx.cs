﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication10
{
    public partial class adminhome : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label1.Text = "add category";

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Label2.Visible = true;
            Label2.Text = "add category";
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Label3.Visible = true;
            Label3.Text = " replyfeedback";
        }
    }
}