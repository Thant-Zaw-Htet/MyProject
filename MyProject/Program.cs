public class Program
{
    public static void Main(string[] args)
    {
        List<string> name = new()
        {
            "HomeLander",
            "Solider Boy",
            "Billy Butcher"
        };

        foreach (string s in name)
        {
            Console.WriteLine(s);
        }
    }
}