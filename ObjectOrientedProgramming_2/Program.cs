namespace ObjectOrientedProgramming_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal dog = new  Dog();
            dog.MakeSound();
        }
    }

    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal is making sound...");
        }
    }


    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dong is barking..");
        }
    }
}