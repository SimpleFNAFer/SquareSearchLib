using System;
using System.Collections.Generic;

namespace Figure
{
    public static class Operation
    {
        public static double Square(Figure figure)
        {
            Dictionary<string, double> param = figure.GetParam();
            switch (figure)
            {
                case Triangle:
                    var a = param["a"];
                    var b = param["b"];
                    var c = param["c"];

                    var max = Math.Max(a, b);
                    var min1 = Math.Min(a, b);
                    var min2 = Math.Min(max, c);
                    max = Math.Max(max, c);

                    if (Math.Abs(Math.Pow(max, 2) - (Math.Pow(min1, 2) + Math.Pow(min2, 2))) == 0)
                    {
                        return min1 * min2 / 2;
                    }
                    else
                    {
                        var p = (a + b + c)/2;
                        return Math.Sqrt(p*(p-a)*(p-b)*(p-c));   
                    }

                case Circle:
                    var r = param["r"];
                    return Math.PI * Math.Pow(r, 2);
                
            }

            throw new Exception("No cases found to solve this figure.");
        }
    }
}