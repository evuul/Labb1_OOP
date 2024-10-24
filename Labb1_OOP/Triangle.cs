namespace Labb1_OOP;

public class Triangle
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    public void GetPerimeter()
    {
        Console.WriteLine($"För att räkna ut omkrets på en triangel behöver vi ta sidan A + sidan B + sidan C vilket blir: {SideA + SideB + SideC}");
    }
}