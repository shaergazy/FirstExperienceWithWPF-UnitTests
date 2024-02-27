using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppForTPO
{
    public class Area
    {
        public double AreaRectangle(double a, double b)
        {
            return a * b;
        }
        public double AreaCircle(double a)
        {
            return (Math.Round(Math.PI * Math.Pow(Convert.ToDouble(a), 2)));
        }
    }
}
