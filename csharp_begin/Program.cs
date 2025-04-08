namespace csharp_start
{
    public class Program
    {
        public int Percentage(int total, int percent)
        {
            return (total * percent) / 100;
        }

        public int[] getTwoNumbers()
        {
            int a, b;
            Console.WriteLine("Enter First Number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = int.Parse(Console.ReadLine());
            int[] arr = { a, b };
            return arr;
        }

        public static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = p.getTwoNumbers();
            Console.WriteLine("The percentage " + arr[1] + " from " + arr[0] + " is " + p.Percentage(arr[0], arr[1]));
        }
    }
}