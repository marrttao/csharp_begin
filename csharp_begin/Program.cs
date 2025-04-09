namespace csharp_start
{
    public class Program
    {
       
        public bool IsPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            int number;
            Console.WriteLine("Enter number");
            number = int.Parse(Console.ReadLine());
            if (program.IsPerfectNumber(number))
            {
                Console.WriteLine($"{number} is a perfect number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect number.");
            }
        }

    }
}