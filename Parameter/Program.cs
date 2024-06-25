namespace Parameter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(10, 20));
            Console.WriteLine(Sum(10, 20, 10));
            Greeting("Zaw");

            Animal animal = new Animal();
            Console.WriteLine(animal.Name);
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Sum(int x, int y, int z) 
        { 
            return x + y + z;
        }
        public static void Greeting (string name)
        {
            Console.WriteLine("Mg Mg");
        }
    }
    public class Animal
    {
        public string Name = "Thant Zaw Htet";
        public Animal()
        {
            Console.WriteLine("Constructor is executed.");
        }
    }
}