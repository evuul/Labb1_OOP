namespace Labb1_OOP;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        circle.GetArea();
        circle.GetVolume();
        
        Console.WriteLine();
        
        Circle circle2 = new Circle(6);
        circle2.GetArea();
        circle2.GetVolume();

        Console.WriteLine();

        Triangle triangle = new Triangle(10, 5, 7);
        triangle.GetPerimeter();
    }
}