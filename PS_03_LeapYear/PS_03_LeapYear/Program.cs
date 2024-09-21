namespace PS_03_LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeapYear = LeapYear(year);
            Console.WriteLine($"Does {year} year a leap year? {isLeapYear} ");

        }
        public static bool LeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    return year % 400 == 0;
                }
                return true;
            }
            return false;
        }
    }
}
