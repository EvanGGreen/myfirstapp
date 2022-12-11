
var x = new Main();
Console.WriteLine($"The area of the rectangle is {x.CalculateAreaOfRectangle(1, 4)}");
Console.WriteLine($"The volume of the cube is {x.Calculatevolumeofcube(1, 4, 5)}");

public class Main
{

    private const double Pi = 3.1415;
    public const string evan = "Evan Green";

    public void ExternalShowMessage(double radis)
    {
       Console.WriteLine($"Hello {evan} the circle is {Calculate(radis)} feet when the radis is {radis}");
    }

    public double Calculate(double radis) 
    {
        return Pi * radis * radis;
    }

    public double  CalculateAreaOfRectangle(double length, double width)
    { return length * width; }

    public double Calculatevolumeofcube(double length, double width, double height)
    { return length * width * height; }

}


