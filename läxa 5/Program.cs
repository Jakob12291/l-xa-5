using System;

public class Circle
{
    // Privat fält för radien
    private double radius;

    // Konstruktor som tar radie som parameter
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Metod som räknar ut och returnerar arean
    public double GetArea()
    {
        return Math.PI * radius * radius;  // Formeln för area: π * r^2
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Skapa två objekt av klassen Circle
        Circle circle1 = new Circle(5);  // Cirkeln med radie 5
        Circle circle2 = new Circle(6);  // Cirkeln med radie 6

        // Beräkna och skriv ut arean för båda cirklarna
        Console.WriteLine("Arean av cirkeln med radie 5: " + circle1.GetArea());
        Console.WriteLine("Arean av cirkeln med radie 6: " + circle2.GetArea());
    }
}