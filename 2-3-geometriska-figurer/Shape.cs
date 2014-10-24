using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Shape
    {
        //fält 
        private double _length;
        private double _width;

        
        //egenskaper
        public double Area
        {
            get { }
            set { }
        }
        
        public double Length
        {
            get { }
            set { }

        }

        public double Perimeter
        {
            get { }
            set { }
        }

        public double Width
        {
            get { }
            set { }
        }


        //kontruktor
        protected Shape() //ansvara för att fälten, via egenskaperna, tilldelas de värden konstruktorns parametrar har
        {

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

        public string ToString() //returtyp?
        {
            return String.Format("Längd  :      {0}\nBredd  :      {1}\nOmkrets:      {2}\nArea   :      {3}", Length, Width, Perimeter, Area);
        }
    
    }
}
