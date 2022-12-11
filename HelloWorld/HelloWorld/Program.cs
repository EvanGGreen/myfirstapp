
var x = new Main();
x.ExternalShowMessage(15);

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

}


