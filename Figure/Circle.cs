using System;
using System.Collections.Generic;

namespace Figure
{
    public class Circle : Figure
    {
        private readonly double _r;
        public override Dictionary<string, double> GetParam()
        {
            return new Dictionary<string, double>
            {
                {"r", _r}
            };
        }

        public Circle(double r)
        {
            if (r <= 0)
            {
                throw new Exception("Impossible circle");
            }
            _r = r;
        }
    }
}