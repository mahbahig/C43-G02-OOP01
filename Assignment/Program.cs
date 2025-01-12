namespace Assignment
{
    #region Q1
    internal enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            WeekDays weekDays;
            for (int i = 0; i < 7; i++)
            {
                weekDays = (WeekDays)i;
                Console.WriteLine(weekDays);
            }
            #endregion
        }
    }
}
