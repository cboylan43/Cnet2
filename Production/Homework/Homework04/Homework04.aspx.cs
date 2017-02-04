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
    chomework04 myCal = new chomework04();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    // no valiadation needed for these because the pull no data from form
    protected void btnProblem1_Click(object sender, EventArgs e)
    {
       lblDescription.Text = " The answer to Problem 1 is: " + Convert.ToString(myCal.iFact(100));
    }
    protected void btnProblem2_Click(object sender, EventArgs e)
    {
        lblDescription.Text = " The answer to Problem 2 is: " + Convert.ToString(myCal.iOddAdd(300, -15));
    }
    protected void btnProblem3_Click(object sender, EventArgs e)
    {
       
        lblDescription.Text = " The answer to Problem 3 is :" + Convert.ToString(myCal.dAdditionLoop());
    }
    protected void btnProblem4_Click(object sender, EventArgs e)
    {
        float fbase = 0;
        float fpercent = 0;
        if (myCal.bFloatCheck(txtInput1.Text))
            fbase = Convert.ToSingle(txtInput1.Text);
        else
        {
            lblDescription.Text = "Please enter an Number value in Input 1";
            return;
        }
        if (myCal.bFloatCheck(txtInput2.Text))
            fpercent = Convert.ToSingle(txtInput2.Text);
        else
        {
            lblDescription.Text = "Please enter an Nyumber value in Input 2";
            return;
        }
        
        lblDescription.Text = " The answer to Problem 4 is : " + Convert.ToString(myCal.CalculateMarkup(fbase, fpercent));
    }
    protected void btnProblem5_Click(object sender, EventArgs e)
    {
        if (myCal.bStringCheck(txtInput1.Text))
        {
            lblDescription.Text = "Please enter a Name in Input 1";
            return;
        }
        if (myCal.bStringCheck(txtInput2.Text))
        {
            lblDescription.Text = "Please enter a Name in Input 2";
            return;
        }
        
        
        lblDescription.Text = " The answer to Problem 5 is : " + myCal.MakeFullName(txtInput1.Text, txtInput2.Text);
    }
    protected void btnProblem6_Click(object sender, EventArgs e)
    {
        int iText1 =0;
        int iText2 =0;

        if (myCal.bIntCheck(txtInput1.Text))
            iText1 = Convert.ToInt16(txtInput1.Text);
        else
        {
            lblDescription.Text = "Please enter an Integer value in Input 1";
            return;
        }
        if (myCal.bFloatCheck(txtInput2.Text))
            iText2 = Convert.ToInt16(txtInput2.Text);
        else
        {
            lblDescription.Text = "Please enter an Integer value in Input 2";
            return;
        }

       lblDescription.Text = " The answer to Problem 6 is : " + Convert.ToString(myCal.CalculateCommision(iText2, iText1));
    }
    protected void btnProblem7_Click(object sender, EventArgs e)
    {
        int iText1 =0;
        if (myCal.bIntCheck(txtInput1.Text))
            iText1 = Convert.ToInt16(txtInput1.Text);
        else
        {
            lblDescription.Text = "Please enter an Integer value in Input 1";
            return;
        }
     
        lblDescription.Text = " The answer to Problem 7 is : " + myCal.NumberGuesser(4, iText1);
    }
    protected void btnProblem8_Click(object sender, EventArgs e)
    {
        double dbase = 0;

        if (myCal.bFloatCheck(txtInput1.Text))
            dbase = Convert.ToDouble(txtInput1.Text);
        else
        {
            lblDescription.Text = "Please enter an Number value in Input 1";
            return;
        }

        lblDescription.Text = " The answer to Problem 8 is : " + Convert.ToString(myCal.Problem8(dbase));
    }
}