using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Class: ASP.NET with C# 2
//Author: Chris Boylan
//Abstract: Homework 3

public partial class Homework_Homework03_Homework03 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        txtResults.Text = "";
        double dblHeight = Convert.ToDouble(txtHeight.Text);
        double dblWidth = Convert.ToDouble(txtWidth.Text);
        txtResults.Text = Convert.ToString(0.5 * dblHeight * dblHeight);
        

    }
   
}