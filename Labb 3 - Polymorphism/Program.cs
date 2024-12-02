using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb_3___Polymorphism.Square;

namespace Labb_3___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)                     // Leon Johansson SUT24
        {                                  // Uppdate: This code is primary using dynamic polymofism with ex. as the override metod of Area(), 
                                           // teh list contains all diffrent shapes and gets the area metod based on the shape that is called upon but overshadowed by the baseclass Geometry
                                           // All shapes is treated as a objeckt in Geometry / the baseclass
                                           // Console.WriteLine($"{ g.GetType().Name} har arean: {g.Area() }"); / akn användas i listan
            Console.WriteLine("Hello World!");
            // Instances of diffrent shapes
            Geometry circle = new Circle(4);
            Geometry square = new Square(7);
            Geometry rectangle = new Rectangle(2, 8);
            Geometry triangel = new Triangle(7, 9);
            // List that contains the diffrent Geometry types
            List<Geometry> list = new List<Geometry> { circle, square, rectangle, triangel };

            foreach (Geometry g in list) // Looping through each shape in the list and thier own Area methohd
            {
                Console.WriteLine("");
                // Console.WriteLine($"{ g.GetType().Name} har arean: {g.Area() }"); can use this asweall
                if (g == circle)
                {
                    Console.WriteLine($"En cirkel med radeien 4 är: {g.Area()}");
                }
                else if (g == square)
                {
                    Console.WriteLine($"En fyrkant med sidorna 7 är: {g.Area()}");
                }
                else if (g == rectangle)
                {
                    Console.WriteLine($"En rektangel med höjden 2 och bredden 8 är: {g.Area()}");
                }
                else if (g == triangel)
                {
                    Console.WriteLine($"En triangel med höjden 7 och bredden 9 är: {g.Area()}");
                }

                // static polymorfism
                // Geometry geo = new Geometry
                // double circleArea = geo.Area(4)
                // Console.WriteLine($"Circle area (radius 4): {circleArea}");
                // double rectangleArea = calculator.CalculateArea(2, 8);
                // Console.WriteLine($"rectangle area (height 2, base 8): {rectangleArea}");

            }
            // Meny if the user wanna try for themself
            Console.WriteLine("\nVill du testa själv? välj en av de 4 formerna som du vill se deras area: " +
                "\n 1. Cirkel" +
                "\n 2, Fyrkant" +
                "\n 3. Rektangel" +
                "\n 4. Triangel" +
                "\n 5. Exit");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: // If the user wanna get area of circle
                        Console.WriteLine("Skriv in radien på cirklen:");
                        double userRadius = Convert.ToDouble(Console.ReadLine());
                        Geometry userCircle = new Circle(userRadius);
                        Console.WriteLine($"{userCircle.Area()}");                     
                        Console.ReadKey();
                        Console.WriteLine("Tack för mig ha en bra dag");
                        Console.ReadKey();
                        break;

                    case 2: // " " of square
                        Console.WriteLine("Skriv in sidan på fyrkanten:");
                        double userSide = Convert.ToDouble(Console.ReadLine());
                        Geometry userSquare = new Square(userSide);
                        Console.WriteLine($"{userSquare.Area()}");
                        Console.WriteLine("Tack för mig ha en bra dag");
                        Console.ReadKey();
                        break;

                    case 3: // " "of rectangle
                        Console.WriteLine("Skriv in höjden av rektanglen:");
                        double userHeight = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Skriv in breden av rektanglen:");
                        double userWidth = Convert.ToDouble(Console.ReadLine());
                        Geometry userRectangle = new Rectangle(userHeight, userWidth);
                        Console.WriteLine($"{userRectangle.Area()}");
                        Console.WriteLine("Tack för mig ha en bra dag");
                        Console.ReadKey();
                        break;

                    case 4: // " " of triangle
                        Console.WriteLine("Skriv in höjden på trianglen:");
                        double userTriHeight = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Skriv in basen på trianglen:");
                        double userTriWidth = Convert.ToDouble(Console.ReadLine());
                        Geometry userTriangle = new Triangle(userTriHeight, userTriWidth);
                        Console.WriteLine($"{userTriangle.Area()}");
                        Console.WriteLine("Tack för mig ha en bra dag");
                        Console.ReadKey();
                        break;
                    case 5:
                        // Exits program
                        break;
                    default:
                        Console.WriteLine("En siffra ditt stolpskott");
                        break;
                }
            }
            catch (Exception ex)    // Catch if user is silly goose
            {
                Console.WriteLine("Oväntat fel eller fel inmatning, programmet stängs ner");
                Console.ReadKey();
            }
        }
    } 
    /*static polymorfism ex.
    public class Geometry
    {
        public double Area()   //  for Area specific for a circle
        {
            return Radius * Radius * Math.PI;
        }
        public  double Area() // for Area specific for a rectangle
        {
            return Height * Width;
        }
    }*/
    public abstract class Geometry  // Geometyr abstract class 
    {
        public abstract double Area();  // Abstarct method for calculating area for the subclasses
        
    }
    public class Circle : Geometry // Subclass of Geometry
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()   // Override method for Area specific for a circle
        { 
            return Radius * Radius * Math.PI;
        }
    }
    public class Rectangle : Geometry   // Subclass of Geometry
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double Area() // Override method for Area specific for a rectangle
        {
            return Height * Width;
        }
    }
    public class Square : Geometry  // Subclass of Geometry
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }

        public override double Area()   // Override method for Area specific for a square
        {
            return Side * Side;
        }
  
    }
    public class Triangle : Geometry    // Subclass of Geometry
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Triangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double Area()   // Override method for Area specific for a triangle
        {
            return Height * Width / 2;
        }
    }
}
