namespace DotnetFundamental.EvenOddChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} if even.");
            }
            else
            {
                Console.WriteLine($"{num} if odd.");
            }
        }
    }
}
