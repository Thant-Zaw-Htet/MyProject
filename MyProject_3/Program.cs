 
public class MyProject_3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine()!;

        Console.WriteLine("Enter your age: ");
        int? age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your gender: ");
        char? gender = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter your address: ");
        string? address = Console.ReadLine();

        if (age <= 20 && gender.Equals('M'))
        {
            Console.WriteLine($"{name}. he is teenager. he lives in {address}. ");
        }
        else if (age >= 20 && gender.Equals('M'))
        {
            Console.WriteLine($"{name}. he became adult. he lives in {address}. ");
        }
        else if (age <= 20 && gender.Equals('F'))
        {
            Console.WriteLine($"{name}. she is teenager. she lives in {address}. ");
        }
        else if (age >= 20 && gender.Equals('F'))
            Console.WriteLine($"{name}. she became adult. she lives in {address}. ");
        }
    }

