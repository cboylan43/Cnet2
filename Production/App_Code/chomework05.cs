using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

//Class: ASP.NET with C# 2
//Author: Chris Boylan
//Abstract: Homework 5


public class chomework05
{
	
		public int iVowelCount (string stext)
        {
            int intCount = 0;
            // make everything lower case to make matching easier - eliminates UPPER CASE letters
            stext=stext.ToLower();
            foreach (char c in stext)
            {
                string stemp = Convert.ToString(c);
                switch (stemp)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        intCount++;
                        break;
                    default:
                        break;
                }
            }

            return intCount;
            
        }
        public int iWordCount(string stext)
        {
            MatchCollection collection = Regex.Matches(stext, @"[\S]+");
            return collection.Count;
        }
        public string sReverse(string sText)
        {
            string sOut = "";
            int intCounter = sText.Length;
            int intPos = 0;

            while (intCounter >0)
            {
                sOut=sOut+ sText.Last();
                intPos = sText.Length-1;
                if (intPos > 0)
                {
                    sText = sText.Substring(0, sText.Length - 1);
                    intCounter--;
                }
                else
                    intCounter--;
            }

            return sOut;
        }
        public string sPhone(string stext)
        {
            stext=stext.Insert(0, "(");
            stext = stext.Insert(4, ")-");
            stext = stext.Insert(9, "-");
            return stext;

        }
	
}