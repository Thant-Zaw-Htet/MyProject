public class MyProject_2
{
    public static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int ranNum = randomNumber.Next(1,100);
        Console.WriteLine(ranNum);

        int count = 0;

        while (true)
        {
            Console.WriteLine("Enter your guess number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            count++;

            if (num == ranNum)
            {
                if (count == 1)
                {
                    Console.WriteLine("You are Genius...");break;
                }
                else if (count <= 5)
                {
                    Console.WriteLine("You are almost good.");break;
                }
                else if (count <= 10)
                {
                    Console.WriteLine("Ahh...Ok Not bad!");break;
                }
                else
                {
                    Console.WriteLine("So Stupid..");break;
                }
            }
            if(num > ranNum)
            {
                Console.WriteLine("Your guess number is greater than guess number.");
            }
            else
            {
                Console.WriteLine("Your guess number is less than guess number.");
            }
        }
    }
}