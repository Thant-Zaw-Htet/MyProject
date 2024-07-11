namespace SumOfArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            while (i <= 9)
            {   
                i++;
                Console.WriteLine($"Please enter {i} number:");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"Total sum of numbers: {sum} ");
        }
    }

}