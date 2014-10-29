using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Metoden Main ska anropa metoden ViewMenu() för att visa en meny. 
             * Väljer användaren att inte avsluta applikationen ska med metoden CreateShape() 
             * anropas som skapar och returnerar en referens till ett Ellips- eller Rectangle-objekt. 
             * Referensen till objektet används sedan vid anrop av ViewDetail() som presenterar figurens detaljer. 
             * Då en beräkning är gjord ska menyn visas på nytt. 
             * Meny alternativen är numrerade från 0 till 2 och väljer inte användaren ett värde i det slutna 
             * intervallet mellan 0 och 2 ska ett felmeddelande visas och användaren uppmanas att trycka på en 
             * tangent för att få en ny chans att ange ett korrekt menyalternativ.*/

            ViewMenu();
            do
            {
                

                //int index;  
                //Console.WriteLine("Ange menyval [0-2]:");
                //option = int.Parse(Console.ReadLine()); //menyval
                /*if (option >= 1 || option >= 2)
                    if (option != 0)*/
                //if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 2)
                //{
                //ShapeType option = ShapeType.Undefined;

                int index;
                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 2) //FL14 ca 40min
                {
                    ShapeType option = ShapeType.Ellipse;
                    switch (index)
                    {
                        case 0:
                            return; //avsluta programmet

                        case 1:
                            option = ShapeType.Ellipse;
                            ViewShapeDetail(CreateShape(option));
                            break;

                        case 2:
                            option = ShapeType.Rectangle;
                            ViewShapeDetail(CreateShape(option));
                            break;

                        default:
                            Console.WriteLine("FEL! Du måste välja en siffra mellan 0 och 2");
                            break;
                    }
                    //if (option = ShapeType.Ellipse || option = ShapeType.Rectangle)
                    //{
                    //    ViewShapeDetail(CreateShape(option));
                    //}

                }
                else
                {
                    Console.WriteLine("Fel! siffran är inte mellan 0-2");
                }
            } while (true);
        }

            //private static int GetMenuValue()
            //{
            //    int index;
            //    do 
            //    {
            //        if (int.TryParse(Console.ReadLine(), out index) && index >=0 && index <= 2)
            //        {
            //            return index;
            //        }

            //    } while (true);
            //}
                    //}
                    /*else
                    {
                        Console.WriteLine("Avslutar");
                        return; //AVsluta programmet
                    }*/
                /*else
                {
                    throw new ArgumentOutOfRangeException("FEL! Ange ett nummer mellan 0 och 2. \n Tryck tangent för att fortsätta");
                    //Console.ReadKey();
                }*/
                            

        /*Metoden CreateShape 
         * Den privata statiska metoden CreateShape ska läsa in en figurs längd och bredd, 
         * skapa objektet och returnera en referens till det. 
         * Metoden ska ha en parameter av typen ShapeType vars värde bestämmer om en ellips eller rektangel ska skapas. */
        
        private static Shape CreateShape(ShapeType shapeType) 
        {
            double length = ReadDoubleGreaterThanZero("Ange längden: ");
            double width = ReadDoubleGreaterThanZero("Ange bredden: ");

            if(shapeType == ShapeType.Ellipse)
            {
                Ellipse ellipse = new Ellipse(length, width);
                return ellipse;
            }
            else 
            {
                Rectangle rectangle = new Rectangle(length, width);
                return rectangle;
            }

        }


        /*Metoden ReadDoubleGreaterThanZero 
         * Den privata statiska metoden ReadDoubleGreaterThanZero() ska returnera ett värde av typen double som är större än 0. 
         * Till metoden ska det vara möjligt att skicka med ett argument. 
         * Argument ska vara en sträng med information som ska visas i anslutning till där inmatningen av värdet sker. 
         * I Figur A.9 har argumenten "Ange längden: " skickats med som argument vid anropet av metoden. 
         * Om det inmatade inte kan tolkas som ett korrekt värde ska användaren få en chans att göra en ny inmatning 
         * efter att ett tydligt felmeddelande presenterats (se Figur A.9).*/
        private static double ReadDoubleGreaterThanZero(string textmeasure)
        {
            double measure;
            do
            {
                Console.WriteLine(textmeasure);
                if (double.TryParse(Console.ReadLine(), out measure) && measure > 0)
                {
                    return measure;
                }
                else
                {
                    Console.WriteLine("Fel! Ange ett flyttal större än 0");
                }
            } while (true);
        }


        /*Metoden ViewMenu Den privata statiska metoden ViewMenu() ska bara presentera en meny. 
         * Någon inläsning ska inte göras av metoden. */
        private static void ViewMenu()
        {
            //Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("=            MENY           =");
            Console.WriteLine("=============================");
            Console.WriteLine("=                           =");
            Console.WriteLine("=        0. Avsluta.        =");
            Console.WriteLine("=        1. Ellips.         =");
            Console.WriteLine("=        2. Rektangel.      =");
            Console.WriteLine("=                           =");
            Console.WriteLine("=============================");
            Console.WriteLine("=     Ange menyval [0-2]:   =");
            Console.WriteLine("=============================");
          

        }


        /*Metoden ViewShapeDetail 
         * Den privata statiska metoden ViewShapewDetail() ska presentera en figurs detaljer.
         * Vid anrop av metoden skickas ett argument med som refererar till figurens vars detaljer ska presenteras. 
         * Parametern shape av typen Shape refererar till figuren. 
         * Genom att utnyttja att basklassen Shape överskuggar metoden ToString() förenklas koden väsentligt 
         * då en figurs längd, bredd, omkrets och area ska presenteras. */
        private static void ViewShapeDetail(Shape shape)
        {
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine(shape.ToString());
            Console.WriteLine();
            Console.WriteLine("=============================");

            Console.WriteLine("Tryck en tangent för ny beräkning");
            Console.ReadKey();
            Console.Clear();
            ViewMenu();
        }
    }
}


