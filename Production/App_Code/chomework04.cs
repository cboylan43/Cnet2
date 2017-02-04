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
	public int iFact(int n)
    {
        if (n <= 1)
            return 1;
        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result = result + i;
        }
        return result;
    }
    // will give the sum of all odd numbers between two other numbers
    public int iOddAdd(int intUpper, int intLower)
    {
        int iTotal = 0;

        for (int i = intLower; i < intUpper; i++)
        {
            if ((i % 2) != 0)
            {
                iTotal = iTotal + i;
            }
        }
        return iTotal;

    }
    // add every 6.78/2.17 number from ( -212 / 7.304 ) to -690.3 and return the result
    // yes  a one shot function, not really great coding.
    public double dAdditionLoop ( )
    {
        double dResult = 0;
        double d = (-212 / 7.304);
        
        while (d > (-690.3))
        {
            dResult = dResult + d;
            d=(d - (6.78/2.17));
        }
        return dResult;
    }
    // return price adjusted by percentage - use a negative percent to show a discount
    public float CalculateMarkup(float fbase, float fPercent)
    {
        float fResult = 0;
        fResult = (fbase + fbase * fPercent);
        return fResult;
    }
    // return the full name with the following format: “Last, First”.
    public string MakeFullName(string strFirstName, string strLastName)
    {
        return (strLastName + ", " + strFirstName);
    }
    // use switch statement to calculate the commission.   
    public double CalculateCommision ( int iPrice, int iNumberSold)
    {
        double iResult=0;
        switch ( iNumberSold)
        {
            case 1:
                // you only sold one item, you get nothing
                break;
            case 9:
                iResult = (iNumberSold*iPrice * 0.05);
                break;
            case 99:
                iResult = (iNumberSold*iPrice * 0.1);
                break;
            default:
                iResult = (iNumberSold*iPrice * 0.15);
                break;
        }

        return iResult;
    }
    // number guesser  - I chose to make the Secret Number a variable for future re-use
    public string NumberGuesser(int iSecretNumber, int iGuess)
    {
        string sResult = "Error in Function";
        if (iGuess < iSecretNumber)
            sResult = "Number too low.";
        if (iGuess == iSecretNumber)
            sResult = "You guessed it.";
        if (iGuess > iSecretNumber)
            sResult = "Number too high.";

        return sResult;
    }
    public double Problem8(double dNumber)
    {
        double dResult = 0;
        dResult = Math.Sqrt(Math.Pow(dNumber, 3) * 3 / (6 - 2));

        return dResult;
    }
      
    // this is to check if string input is an integer
    public Boolean bIntCheck(string sText)
    {
        int ignoreMe = 0;
        Boolean bresult = int.TryParse(sText, out ignoreMe);
        return bresult;
    }
    public Boolean bFloatCheck(string sText)
    {
        Single sIgnoreMe;
        Boolean bresult = Single.TryParse(sText, out sIgnoreMe);
        return bresult;
    }
    public Boolean bStringCheck ( string sText)
    {
        Boolean bresult = string.IsNullOrEmpty(sText);
        return bresult;
    }
}