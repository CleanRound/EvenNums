internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the range to find all even numbers:");
        if (int.TryParse(Console.ReadLine(), out int num1) && int.TryParse(Console.ReadLine(), out int num2))
        {
            int start, end;
            if (num1 <= num2)
            {
                start = num1;
                end = num2;
            }
            else
            {
                start = num2;
                end = num1;
            }

            Console.WriteLine($"Even numbers in the range [{start}, {end}]:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input.");
        }
    }
}