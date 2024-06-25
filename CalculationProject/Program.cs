using System.Diagnostics.Metrics;

namespace CalculationProject
{
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Choose a mathematics problem \n Press (1) Prime Number \n Press (2) Multiplication \n Enter (3) Even or Odd Number \n Press (4) Exit");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    PrimeNumber();
                }
                else if (choose == 2)
                {
                    Multiplication();
                }
                else if (choose == 3)
                {
                    OddAndEven();
                }
                else if (choose == 4)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }

        }

        public static void PrimeNumber()
        {
            while (true)
            {
                Console.WriteLine("Enter 'start' to start program or Enter 'menu' to go Menu Page or Enter 'end' to stop program.");
                string? enter = Console.ReadLine();
                if (enter.Equals("start"))

                {
                    Console.WriteLine("Enter a number:");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Boolean isPrime = true;

                    for (int i = 2; i <= Math.Sqrt(num); i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;

                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine($"{num} is Prime Number");
                    }
                    else
                    {
                        Console.WriteLine($"{num} is not Prime Number");
                    }
                }
                else if (enter.Equals("menu"))
                {
                    return;
                }
                else if (enter.Equals("end"))
                {
                    Console.WriteLine("Bye");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 'start', 'menu', or 'end'.");
                }
            }
        }

        public static void Multiplication()
        {

            while (true)
            {

                Console.WriteLine("Enter 'start' to start program or Enter 'menu' to go Menu Page or Enter 'end' to stop program.");
                string? enter = Console.ReadLine();
                if (enter.Equals("start"))
                {
                    Console.WriteLine("Enter a number you want to multiple:.");
                    int num = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= num; i++)
                    {
                        for (int j = 1; j <= 12; j++)
                        {
                            Console.WriteLine($"{i} X {j} = {i * j}");
                        }
                        Console.WriteLine("-------------");
                    }
                }
                else if (enter.Equals("menu"))
                {
                    return;
                }
                else if (enter.Equals("end"))
                {
                    Console.WriteLine("Bye");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 'start', 'menu', or 'end'.");
                }
            }

        }

        public static void OddAndEven()
        {
            while (true)
            {

                Console.WriteLine("Enter 'start' to start program or Enter 'menu' to go Menu Page or Enter 'end' to stop program.");
                string? enter = Console.ReadLine();
                if (enter.Equals("start"))
                {
                    Console.WriteLine("Enter any 10 elements: ");
                    int num = 0;
                    int evenCount = 0;
                    int oddCount = 0;


                    for (int i = 1; i <= 10; i++)
                    {

                        Console.WriteLine($"{i} element: {num = Convert.ToInt32(Console.ReadLine())} ");

                        if (num % 2 == 0)
                        {
                            evenCount++;
                        }
                        else
                        {
                            oddCount++;
                        }
                    }
                    Console.WriteLine($"Total Even numbers {evenCount}");
                    Console.WriteLine($"Total Odd numbers {oddCount}");

                }
                else if (enter.Equals("menu"))
                {
                    return;
                }
                else if (enter.Equals("end"))
                {
                    Console.WriteLine("Bye");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 'start', 'menu', or 'end'.");
                }
            }
        }
    }
}