namespace Assignment
{
    #region Q1
    //internal enum WeekDays
    //{
    //    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //WeekDays weekDays;
            //for (int i = 0; i < 7; i++)
            //{
            //    weekDays = (WeekDays)i;
            //    Console.WriteLine(weekDays);
            //}
            #endregion

            #region Q2
            Person p1 = new Person("Mahmoud", 20);
            Person p2 = new Person("Ahmed", 50);
            Person p3 = new Person("Ibraim", 21);

            Person[] people = { p1, p2, p3 };

            foreach (Person p in people)
            {
                Console.WriteLine(p.ToString());
            }
            #endregion
        }
    }
}
