namespace DotnetFundamental.AverageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to enter? ");
            int count = Convert.ToInt32(Console.ReadLine());

            if (count <= 0)
            {
                Console.WriteLine("The number of inputs must be greater than zero.");
                return;
            }

            double sum = 0;

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter Number {i}: ");
                sum += Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"Average = {sum / count:F2}");
        }
    }
}
