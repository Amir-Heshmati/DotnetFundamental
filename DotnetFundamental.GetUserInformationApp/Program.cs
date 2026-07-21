namespace DotnetFundamental.GetUserInformationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, User!");
            
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("What is your phone number?");
            string phone = Console.ReadLine();
            
            Console.WriteLine("What is your national code?");
            string nationalCode = Console.ReadLine();
            
            Console.WriteLine("What is your card number?");
            string cardNumber = Console.ReadLine();
        }
    }
}
