namespace csharp_start
{
    public class Program
    {
        public List<int> GetEvenNumbersInRange(int start, int end)
        {
            List<int> result = new List<int>();
            if (start > end)
            {
                for (int i = end; i <= start; i++)
                {
                    if (i % 2 == 0)
                    {
                        result.Add(i);
                    }
                }
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 0)
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
       
        public static void Main(string[] args)
        {
            Program program = new Program();
            int start, end;
            Console.WriteLine("Enter the start of the range:");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end of the range:");
            end = int.Parse(Console.ReadLine());
            List<int> evenNumbers = program.GetEvenNumbersInRange(start, end);
            Console.WriteLine("Even numbers in the range:");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            
            
        }
    }
}