﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XuRunjing0221WebApplication
{
    public partial class MonthsWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lstMonth.Items.Add("January");
            lstMonth.Items.Add("February");
            lstMonth.Items.Add("March");
            lstMonth.Items.Add("April");
            lstMonth.Items.Add("May");
            lstMonth.Items.Add("June");

            lstMonth.Items.Add("July");
            lstMonth.Items.Add("August");
            lstMonth.Items.Add("October");
            lstMonth.Items.Add("November");
            lstMonth.Items.Add("December");
        }
    }
}