using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Rectangle : Shape
    {
        //egenskaper
        public override double Area //beräknar
        {
            get { return Length * Width; }
        }

        public override double Perimeter //beräknar
        {
            get { return (2 * Length) + (2 * Width); }
        }

        //kontruktor
        public Rectangle(double Length, double Width)
            : base(Length, Width) // konstruktorn i Shape samma som ellipse
        {

        }
    }
}
