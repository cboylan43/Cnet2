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
    chomework05 clsmyCode = new chomework05();
    chomework04 clsmyCal = new chomework04();
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
        string strtemp = "This is the number of vowels - ";
        if ( clsmyCal.bStringCheck(txtSentence.Text))
        {
            strtemp = " You must enter a string into the Sentence box.";
        }
        else
	    {
            strtemp = strtemp + Convert.ToString(clsmyCode.clsintVowelCount(txtSentence.Text));
                
	    }
        
        msgbox(strtemp);
    }
    protected void btnCountWords_Click(object sender, EventArgs e)
    {
        string strtemp = "This is the number of words - ";
        if (clsmyCal.bStringCheck(txtSentence.Text))
        {
            strtemp = " You must enter a string into the Sentence box.";
        }
        else
        {
            strtemp = strtemp + Convert.ToString(clsmyCode.clsintWordCount(txtSentence.Text));

        }

        msgbox(strtemp);
    }
    protected void btnReverse_Click(object sender, EventArgs e)
    {
        string strtemp = "";
        if (clsmyCal.bStringCheck(txtSentence.Text))
        {
            strtemp = " You must enter a string into the Sentence box.";
            msgbox(strtemp);
            
        }
        else
        {
            strtemp = Convert.ToString(clsmyCode.clsstrReverse(txtSentence.Text));
            txtSentence.Text = strtemp;

        }
        


    }
    protected void btnBreak_Click(object sender, EventArgs e)
    {
        if (clsmyCal.bStringCheck(txtRecord.Text))
            msgbox(" You must enter a string in the Record text box.");
        else
            BreakApartRecord();
            
    }
    protected void BreakApartRecord ()
    {
        int intCount = 1;
        string strText = txtRecord.Text;
        string[] astrsplit = strText.Split(',');

        foreach (string item in astrsplit)
        {
            switch (intCount)
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
            intCount++;
            txtRecord.Text = "";
        }

    }
    protected void btnRejoin_Click(object sender, EventArgs e)
    {
        PutFieldsTogether();
    }
    protected void PutFieldsTogether()
    {
        string strtemp = "";
        string strSeperator = ",";
        strtemp = txtField1.Text + strSeperator + txtField2.Text + strSeperator + txtField3.Text + strSeperator + txtField4.Text + strSeperator + txtField5.Text + strSeperator + txtField6.Text;
        txtField1.Text = "";
        txtField2.Text = "";
        txtField3.Text = "";
        txtField4.Text = "";
        txtField5.Text = "";
        txtField6.Text = "";
        txtRecord.Text = strtemp;
    }
    protected void btnPhone_Click(object sender, EventArgs e)
    {
        txtPhoneOut.Text = clsmyCode.clsstrPhone(txtPhoneNumber.Text);
    }
}