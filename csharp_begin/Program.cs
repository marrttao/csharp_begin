namespace csharp_start
{
    public class Program
    {
        public int FToC(int f)
        {
            return (int)((f - 32) * 5 / 9);
        }
        public int CToF(int c)
        {
            return (int)(c * 9 / 5 + 32);
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Write F: ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine($"F in C: {program.FToC(f)}");
            Console.WriteLine("Write C:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"C in F: {program.CToF(c)}");
              
        }
    }
}