namespace csharp_start
{
    public class Program
    {
        public bool IsArmstrong(int number)
        {
            int sum = 0;
            int digits = number.ToString().Length;
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }

            return sum == number;
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (program.IsArmstrong(number))
            {
                Console.WriteLine($"{number} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number.");
            }
        }
    }
}