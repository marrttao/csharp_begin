namespace csharp_begin
{
    public class Program
    {
        public static int connect_inputs(string[] arr)
        {
            string result = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            int result_int = int.Parse(result);
            return result_int;
        }

        static string[] get_inputs()
        {
            string[] arr = new string[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a number: ");
                arr[i] = Console.ReadLine();
            }
            return arr;
        }

        public static void Main(string[] args)
        {
            string[] input = get_inputs();
            Console.WriteLine(connect_inputs(input));
        }
    }
}