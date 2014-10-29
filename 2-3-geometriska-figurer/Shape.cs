using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer


    
{
    public enum ShapeType : int
    {
        Ellipse,
        Rectangle,
    }

    public abstract class Shape
    {
        //fält 
        private double _length;
        private double _width;

        
        //egenskaper
        public abstract double Area
        {
            get;
        }
        
        public double Length
        {
            get { return _length; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("Värdet är för litet.");
                }
                _length = value;
            }

        }

        public abstract double Perimeter
        {
            get;
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Värdet är för litet.");
                }
                _width = value;
            }
        }


        //kontruktor
        protected Shape(double length, double width) //ansvara för att fälten, via egenskaperna, tilldelas de värden konstruktorns parametrar har
        {
            Length = length;
            Width = width;
        }
        
        /*Metoden ToString 
         * Publik metod som överskuggar metoden ToString() i basklassen Object. 
         * Metoden ska returnera en sträng representerande värdet av en instans. 
         * Strängen ska vara lite speciellt formaterad och på separata rader innehålla 
         * ledtext och värde för figurens läng, bredd, omkrets och area. 
         * Längd  :      Length 
         * Bredd  :      Width 
         * Omkrets:      Perimeter 
         * Area   :      Area*/

        public override string ToString() 
        {
            return String.Format("Längd  :      {0}\nBredd  :      {1}\nOmkrets:      {2}\nArea   :      {3}", Length, Width, Perimeter, Area);
        }
    
    }
}
