namespace csharp_start
{
    public class Program
    {
        public int[] ParseTwoNumbers(string inputA, string inputB)
        {
            if (!int.TryParse(inputA, out int a))
                throw new FormatException("Invalid input for first number");

            if (!int.TryParse(inputB, out int b))
                throw new FormatException("Invalid input for second number");

            return new int[] { a, b };
        }

        public int Percentage(int total, int percent)
        {
            return (total * percent) / 100;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            string inputA = Console.ReadLine();

            Console.WriteLine("Enter Second Number:");
            string inputB = Console.ReadLine();

            Program p = new Program();
            int[] arr = p.ParseTwoNumbers(inputA, inputB);

            Console.WriteLine("The percentage " + arr[1] + " from " + arr[0] + " is " + p.Percentage(arr[0], arr[1]));
        }
    }
}