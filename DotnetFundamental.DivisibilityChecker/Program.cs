namespace DotnetFundamental.DivisibilityChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            else if (num1 % num2  == 0)
            {
                Console.WriteLine($"{num1} is divisible by {num2}.");
            }
            else
            {
                Console.WriteLine($"{num1} is not divisible by {num2}.");
            }
        }
    }
}
