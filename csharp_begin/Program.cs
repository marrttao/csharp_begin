namespace csharp_start
{
    public class Program
    {
        public int GetUserInput()
        {
            int user;
            // readline user
            Console.WriteLine("Write a number between 1 and 100");
            user = int.Parse(Console.ReadLine());
            while (true)
            {
                if (user < 1 || user > 100)
                {
                    Console.WriteLine("Write a number between 1 and 100");
                    user = int.Parse(Console.ReadLine());
                }
                else
                {
                    return user;
                }
            }
        }

        public void CheckNumber(int user)
        {
            if (user % 3 == 0 && user % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (user % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (user % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(user);
            }
        }

        public static void Main(string[] args)
        {
            Program p = new Program();
            int user = p.GetUserInput();
            p.CheckNumber(user);
        }
    }
}