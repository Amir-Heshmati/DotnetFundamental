namespace DotnetFundamental.MedianCalculator
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

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter Number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);

            double median;

            if (count % 2 == 0)
            {
                median = (numbers[count / 2 - 1] + numbers[count / 2]) / 2.0;
            }
            else
            {
                median = numbers[count / 2];
            }

            Console.WriteLine($"Median = {median:F2}");
        }
    }
}
