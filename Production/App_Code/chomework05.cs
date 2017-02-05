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
	
		public int clsintVowelCount (string strtext)
        {
            int intCount = 0;
            // make everything lower case to make matching easier - eliminates UPPER CASE letters
            strtext=strtext.ToLower();
            foreach (char c in strtext)
            {
                string strtemp = Convert.ToString(c);
                switch (strtemp)
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
        public int clsintWordCount(string strtext)
        {
            MatchCollection collection = Regex.Matches(strtext, @"[\S]+");
            return collection.Count;
        }
        public string clsstrReverse(string strText)
        {
            string strOut = "";
            int intCounter = strText.Length;
            int intPos = 0;

            while (intCounter >0)
            {
                strOut=strOut+ strText.Last();
                intPos = strText.Length-1;
                if (intPos > 0)
                {
                    strText = strText.Substring(0, strText.Length - 1);
                    intCounter--;
                }
                else
                    intCounter--;
            }

            return strOut;
        }
        public string clsstrPhone(string strtext)
        {
            strtext=strtext.Insert(0, "(");
            strtext = strtext.Insert(4, ")-");
            strtext = strtext.Insert(9, "-");
            return strtext;

        }
	
}