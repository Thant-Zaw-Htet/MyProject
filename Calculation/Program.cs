namespace Calculation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculation();
            sum(10,2);
            Console.WriteLine(multiple(3,2));
        }
        public static void Calculation()
        {
            Console.WriteLine("Hello World");
        }
        public static void sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static int multiple(int a, int b)
        {
            return a * b;
        }
    }   
}