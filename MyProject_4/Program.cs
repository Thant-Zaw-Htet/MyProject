namespace MyProject_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number you want to multiple: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++) {
                for (int j = 1; j <= 12; j++) { 
                    Console.WriteLine($"{i} x {j} = {i*j}");
                }
                Console.WriteLine(" ");
            }
        }
    }
}