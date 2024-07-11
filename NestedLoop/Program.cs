namespace NestedLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 2) 
            { 
                Console.WriteLine($"{num} is not Prime Number.");
            }

            Boolean isPrime = true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % 2 == 0)
                {
                    isPrime = false;
                    return;
                }

                if (isPrime)
                {
                    Console.WriteLine($"{num} is Prime Number.");
                }
                else 
                {
                    Console.WriteLine($"{num} is not Prime Number.");
                }

            }

        }
    }
}