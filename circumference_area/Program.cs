using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circumference_area
{
    class Program
    {
        static void Main(string[] args)
        {
            var cir = new Circle();

            var circ = cir.Calculate(r => 2 * Math.PI * r);
            var area = cir.Calculate(r => Math.PI * r * r);
        }
        
    }

    class Circle
    {
        double radius = 5;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }
}
