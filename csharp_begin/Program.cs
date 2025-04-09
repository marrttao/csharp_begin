namespace csharp_start
{
    public class Program
    {
        public char[] getNumbers()
        {
            char[] number = new char[6];
            for (int i = 0; i < number.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine("Enter digit: ");
                    string input = Console.ReadLine();
                    if (input.Length == 1 && char.IsDigit(input[0]))
                    {
                        number[i] = input[0];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a single digit between 0 and 9.");
                    }
                }
            }
            return number;
        }

        public void swap(int a, int b, char[] number)
        {
            char temp = number[b];
            number[b] = number[a];
            number[a] = temp;
            string swappedNumber = new string(number);
            Console.WriteLine("Swapped number: " + swappedNumber);
        }


        public char[] SwapDigits(int a, int b, char[] number)
        {
            char[] copy = (char[])number.Clone();
            char temp = copy[b];
            copy[b] = copy[a];
            copy[a] = temp;
            return copy;
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            char[] number = program.getNumbers();
            program.swap(0, 5, number);
        }
    }
}