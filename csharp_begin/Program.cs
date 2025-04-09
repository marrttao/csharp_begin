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

        public string GetFizzBuzzResult(int user)
        {
            if (user % 3 == 0 && user % 5 == 0)
                return "FizzBuzz";
            else if (user % 3 == 0)
                return "Fizz";
            else if (user % 5 == 0)
                return "Buzz";
            else
                return user.ToString();
        }


        public static void Main(string[] args)
        {
            Program p = new Program();
            int user = p.GetUserInput();
            p.GetFizzBuzzResult(user);
        }
    }
}