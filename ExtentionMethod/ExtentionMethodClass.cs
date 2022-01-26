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
    }
}
