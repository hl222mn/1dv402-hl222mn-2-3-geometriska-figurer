using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Ellipse : Shape
    {
        //egenskaper
        public override double Area //beräknar
        {
            get { return Math.PI * Length / 2 * Width / 2; }
        }

        public override double Perimeter //beräknar
        {
            get { return Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2)); }
        }

        //kontruktor
        public Ellipse(double Length, double Width)
            : base(Length, Width) // konstruktorn i Shape samma som rectangle
        {
            
        }
    }
}
