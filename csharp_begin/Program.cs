namespace csharp_start
{
    public class Program
    {
        public string GetDate()
        {
            Console.WriteLine("Enter date in format dd.MM.yyyy");
            string date = Console.ReadLine();
            return date;
        }

        public string DateToDayOfWeek(string date)
        {
            DateTime dt = DateTime.ParseExact(date, "dd.MM.yyyy", null);
            string dayOfWeek = dt.DayOfWeek.ToString();
            return dayOfWeek;
        }

        public string DateToSeason(string date)
        {
            DateTime dt = DateTime.ParseExact(date, "dd.MM.yyyy", null);
            string season = "";
            if (dt.Month == 12 || dt.Month == 1 || dt.Month == 2)
                season = "Winter";
            else if (dt.Month >= 3 && dt.Month <= 5)
                season = "Spring";
            else if (dt.Month >= 6 && dt.Month <= 8)
                season = "Summer";
            else
                season = "Autumn";
            return season;
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            string date = program.GetDate();
            string dayOfWeek = program.DateToDayOfWeek(date);
            Console.WriteLine($"Day of the week: {dayOfWeek}");
            string season = program.DateToSeason(date);
            Console.WriteLine($"Season: {season}");
        }
    }
}