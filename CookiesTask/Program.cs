using System;

namespace CookiesTask
{
    class Program
    {
        static void Main(string[] args)
        {
        Colour redcolour = new Colour(255,0,0, "red");
        Colour bluecolour = new Colour(0,0,255,"blue");
        Cookie a = new Cookie(50,"Circle", redcolour);
        Cookie b = new Cookie(100,"Square", redcolour);
        Cookie c = new Cookie(500,"Circle", bluecolour);
        Cookie d = new Cookie(50,"Dodecahedron", bluecolour);

        }
    }
    class Cookie
    {
        private int Weight;
        private string Shape;

        public string Colour { get; set; }

         public Cookie(int cWeight, string cShape, string cColour) 
         {
             Weight = cWeight;
             Shape = cShape;
             Colour = cColour;
         }
    }
    class Colour 
    {
        private int Red;

        private int Blue;

        private int Green;

        private string colour;

        public Colour(int r, int b, int g, string name)
        {
            Red = r;
            Blue = b;
            Green = g;
            colour = name;
        }
    }
}
