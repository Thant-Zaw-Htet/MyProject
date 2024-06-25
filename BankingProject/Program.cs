using System.Numerics;
using System.Xml.Linq;

namespace BankingProject
{
    public class Program {

        public static void Main(string[] args)

        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your Password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Enter your PhoneNumber: ");
            string phoneInput = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Please fill in Username, Email, and Password!");
            }
            else if (string.IsNullOrEmpty(phoneInput) || !long.TryParse(phoneInput, out long phone))
            {
                Console.WriteLine("Please fill a valid Phone-number!");
            }
            else
            {
                User account = new User(name, email, password, phone);
                Console.WriteLine($"Your name is: {account.GetName()}");
                Console.WriteLine($"Your email is: {account.GetEmail()}");
                Console.WriteLine($"Your password is: {account.GetPassword()}");
                Console.WriteLine($"Your phone-number is: {account.GetPhone()}");
            }
        }
    }

    public class User
    {
        protected string name =  string.Empty;
        protected string email = string.Empty;
        protected string password = string.Empty;
        protected long? phone = null;

        public User(string name, string email, string password, long? phone)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.phone = phone;
        }

        public string GetName()
        {
            return name;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetPassword()
        {
            return password;
        }
        public long? GetPhone()
        {
            return phone;
        }
     
    }
}