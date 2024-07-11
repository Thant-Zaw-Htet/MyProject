namespace SquareRoot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            float  num = Convert.ToInt32(Console.ReadLine());
            float result = (num * num)/2;
            Console.WriteLine(result);
        }
    }
}