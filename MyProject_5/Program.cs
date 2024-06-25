namespace MyProject_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };

            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}

            List<string> name = new()
            {
                "Thant Zaw Htet",
                "Youn Htet Naing",
                "Kit Kit Aung"
            };

            name.ForEach(x => Console.WriteLine(x));



            int a = 0;

            while (a <= 10)
            {
                a++;
                if (a == 3)

                   continue;
                  
                   Console.WriteLine(a);
                
            }


            string fullName = "Thant Zaw Htet";

            //Console.WriteLine(fullName.Trim().Length);  

            string subName = fullName.Substring(3, 10);
            Console.WriteLine(subName);
        


            //Console.WriteLine("Enter your Email: ");
            //string? email = Console.ReadLine();

            //Console.WriteLine("Re-Enter your Email: ");
            //string? emailConfirm = Console.ReadLine();

            //if (string.IsNullOrEmpty(email))
            //{
            //    Console.WriteLine("Email is invalid");
            //}
            //else if (string.IsNullOrEmpty(emailConfirm))
            //{
            //    Console.WriteLine("Confirm Email is invalid");
            //}
            //else if (email.Trim().Equals(emailConfirm.Trim()))
            //{
            //    Console.WriteLine("\nSuccess");
            //}
            //else
            //{
            //    Console.WriteLine("\nYour email and confirm email is not equal");
            //}
        } 
    }
}

