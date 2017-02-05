using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Class: ASP.NET with C# 2
//Author: Chris Boylan
//Abstract: Homework 4

public partial class Homework_Homework04_Homework04 : System.Web.UI.Page
{
    chomework04 clsmyCal = new chomework04();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    // no valiadation needed for these because the pull no data from form
    protected void btnProblem1_Click(object sender, EventArgs e)
    {
       lblDescription.Text = " The answer to Problem 1 is: " + Convert.ToString(clsmyCal.iFact(100));
    }
    protected void btnProblem2_Click(object sender, EventArgs e)
    {
        lblDescription.Text = " The answer to Problem 2 is: " + Convert.ToString(clsmyCal.iOddAdd(300, -15));
    }
    protected void btnProblem3_Click(object sender, EventArgs e)
    {
       
        lblDescription.Text = " The answer to Problem 3 is :" + Convert.ToString(clsmyCal.dAdditionLoop());
    }
    protected void btnProblem4_Click(object sender, EventArgs e)
    {
        float sngbase = 0;
        float sngpercent = 0;
        if (clsmyCal.bFloatCheck(txtInput1.Text))
            sngbase = Convert.ToSingle(txtInput1.Text);
        else
        {
            lblDescription.Text = "Please enter an Number value in Input 1";
            return;
        }
        if (clsmyCal.bFloatCheck(txtInput2.Text))
            sngpercent = Convert.ToSingle(txtInput2.Text);
        else
        {
            lblDescription.Text = "Please enter an Nyumber value in Input 2";
            return;
        }
        
        //lblDescription.Text = " The answer to Problem 4 is : " + Convert.ToString(clsmyCal.CalculateMarkup(sngbase, sngpercent));
        lblDescription.Text = " The answer to Problem 4 is : " + string.Format("{0:C}",(clsmyCal.CalculateMarkup(sngbase, sngpercent)));
    }
    protected void btnProblem5_Click(object sender, EventArgs e)
    {
        if (clsmyCal.bStringCheck(txtInput1.Text))
        {
            lblDescription.Text = "Please enter a Name in Input 1";
            return;
        }
        if (clsmyCal.bStringCheck(txtInput2.Text))
        {
            lblDescription.Text = "Please enter a Name in Input 2";
            return;
        }
        
        
        lblDescription.Text = " The answer to Problem 5 is : " + clsmyCal.MakeFullName(txtInput1.Text, txtInput2.Text);
    }
    protected void btnProblem6_Click(object sender, EventArgs e)
    {
        int intText1 =0;
        int intText2 =0;

        if (clsmyCal.bIntCheck(txtInput1.Text))
            intText1 = Convert.ToInt16(txtInput1.Text);
        else
        {
            lblDescription.Text = "Please enter an Integer value in Input 1";
            return;
        }
        if (clsmyCal.bFloatCheck(txtInput2.Text))
            intText2 = Convert.ToInt16(txtInput2.Text);
        else
        {
            lblDescription.Text = "Please enter an Integer value in Input 2";
            return;
        }

       //lblDescription.Text = " The answer to Problem 6 is : " + Convert.ToString(clsmyCal.CalculateCommision(intText2, intText1));
        lblDescription.Text = " The answer to Problem 6 is : " + string.Format("{0:C}", (clsmyCal.CalculateCommision(intText2, intText1)));
    }
    protected void btnProblem7_Click(object sender, EventArgs e)
    {
        int intText1 =0;
        if (clsmyCal.bIntCheck(txtInput1.Text))
            intText1 = Convert.ToInt16(txtInput1.Text);
        else
        {
            lblDescription.Text = "Please enter an Integer value in Input 1";
            return;
        }
     
        lblDescription.Text = " The answer to Problem 7 is : " + clsmyCal.NumberGuesser(4, intText1);
    }
    protected void btnProblem8_Click(object sender, EventArgs e)
    {
        double dblbase = 0;

        if (clsmyCal.bFloatCheck(txtInput1.Text))
            dblbase = Convert.ToDouble(txtInput1.Text);
        else
        {
            lblDescription.Text = "Please enter an Number value in Input 1";
            return;
        }

        lblDescription.Text = " The answer to Problem 8 is : " + Convert.ToString(clsmyCal.Problem8(dblbase));
    }
}