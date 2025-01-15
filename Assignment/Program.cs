namespace Assignment
{
    #region Q1
    //internal enum WeekDays
    //{
    //    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    //}
    #endregion

    #region Q3
    //internal enum Season
    //{
    //    Spring, Summer, Autumn, Winter
    //}
    #endregion

    #region Q5
    internal enum Colors
    {
        Red, Green, Blue
    }
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
            //Person p1 = new Person("Mahmoud", 20);
            //Person p2 = new Person("Ahmed", 50);
            //Person p3 = new Person("Ibraim", 21);

            //Person[] people = { p1, p2, p3 };

            //foreach (Person p in people)
            //{
            //    Console.WriteLine(p.ToString());
            //}
            #endregion

            #region Q3
            //Console.Write("Enter a season: ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, out Season season))
            //{
            //    string range;
            //    switch(season)
            //    {
            //        case Season.Spring:
            //            range = "march to may";
            //            break;
            //        case Season.Summer:
            //            range = "june to august";
            //            break;
            //        case Season.Autumn:
            //            range = "september to november";
            //            break;
            //        case Season.Winter:
            //            range = "december to february";
            //            break;
            //        default:
            //            range = "invalid season";
            //            break;
            //    };
            //    Console.WriteLine($"The season is {season} and the range is {range}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season");
            //}
            #endregion

            #region Q4
            // مش فاهم السؤال
            #endregion

            #region Q5
            Console.Write("Enter a color: ");
            string input = Console.ReadLine();

            Colors color;

            bool isPresent = false;

            for (int i = 0; i < 3; i++)
            {
                color = (Colors)i;
                if (color.ToString().ToLower() == input.ToLower())
                {
                    isPresent = true;
                    break;
                }

            }
            if (isPresent) {
                Console.WriteLine($"The color {input.ToLower()} is in the enum.");
            }
            else
            {
                Console.WriteLine("The color is not present in the enum");
            }
            #endregion
        }

    }
}
