
internal class Program
{
    public static DateTime GetNextDate(DateTime initialDate, int frequencyDays, DateTime limitDate)
    {
        // Write a program that keeps adding frequencyDays to initialDate until the result does past limitDate in constant time. Hint use modulo or division.
        int daysDiff = (limitDate - initialDate).Days;

        // Get maximum of int that is multiple of frequencyDays not exceeding daysDiff
        int maxMultiple = daysDiff - (daysDiff % frequencyDays);
        return initialDate.AddDays(maxMultiple);
    }
    public static void Main(string[] args)
    {
        DateTime initialDate = new DateTime(2001, 5, 12);
        int frequencyDays = 7;
        DateTime limitDate = DateTime.Now;

        for (int i = 0; i < 10; i++)
        {
            DateTime nextDate = GetNextDate(initialDate, frequencyDays, limitDate);
            Console.WriteLine($"last {nextDate.DayOfWeek} before {limitDate} is {nextDate}");
            if (initialDate.DayOfWeek != nextDate.DayOfWeek)
            {
                throw new Exception();
            }
            initialDate = initialDate.AddDays(1);
        }

        initialDate = new DateTime(2001, 5, 12);
        frequencyDays = 14;
        for (int i = 0; i < 10; i++)
        {
            DateTime nextDate = GetNextDate(initialDate, frequencyDays, limitDate);
            Console.WriteLine($"last {nextDate.DayOfWeek} before {limitDate} is {nextDate}");
            if (initialDate.DayOfWeek != nextDate.DayOfWeek)
            {
                throw new Exception();
            }
            initialDate = initialDate.AddDays(1);
        }
    }
}