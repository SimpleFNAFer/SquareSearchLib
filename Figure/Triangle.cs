using System;
using System.Collections.Generic;

namespace Figure
{
    public class Triangle : Figure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public override Dictionary<string, double> GetParam()
        {
            Dictionary<string, double> p = new Dictionary<string, double>
            {
                {"a", _a},
                {"b", _b},
                {"c", _c}
            };
            return p;
        }

        public Triangle(double a, double b, double c)
        {
            var min1 = Math.Min(a, b);
            var min2 = Math.Min(Math.Max(a, b), c);
            var max = Math.Max(Math.Max(a, b), c);

            if (max > min1 + min2 || a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Impossible triangle");
            }
            _a = a;
            _b = b;
            _c = c;
        }
    }
}