namespace ObjectOrientedProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new();
            Console.WriteLine(dog.name);
            Console.WriteLine(dog.GetGender());
            Console.WriteLine(dog.GetAge());
        }
    }

    public class Animal
    {
        public string name = "Rambo";
        private int age = 6;
        protected char gender = 'M';

        public int GetAge()
        {
            return age;
        }

    }

    public class Dog : Animal
    {
        public char GetGender()
        {
            return gender;
            
        }
    }

}