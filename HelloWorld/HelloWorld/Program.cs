// See https://aka.ms/new-console-template for more information

Main.ShowMessage();


public class Main
{
    private string evan = "Evan";
    private string dad = "Dad";

    public static void ShowMessage()
    {
        var main = new Main();

        Console.WriteLine($"Hello {main.evan} and {main.daddy}");
        Console.WriteLine("Hello my dad");
    }
}



