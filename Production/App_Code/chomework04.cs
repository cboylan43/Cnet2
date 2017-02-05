using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Class: ASP.NET with C# 2
//Author: Chris Boylan
//Abstract: Homework 4
public class chomework04
{
	// used to find the factorial of a number
	public int iFact(int intn)
    {
        if (intn <= 1)
            return 1;
        int result = 1;
        for (int i = 2; i <= intn; i++)
        {
            result = result + i;
        }
        return result;
    }
    // will give the sum of all odd numbers between two other numbers
    public int iOddAdd(int intUpper, int intLower)
    {
        int intTotal = 0;

        for (int inti = intLower; inti < intUpper; inti++)
        {
            if ((inti % 2) != 0)
            {
                intTotal = intTotal + inti;
            }
        }
        return intTotal;

    }
    // add every 6.78/2.17 number from ( -212 / 7.304 ) to -690.3 and return the result
    // yes  a one shot function, not really great coding.
    public double dAdditionLoop ( )
    {
        double dblResult = 0;
        double dbld = (-212 / 7.304);
        
        while (dbld > (-690.3))
        {
            dblResult = dblResult + dbld;
            dbld=(dbld - (6.78/2.17));
        }
        return dblResult;
    }
    // return price adjusted by percentage - use a negative percent to show a discount
    public float CalculateMarkup(float sngbase, float sngPercent)
    {
        float sngResult = 0;
        sngResult = (sngbase + sngbase * sngPercent);
        return sngResult;
    }
    // return the full name with the following format: “Last, First”.
    public string MakeFullName(string strFirstName, string strLastName)
    {
        return (strLastName + ", " + strFirstName);
    }
    // use switch statement to calculate the commission.   
    public double CalculateCommision ( int intPrice, int intNumberSold)
    {
        double dblResult=0;
        //   DANG C# SWITCH DOES NOT WORK AS WELL A VB  :)
        //switch ( intNumberSold)
        //{
        //    case 1:
        //        // you only sold one item, you get nothing
        //        break;
        //    case 9:
        //        dblResult = (intNumberSold*intPrice * 0.05);
        //        break;
        //    case 99:
        //        dblResult = (intNumberSold*intPrice * 0.1);
        //        break;
        //    default:
        //        dblResult = (intNumberSold*intPrice * 0.15);
        //        break;
        //}
        if (intNumberSold == 0)
            dblResult = 0;
        // nothing, you didn't sell anything
        else if (intNumberSold < 10)
            dblResult = (intNumberSold * intPrice * 0.05);
        else if (intNumberSold < 100)
            dblResult = (intNumberSold * intPrice * 0.1);
        else
            dblResult = (intNumberSold * intPrice * 0.15);
        



        return dblResult;
    }
    // number guesser  - I chose to make the Secret Number a variable for future re-use
    public string NumberGuesser(int intSecretNumber, int intGuess)
    {
        string strResult = "Error in Function";
        if (intGuess < intSecretNumber)
            strResult = "Number too low.";
        if (intGuess == intSecretNumber)
            strResult = "You guessed it.";
        if (intGuess > intSecretNumber)
            strResult = "Number too high.";

        return strResult;
    }
    public double Problem8(double dblNumber)
    {
        double dblResult = 0;
        dblResult = Math.Sqrt(Math.Pow(dblNumber, 3) * 3 / (6 - 2));

        return dblResult;
    }
      
    // this is to check if string input is an integer
    public Boolean bIntCheck(string strText)
    {
        int intignoreMe = 0;
        Boolean bresult = int.TryParse(strText, out intignoreMe);
        return bresult;
    }
    public Boolean bFloatCheck(string strText)
    {
        Single sngIgnoreMe;
        Boolean bresult = Single.TryParse(strText, out sngIgnoreMe);
        return bresult;
    }
    public Boolean bStringCheck ( string strText)
    {
        Boolean bresult = string.IsNullOrEmpty(strText);
        return bresult;
    }
}