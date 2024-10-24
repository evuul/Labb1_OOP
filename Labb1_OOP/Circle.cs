namespace Labb1_OOP;

public class Circle
{
    public int Radie { get; set; }
    
    // konstruktor för att sätta radie
    public Circle(int radie)
    {
        Radie = radie;
    }

    // metod för att räkna ut arean på en cirkel
    public void GetArea()
    {
        Console.WriteLine($"För att räkna ut arean på en cirkel behöver vi ta radie * radie * PI vilket blir: {Math.PI * Radie * Radie}");
    }
    
    // metod för att räkna ut volymen på en sfär
    public void GetVolume()
    {
        Console.WriteLine($"För att räkna ut volymen på en sfär behöver vi ta radie * radie * radie * PI * 4/3 vilket blir: {Math.PI * Radie * Radie * Radie * 4/3}");
    }
}