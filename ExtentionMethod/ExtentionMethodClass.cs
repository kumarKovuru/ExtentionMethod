using MathsClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionMethod
{
    public static class ExtentionMethodClass
    {
        public static MathLibrary math = new MathLibrary();
        public static int Subs(this MathLibrary math, int a , int b)
        {
            return a - b;
        }

        //Creating extention method to check whether character is existed from a list of characters in a string

        public static bool isCharExists(this string str, params char[] inputChars)
        {
            for(int i = 0; i<inputChars.Length;i++)
            {
                if(str.Contains(inputChars[i].ToString()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
