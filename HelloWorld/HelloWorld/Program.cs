
Main.ShowMessage();


public class Main
{
    private string evan = "Evan Green";
    private string dad = "Dad";

    public static void ShowMessage()
    {
        var main = new Main();

        Console.WriteLine($"Hello {main.evan} and {main.dad}");
    }
}



