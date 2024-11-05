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
        {
            Console.WriteLine("Hello World!");

            Geometry circle = new Circle(4);
            Geometry square = new Square(7);
            Geometry rectangle = new Rectangle(2, 8);
            Geometry triangel = new Triangle(7, 9);

            List<Geometry> list = new List<Geometry> { circle, square, rectangle, triangel};

            foreach (Geometry g in list) 
            {
                Console.WriteLine($"{ g.GetType().Name} har arean: {g.Area() }");
                Console.ReadKey();
            }
            Console.WriteLine(" Vill du testa själv? välj en av de 4 formerna som du vill se deras area: " +
                "\n 1. Cirkel" +
                "\n 2, Fyrkant" +
                "\n 3. Rektangel" +
                "\n 4. Triangel" +
                "\n 5. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Skriv in radien på cirklen:");
                    double userRadius = Convert.ToDouble(Console.ReadLine());
                    Geometry userCircle = new Circle(userRadius);
                    Console.WriteLine($"{ userCircle.Area() }");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Skriv in sidan på fyrkanten:");
                    double userSide = Convert.ToDouble(Console.ReadLine());
                    Geometry userSquare = new Square(userSide);
                    Console.WriteLine($"{ userSquare.Area() }");
                    break;

                case 3:
                    Console.WriteLine("Skriv in höjden av rektanglen:");
                    double userHeight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Skriv in breden av rektanglen:");
                    double userWidth = Convert.ToDouble(Console.ReadLine());
                    Geometry userRectangle = new Rectangle(userHeight, userWidth);
                    Console.WriteLine($"{ userRectangle.Area() }");

                    break;

                case 4:
                    Console.WriteLine("Skriv in höjden på trianglen:");
                    double userTriHeight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Skriv in basen på trianglen:");
                    double userTriWidth =Convert.ToDouble(Console.ReadLine());
                    Geometry userTriangle = new Triangle(userTriHeight, userTriWidth);
                    Console.WriteLine($"{ userTriangle.Area() }");
                    break;
                case 5:

                    break;
                default:
                    Console.WriteLine("En siffra dipshit");
                    break;
            }
        }
    } 
    public abstract class Geometry 
    {
        public abstract double Area(); 
        
    }
    public class Circle : Geometry 
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        { 
            return Radius * Radius * Math.PI;
        }
    }
    public class Rectangle : Geometry 
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double Area() 
        {
            return Height * Width;
        }
    }
    public class Square : Geometry 
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }
  
    }
    public class Triangle : Geometry
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Triangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Height * Width / 2;
        }
    }
}
