namespace DotnetFundamental.PrimeNumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 1)
            {
                Console.WriteLine($"{num} is not a prime number.");
            }
            else
            {
                for (int i = 2; i <= num; i++)
                {
                    if (i >= num)
                    {
                        Console.WriteLine($"{num} is a prime number.");
                        break;
                    }
                    else
                    {
                        if ((num % i) == 0)
                        {
                            Console.WriteLine($"{num} is not a prime number.");
                            break;
                        }
                    }
                }
            }
        }
    }
}
