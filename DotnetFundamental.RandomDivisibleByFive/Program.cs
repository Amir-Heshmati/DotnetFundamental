namespace DotnetFundamental.RandomDivisibleByFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int number = random.Next(1, 101);

            Console.WriteLine($"Random Number: {number}");

            if (number % 5 == 0)
            {
                Console.WriteLine($"{number} is divisible by 5.");
            }
            else
            {
                Console.WriteLine($"{number} is not divisible by 5.");
            }
        }
    }
}
