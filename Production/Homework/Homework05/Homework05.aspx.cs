using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Class: ASP.NET with C# 2
//Author: Chris Boylan
//Abstract: Homework 5

public partial class Homework_Homework05_Homework05 : System.Web.UI.Page
{
    chomework05 myCode = new chomework05();
    chomework04 myCal = new chomework04();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void msgbox(string message)
    {
        //string message = "welcome in code solution";
        ClientScript.RegisterStartupScript(GetType(), "alert", "alert('" + message + "');", true);


    }
    protected void btnCountVowels_Click(object sender, EventArgs e)
    {
        string stemp = "This is the number of vowels - ";
        if ( myCal.bStringCheck(txtSentence.Text))
        {
            stemp = " You must enter a string into the Sentence box.";
        }
        else
	    {
            stemp = stemp + Convert.ToString(myCode.iVowelCount(txtSentence.Text));
                
	    }
        
        msgbox(stemp);
    }
    protected void btnCountWords_Click(object sender, EventArgs e)
    {
        string stemp = "This is the number of words - ";
        if (myCal.bStringCheck(txtSentence.Text))
        {
            stemp = " You must enter a string into the Sentence box.";
        }
        else
        {
            stemp = stemp + Convert.ToString(myCode.iWordCount(txtSentence.Text));

        }

        msgbox(stemp);
    }
    protected void btnReverse_Click(object sender, EventArgs e)
    {
        string stemp = "";
        if (myCal.bStringCheck(txtSentence.Text))
        {
            stemp = " You must enter a string into the Sentence box.";
            msgbox(stemp);
            
        }
        else
        {
            stemp = Convert.ToString(myCode.sReverse(txtSentence.Text));
            txtSentence.Text = stemp;

        }
        


    }
    protected void btnBreak_Click(object sender, EventArgs e)
    {
        if (myCal.bStringCheck(txtRecord.Text))
            msgbox(" You must enter a string in the Record text box.");
        else
            BreakApartRecord();
            
    }
    protected void BreakApartRecord ()
    {
        int iCount = 1;
        string sText = txtRecord.Text;
        string[] split = sText.Split(',');

        foreach (string item in split)
        {
            switch (iCount)
            {
                case 1:
                    txtField1.Text = item.Trim();
                    break;
                case 2:
                    txtField2.Text = item.Trim();
                    break;
                case 3:
                    txtField3.Text = item.Trim();
                    break;
                case 4:
                    txtField4.Text = item.Trim();
                    break;
                case 5:
                    txtField5.Text = item.Trim();
                    break;
                case 6:
                    txtField6.Text = item.Trim();
                    break;
                default:
                    txtField6.Text = txtField6.Text + item.Trim();
                    break;

            }
            iCount++;
            txtRecord.Text = "";
        }

    }
    protected void btnRejoin_Click(object sender, EventArgs e)
    {
        PutFieldsTogether();
    }
    protected void PutFieldsTogether()
    {
        string stemp = "";
        string sSeperator = ",";
        stemp = txtField1.Text + sSeperator + txtField2.Text + sSeperator + txtField3.Text + sSeperator + txtField4.Text + sSeperator + txtField5.Text + sSeperator + txtField6.Text;
        txtField1.Text = "";
        txtField2.Text = "";
        txtField3.Text = "";
        txtField4.Text = "";
        txtField5.Text = "";
        txtField6.Text = "";
        txtRecord.Text = stemp;
    }
    protected void btnPhone_Click(object sender, EventArgs e)
    {
        txtPhoneOut.Text = myCode.sPhone(txtPhoneNumber.Text);
    }
}